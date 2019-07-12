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
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreventMD5UseAnalyzerCodeFix)), Shared]
    public class PreventMD5UseAnalyzerCodeFix : CodeFixProvider
    {
        private const string title = "Suppress Message of MD5.";

        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DiagnosticIds.PreventMD5UseRuleId); }
        }

        public sealed override FixAllProvider GetFixAllProvider()
        {
            return WellKnownFixAllProviders.BatchFixer;
        }

        public async sealed override Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);
            // This vairable is for using the method of CodeFixHelper.cs
            var codeFixHelper = new CodeFixHelper();

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
                    title: title,
                    createChangedSolution: c => codeFixHelper.CodeFixHelperInFieldAsync(context.Document, fieldDeclaration, c, DiagnosticIds.PreventMD5UseRuleId),
                    equivalenceKey: title),
                    diagnostic);
            }
            if (propertyDeclaration != null)
            {
                context.RegisterCodeFix(
                CodeAction.Create(
                    title: title,
                    createChangedSolution: c => codeFixHelper.CodeFixHelperInPropertyAsync(context.Document, propertyDeclaration, c, DiagnosticIds.PreventMD5UseRuleId),
                    equivalenceKey: title),
                    diagnostic);
            }

            if (methodDeclaration != null)
            {
                context.RegisterCodeFix(
                CodeAction.Create(
                    title: title,
                    createChangedSolution: c => codeFixHelper.CodeFixHelperInMethodAsync(context.Document, methodDeclaration, c, DiagnosticIds.PreventMD5UseRuleId),
                    equivalenceKey: title),
                    diagnostic);
            }
        }
    }
}
