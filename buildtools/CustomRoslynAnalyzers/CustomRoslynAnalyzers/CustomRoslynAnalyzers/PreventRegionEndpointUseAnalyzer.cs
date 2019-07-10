using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CustomRoslynAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PreventRegionEndpointUseAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not use static readonly RegionEndpoint members from within the SDK.";
        private const string MessageFormat = "Target member uses {0}. This member {1} be used within the SDK.{2}";
        private const string Category = "AwsSdkRules";
        private const string Description = "Makes sure none of the static readonly RegionEndpoint members are used directly within the SDK itself.";

        private const string USEast1EndpointName = ".USEast1";
        private const string USEast1ResolutionMessage = " Evaluate whether this usage is safe and add a suppression if it is.";
        //private const string RegionEndpointTypeName = "Amazon.RegionEndpoint";
        private const string RegionEndpointTypeName = "RegionEndpoint";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventRegionEndpointUseRuleId,
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
            var memberSymbol = context.SemanticModel.GetSymbolInfo(context.Node).Symbol;
            if (memberSymbol == null) return;

            var memberSymbolTypeName = memberSymbol.ContainingType.Name;
            if (memberSymbolTypeName != null && memberSymbolTypeName.Equals(RegionEndpointTypeName))
            {
                var memberAccessExpressionString = memberAccessExpr.ToString();
                //if (memberAccessExpressionString.EndsWith(USEast1EndpointName))
                //{
                    var diagnostic = Diagnostic.Create(Rule, memberAccessExpr.GetLocation(), memberAccessExpressionString, "shouldn't usually", USEast1ResolutionMessage);
                    context.ReportDiagnostic(diagnostic);
                //}
                //else
                //{
                //    var diagnostic = Diagnostic.Create(Rule, memberAccessExpr.GetLocation(), memberAccessExpressionString, "should never", "");
                //    context.ReportDiagnostic(diagnostic);
                //}
            }
        }

        //private void AnalyzeFieldNode(SyntaxNodeAnalysisContext context)
        //{
        //    var fieldDeclaration = (FieldDeclarationSyntax)context.Node;
        //    if (fieldDeclaration == null)
        //        return;

        //    // Check if Modifiers contains the static and readonly keyword
        //    var fieldModifiers = fieldDeclaration.Modifiers;
        //    var modifiersNameList = new List<string>();
        //    foreach(var m in fieldModifiers)
        //    {
        //        modifiersNameList.Add(m.Text);
        //    }
        //    if (modifiersNameList.Contains("readonly") && modifiersNameList.Contains("static"))
        //    {
        //        var fieldTypeSymbol = context.SemanticModel.GetSymbolInfo(fieldDeclaration.Declaration.Type).Symbol as INamedTypeSymbol;
        //        if (fieldTypeSymbol.Name == "RegionEndpoint")
        //        {
        //            var diagnostic = Diagnostic.Create(Rule, fieldDeclaration.GetLocation(), "0", "1", "2", "3");
        //            context.ReportDiagnostic(diagnostic);
        //        }
        //    }
        //}
    }
}
