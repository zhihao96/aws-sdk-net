using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using TestHelper;
using Xunit;
using CustomRoslynAnalyzers.Test.Data;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventDateTimeNowUseAnalyzerTests : DiagnosticVerifier
    {
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventDateTimeNowUseAnalyzer();
        }

        [Theory]
        [MemberData(nameof(PreventDataTimeNowUseAnalyzerData.TestCorrectData), MemberType = typeof(PreventDataTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeNowUseAnalyzer_Correct_Test(string data)
        {
            var expected = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expected);
        }

        // Test DateTime.Today and DateTime.Now and DateTime.UtcNow in methods
        [Theory]
        [MemberData(nameof(PreventDataTimeNowUseAnalyzerData.TestMethodData), MemberType = typeof(PreventDataTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Methods_Tests(string data, string attribute)
        {
            var testData = string.Format(data, attribute);
            CompareActualAndExpected(testData, "Main", "Program", attribute, 10, 24);
        }

        // Test DateTime.Use and DateTime.Now and DateTime.UtcNow in field
        [Theory]
        [MemberData(nameof(PreventDataTimeNowUseAnalyzerData.TestFieldData), MemberType = typeof(PreventDataTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Field_Tests(string data, string attribute)
        {
            var testData = string.Format(data, attribute);
            CompareActualAndExpected(testData, "null", "Program", attribute, 8, 32);
        }

        // Test DateTime.Use and DateTime.Now and DateTime.UtcNow in parameter
        [Theory]
        [MemberData(nameof(PreventDataTimeNowUseAnalyzerData.TestParameterData), MemberType = typeof(PreventDataTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Parameter_Tests(string data, string attribute)
        {
            var testData = string.Format(data, attribute);
            CompareActualAndExpected(testData, "Main", "Program", attribute, 10, 24);
        }

        // Test DateTime.Use and DateTime.Now and DateTime.UtcNow in parameter
        [Theory]
        [MemberData(nameof(PreventDataTimeNowUseAnalyzerData.TestPropertyData), MemberType = typeof(PreventDataTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Property_Tests(string data, string attribute)
        {
            var testData = string.Format(data, attribute);
            CompareActualAndExpected(testData, "null", "Program", attribute, 12, 24);
        }

        // Compare the actual diagnostic result with expected result
        private void CompareActualAndExpected(string testData, string method, string className, string dateTimeAttribute, int row, int colomn)
        {
            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventDateTimeNowUseRuleId,
                Message = string.Format(PreventDateTimeNowUseAnalyzer.MessageFormat, method, className, "System." + dateTimeAttribute),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", row, colomn)
                    }
            };
            VerifyCSharpDiagnostic(testData, expected);
        }
    }
}
