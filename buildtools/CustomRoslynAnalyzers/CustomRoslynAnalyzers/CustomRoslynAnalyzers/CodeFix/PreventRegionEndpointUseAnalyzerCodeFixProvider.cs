using System;
using System.Composition;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Rename;
using Microsoft.CodeAnalysis.Text;

namespace CustomRoslynAnalyzers.CodeFix
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventRegionEndpointUseAnalyzerCodeFixProvider)), Shared]
    public class PreventRegionEndpointUseAnalyzerCodeFixProvider : CodeFixProvider
    {
        private const string title1 = "Suppress Message of RegionEndpoint.";
        private const string title2 = "aaa";

        public override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DiagnosticIds.PreventRegionEndpointUseRuleId); }
        }

        public sealed override FixAllProvider GetFixAllProvider()
        {
            return WellKnownFixAllProviders.BatchFixer;
        }

        public override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

            // TODO: Replace the following code with your own analysis, generating a CodeAction for each fix to suggest
            var diagnostic = context.Diagnostics.First();
            var diagnosticSpan = diagnostic.Location.SourceSpan;

            // Find the type declaration identified by the diagnostic.
            var fieldDeclaration = root.FindToken(diagnosticSpan.Start).Parent.AncestorsAndSelf().OfType<FieldDeclarationSyntax>().FirstOrDefault();
            var propertyDeclaration = root.FindToken(diagnosticSpan.Start).Parent.AncestorsAndSelf().OfType<PropertyDeclarationSyntax>().FirstOrDefault();
            var methodDeclaration = root.FindToken(diagnosticSpan.Start).Parent.AncestorsAndSelf().OfType<MethodDeclarationSyntax>().FirstOrDefault();

            // Register a code action that will invoke the fix.
            if (fieldDeclaration != null)
            {
                context.RegisterCodeFix(
                CodeAction.Create(
                    title: title1,
                    createChangedSolution: c => PreventRegionEndpointUseInFieldAsync(context.Document, fieldDeclaration, c),
                    equivalenceKey: title1),
                    diagnostic);
            }
            if (propertyDeclaration != null)
            {
                context.RegisterCodeFix(
                CodeAction.Create(
                    title: title1,
                    createChangedSolution: c => PreventRegionEndpointUseInPropertyAsync(context.Document, propertyDeclaration, c),
                    equivalenceKey: title1),
                    diagnostic);
            }

            if (methodDeclaration != null)
            {
                context.RegisterCodeFix(
                CodeAction.Create(
                    title: title1,
                    createChangedSolution: c => PreventRegionEndpointUseInMethodAsync(context.Document, methodDeclaration, c),
                    equivalenceKey: title1),
                    diagnostic);
            }
        }

        private async Task<Solution> PreventRegionEndpointUseInMethodAsync(Document document, MethodDeclarationSyntax methodDeclaration, CancellationToken cancellationToken)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken);
            if (methodDeclaration == null) return null;
            var attributes = methodDeclaration.AttributeLists.Add(
                SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList<AttributeSyntax>(
                    SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("SuppressMessage"))
                    .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("AWSSDKRules"))),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("CR1004")))
                        }
                        ))).NormalizeWhitespace())));

            return document.WithSyntaxRoot(
                root.ReplaceNode(
                    methodDeclaration,
                    methodDeclaration.WithAttributeLists(attributes)
                    )).Project.Solution;
        }

        private async Task<Solution> PreventRegionEndpointUseInFieldAsync(Document document, FieldDeclarationSyntax fieldDeclaration, CancellationToken cancellationToken)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken);
            if (fieldDeclaration == null) return null;

            var attributes = fieldDeclaration.AttributeLists.Add(
                SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList<AttributeSyntax>(
                    SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("SuppressMessage"))
                    .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("AwsSdkRules"))),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("CR1004")))
                        }
                        ))).NormalizeWhitespace())));

            return document.WithSyntaxRoot(
                root.ReplaceNode(
                    fieldDeclaration,
                    fieldDeclaration.WithAttributeLists(attributes)
                    )).Project.Solution;
        }

        private async Task<Solution> PreventRegionEndpointUseInPropertyAsync(Document document, PropertyDeclarationSyntax propertyDeclaration, CancellationToken cancellationToken)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken);
            if (propertyDeclaration == null) return null;
            var attributes = propertyDeclaration.AttributeLists.Add(
                SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList<AttributeSyntax>(
                    SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("SuppressMessage"))
                    .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("AWSSDKRules"))),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("CR1004")))
                        }
                        ))).NormalizeWhitespace())));

            return document.WithSyntaxRoot(
                root.ReplaceNode(
                    propertyDeclaration,
                    propertyDeclaration.WithAttributeLists(attributes)
                    )).Project.Solution;
        }
    }
}