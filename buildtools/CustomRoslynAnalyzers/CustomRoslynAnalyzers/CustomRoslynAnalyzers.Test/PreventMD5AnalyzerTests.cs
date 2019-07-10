using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestHelper;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventMD5AnalyzerTests : DiagnosticVerifier
    {
        private const string DiagnosticMessage = "Type {0} of member {1} is a subclass of MD5. MD5 should not be used within the SDK, as it is not FIPS compliant.";
        [Fact]
        public void CR1000_PreventMD5Analyzer_Test()
        {
            var test = @"
using System;
using System.Security.Cryptography;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        public MD5 test;
        static void Main(string[] args)
        {
        }

        public void test3(MD5 m)
        {
            MD5 test4;
        }
        public MD5 test5 { get; set; }
    }
}";
            var expectedField = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventMD5UseRuleId,
                Message = string.Format(DiagnosticMessage, "System.Security.Cryptography.MD5", "Program"),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 9, 9)
                    }
            };

            var expectedInParameter = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventMD5UseRuleId,
                Message = string.Format(DiagnosticMessage, "System.Security.Cryptography.MD5", "test3"),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 14, 27)
                    }
            };

            var expectedInMethod = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventMD5UseRuleId,
                Message = string.Format(DiagnosticMessage, "System.Security.Cryptography.MD5", "test3"),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 16, 13)
                    }
            };

            var expectedProperty = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventMD5UseRuleId,
                Message = string.Format(DiagnosticMessage, "System.Security.Cryptography.MD5", "Program"),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 18, 9)
                    }
            };

            var expectedList = new DiagnosticResult[4];
            expectedList[0] = expectedField;
            expectedList[1] = expectedInParameter;
            expectedList[2] = expectedInMethod;
            expectedList[3] = expectedProperty;
            VerifyCSharpDiagnostic(test, expectedList);
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventMD5UseAnalyzer();
        }
    }
}
