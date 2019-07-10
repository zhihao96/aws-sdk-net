using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestHelper;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using CustomRoslynAnalyzers.CodeFix;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventRegionEndpointUseAnalyzerTests : CodeFixVerifier
    {
        private const string DiagnosticMessage = "Target member uses {0}. This member {1} be used within the SDK.{2}";
        private const string USEast1ResolutionMessage = " Evaluate whether this usage is safe and add a suppression if it is.";

        [Fact]
        public void CR1004_PreventRegionEndpointUseAnalyzer_Tests()
        {
            var test = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class RegionEndpoint
    {
        public static string USEast1 = """";
        public static string USSouth1 = """";
    }
    class Program
    {
        public string test4 = RegionEndpoint.USEast1;

        static void Main(string[] args)
        {
        }
    }
}";
            var expectedField = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventRegionEndpointUseRuleId,
                Message = string.Format(DiagnosticMessage, "RegionEndpoint.USEast1", "shouldn't usually", USEast1ResolutionMessage),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 14, 31)
                    }
            };

            VerifyCSharpDiagnostic(test, expectedField);



            var codeFix = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class RegionEndpoint
    {
        public static string USEast1 = """";
        public static string USSouth1 = """";
    }
    class Program
    {
        [SuppressMessage(""AwsSdkRules"", ""CR1004"")]
        public string test4 = RegionEndpoint.USEast1;

        static void Main(string[] args)
        {
        }
    }
}";
            VerifyCSharpFix(test, codeFix);
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventRegionEndpointUseAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventRegionEndpointUseAnalyzerCodeFixProvider();
        }
    }
}
