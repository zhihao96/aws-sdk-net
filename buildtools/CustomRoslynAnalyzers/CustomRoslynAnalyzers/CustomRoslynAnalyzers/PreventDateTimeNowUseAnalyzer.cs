using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CustomRoslynAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PreventDateTimeNowUseAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not use DateTime.Now or DateTime.UtcNow, use AWSSDKUtils.CorrectedNow or AWSSDKUtils.CorrectedUtcNow";
        public static string MessageFormat = "Method {0} of member {1} gets {2}. This property should not be used within the SDK, and instead AWSSDKUtils.CorrectedNow or AWSSDKUtils.CorrectedUtcNow should be used.";
        private const string Category = "AwsSdkRules";
        private const string Description = "Checks code for DateTime.Now or DateTime.UtcNow uses.";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventDateTimeNowUseRuleId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.SimpleMemberAccessExpression);
        }

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var memberAccessExpr = context.Node as MemberAccessExpressionSyntax;
            if (memberAccessExpr == null) return;

            // memberAccessExpr.Name == Now || UtcNow
            var memberAccessExprName = memberAccessExpr.Name.ToString();
            if (memberAccessExprName == nameof(DateTime.Now)
                || memberAccessExprName == nameof(DateTime.UtcNow)
                || memberAccessExprName == nameof(DateTime.Today))
            {
                var memberSymbol = context.SemanticModel.GetSymbolInfo(context.Node).Symbol;
                // check the method is a member of the class DateTime
                if (memberSymbol?.ContainingType.SpecialType == SpecialType.System_DateTime)
                {
                    var result = FindAncestors(context.Node.Ancestors());
                    var diagnostic = Diagnostic.Create(Rule, memberAccessExpr.GetLocation(), result[0] ?? "null", result[1], "System.DateTime." + memberAccessExprName);
                    context.ReportDiagnostic(diagnostic);
                }
            }
        }

        // Find the Method and Class that declares the DateTime.Now or DateTime.Today
        private string[] FindAncestors(IEnumerable<SyntaxNode> ancestors)
        {
            var result = new string[2];
            foreach (var ancestor in ancestors)
            {
                var type = ancestor.GetType();
                if (type.Equals(typeof(MethodDeclarationSyntax)))
                {
                    var methodDeclarationSyntax = ancestor as MethodDeclarationSyntax;
                    result[0] = methodDeclarationSyntax.Identifier.Text;
                }
                if (type.Equals(typeof(ClassDeclarationSyntax)))
                {
                    var classDeclarationSyntax = ancestor as ClassDeclarationSyntax;
                    result[1] = classDeclarationSyntax.Identifier.Text;
                }
            }
            return result;
        }
    }
}
