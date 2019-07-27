using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using TestHelper;
using Xunit;
using CustomRoslynAnalyzers.Test.Data;
using CustomRoslynAnalyzers.CodeFix;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventDateTimeNowUseAnalyzerTests : CodeFixVerifier
    {
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventDateTimeNowUseAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventDateTimeNowUseAnalyzerCodeFix();
        }

        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestCorrectData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeNowUseAnalyzer_Correct_Test(string data)
        {
            var expected = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expected);
        }

        // A Test for DateTime.Today and DateTime.Now and DateTime.UtcNow in methods
        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestMethodData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Methods_Tests(string data, string attribute, string codeFixData)
        {
            var testData = string.Format(data, attribute);
            var testCodeFixData = string.Format(codeFixData, attribute);
            CompareActualAndExpected(testData, "Main", "Program", attribute, 11, 24, testCodeFixData);
        }

        // A Test for DateTime.Use and DateTime.Now and DateTime.UtcNow in field
        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestFieldData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Field_Tests(string data, string attribute, string codeFixData)
        {
            var testData = string.Format(data, attribute);
            var testCodeFixData = string.Format(codeFixData, attribute);
            CompareActualAndExpected(testData, "null", "Program", attribute, 9, 32, testCodeFixData);
        }

        // A Test for DateTime.Use and DateTime.Now and DateTime.UtcNow in parameter
        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestPassInParameterData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Parameter_Tests(string data, string attribute, string codeFixData)
        {
            var testData = string.Format(data, attribute);
            var testCodeFixData = string.Format(codeFixData, attribute);
            CompareActualAndExpected(testData, "Main", "Program", attribute, 11, 24, testCodeFixData);
        }

        // A Test for DateTime.Use and DateTime.Now and DateTime.UtcNow in parameter
        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestPropertyData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Property_Tests(string data, string attribute, string codeFixData)
        {
            var testData = string.Format(data, attribute);
            var testCodeFixData = string.Format(codeFixData, attribute);
            CompareActualAndExpected(testData, "null", "Program", attribute, 13, 24, testCodeFixData);
        }

        // A Test for DateTime.Use and DateTime.Now and DateTime.UtcNow in Lambda expressions
        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestLambdaData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Lambda_Tests(string data, string attribute, string codeFixData)
        {
            var testData = string.Format(data, attribute);
            var testCodeFixData = string.Format(codeFixData, attribute);
            CompareActualAndExpected(testData, "null", "Program", attribute, 9, 67, testCodeFixData);
        }

        // A Test for DateTime.Use and DateTime.Now and DateTime.UtcNow in Delegate expressions
        [Theory]
        [MemberData(nameof(PreventDateTimeNowUseAnalyzerData.TestDelegateData), MemberType = typeof(PreventDateTimeNowUseAnalyzerData))]
        public void CR1003_PreventDateTimeUseAnalyzer_Delegate_Tests(string data, string attribute, string codeFixData)
        {
            var testData = string.Format(data, attribute);
            var testCodeFixData = string.Format(codeFixData, attribute);
            CompareActualAndExpected(testData, "null", "Program", attribute, 10, 50, testCodeFixData);
        }

        // Compare the actual diagnostic result with expected result
        private void CompareActualAndExpected(string testData, string method, string className, string dateTimeAttribute, int row, int colomn, string testCodeFixData)
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
            VerifyCSharpFix(testData, testCodeFixData);
        }
    }
}
