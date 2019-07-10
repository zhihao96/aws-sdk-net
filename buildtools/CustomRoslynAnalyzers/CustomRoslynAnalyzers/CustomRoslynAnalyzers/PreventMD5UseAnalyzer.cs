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
    public class PreventMD5UseAnalyzer : DiagnosticAnalyzer
    {
        private const string Title = "Do not use MD5";
        private const string MessageFormat = "Type {0} of member {1} is a subclass of MD5. MD5 should not be used within the SDK, as it is not FIPS compliant.";
        private const string Category = "AwsSdkRules";
        private const string Description = "Checks code for MD5 uses.";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticIds.PreventMD5UseRuleId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzePropertyNode, SyntaxKind.PropertyDeclaration);
            context.RegisterSyntaxNodeAction(AnalyzeFieldNode, SyntaxKind.FieldDeclaration);
            context.RegisterSyntaxNodeAction(AnalyzeMethodNode, SyntaxKind.MethodDeclaration);
        }

        // Analyze the Property Declaration
        private void AnalyzePropertyNode(SyntaxNodeAnalysisContext context)
        {
            var propertyDeclaration = (PropertyDeclarationSyntax)context.Node;
            if (propertyDeclaration == null)
                return;
            var propertySymbol = context.SemanticModel.GetDeclaredSymbol(propertyDeclaration);
            if (propertySymbol != null)
                CheckType(propertySymbol.Type, context, propertyDeclaration.GetLocation());
        }

        // Analyze the Field Declaration
        private void AnalyzeFieldNode(SyntaxNodeAnalysisContext context)
        {
            var fieldDeclaration = (FieldDeclarationSyntax)context.Node;
            if (fieldDeclaration == null)
                return;
            var fieldSymbol = (INamedTypeSymbol)context.SemanticModel.GetSymbolInfo(fieldDeclaration.Declaration.Type).Symbol;
            if (fieldSymbol != null)
                CheckType(fieldSymbol, context, fieldDeclaration.GetLocation());
        }

        // Analyze the Method
        private void AnalyzeMethodNode(SyntaxNodeAnalysisContext context)
        {
            var methodDeclaration = (MethodDeclarationSyntax)context.Node;

            // Analyze the parameter
            foreach (var parameter in methodDeclaration.ParameterList.Parameters)
            {
                var typeSymbol = context.SemanticModel.GetSymbolInfo(parameter.Type).Symbol as INamedTypeSymbol;
                if (typeSymbol != null)
                    CheckType(typeSymbol, context, parameter.GetLocation());
            }
            // Analyze the method body
            if (methodDeclaration.Body != null)
            {
                var methodBodyStatement = methodDeclaration.Body.Statements;
                foreach (var statement in methodBodyStatement)
                {
                    var localDeclaration = statement as LocalDeclarationStatementSyntax;
                    if (localDeclaration != null)
                    {
                        var typeSymbol = context.SemanticModel.GetSymbolInfo(localDeclaration.Declaration.Type).Symbol as INamedTypeSymbol;
                        if (typeSymbol != null)
                            CheckType(typeSymbol, context, statement.GetLocation());
                    }
                }
            }
        }

        private const string MD5FullName = "System.Security.Cryptography.MD5";
        private const string MD5ShortName = "MD5";
        private void CheckType(ITypeSymbol type, SyntaxNodeAnalysisContext context, Location location)
        {
            if (IsAssignableTo(type))
            {
                var returnResult = FindAncestors(context.Node);
                var diagnostic = Diagnostic.Create(Rule, location, type.ToString(), returnResult);
                context.ReportDiagnostic(diagnostic);
            }
        }

        private bool IsAssignableTo(ITypeSymbol type)
        {
            if (string.Equals(type.Name, MD5FullName) || string.Equals(type.Name, MD5ShortName))
                return true;

            var baseType = type.BaseType;
            if (baseType == null)
                return false;

            return IsAssignableTo(baseType);
        }


        // Find the Method and Class that declares the DateTime.Now or DateTime.Today
        private string FindAncestors(SyntaxNode node)
        {
            var ancestors = node.Ancestors();
            foreach (var ancestor in ancestors)
            {
                var type = ancestor.GetType();
                if (type.Equals(typeof(ClassDeclarationSyntax)))
                {
                    var test = node.GetType();
                    if (node.GetType().Equals(typeof(MethodDeclarationSyntax)))
                    {
                        return (node as MethodDeclarationSyntax).Identifier.Text;
                    }
                    if (node.GetType().Equals(typeof(FieldDeclarationSyntax))
                        || node.GetType().Equals(typeof(PropertyDeclarationSyntax)))
                    {
                        return (ancestor as ClassDeclarationSyntax).Identifier.Text;
                    }
                }
                if (type.Equals(typeof(MethodDeclarationSyntax)))
                {
                    var methodDeclarationSyntax = ancestor as MethodDeclarationSyntax;
                    return methodDeclarationSyntax.Identifier.Text;
                }

            }
            return "null";
        }
    }
}
