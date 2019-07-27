using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestHelper;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using CustomRoslynAnalyzers.CodeFix;
using CustomRoslynAnalyzers.Test.Data;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventRegionEndpointUseAnalyzerTests : CodeFixVerifier
    {
        private const string USEast1ResolutionMessage = "Evaluate whether this usage is safe and add a suppression if it is.";

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventRegionEndpointUseAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventRegionEndpointUseAnalyzerCodeFixProvider();
        }

        // A Test for the correct test
        [Fact]
        public void CR1004_PreventRegionEndpointUseAnalyzer_Correct_Tests()
        {
            string data = @"
namespace TestPreventRegionEndpointUseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}";
            var expected = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expected);
        }

        // A test for all of the senarios including Field, Property, InsideMethod, Declare Method, PassIn Parameter to Method, Lambda Expression, Delegate
        [Theory]
        [MemberData(nameof(PreventRegionEndpointUseAnalyzerData.TestInsideMethodData), MemberType = typeof(PreventRegionEndpointUseAnalyzerData))]
        public void CR1004_PreventRegionEndpointUseAnalyzer_Multiple_Tests(string data, int row, int column, string codeFixData)
        {
            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventRegionEndpointUseRuleId,
                Message = string.Format(PreventRegionEndpointUseAnalyzer.MessageFormat, "RegionEndpoint.USEast1", "shouldn't usually", USEast1ResolutionMessage),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", row, column)
                    }
            };
            VerifyCSharpDiagnostic(data, expected);
            VerifyCSharpFix(data, codeFixData);
        }
    }
}
