using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using TestHelper;
using Xunit;
using CustomRoslynAnalyzers.Test.Data;
using Microsoft.CodeAnalysis.CodeFixes;
using CustomRoslynAnalyzers.CodeFix;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventHashAlgorithmCreateAnalyzerTests : CodeFixVerifier
    {
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventHashAlgorithmCreateAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventHashAlgorithmCreateAnalyzerCodeFix();
        }

        // A Correct Case Test
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestCorrectData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyzer_Correct_Test(string data)
        {
            var expected = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expected);
        }

        // A Test for HashAlgorithm.Create() in method
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestMethodData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyzer_Method_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "Main", "Program", invocation, 12, 24, testCodeFixData);   
        }

        // A Test for HashAlgorithm.Create() in field
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestFieldData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Field_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 10, 37, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Property
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestPropertyData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Property_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 14, 24, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Parameter
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestPassInParameterData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Parameter_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "Main", "Program", invocation, 12, 24, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Lambda Expression
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestLambdaData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Lambda_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 10, 67, testCodeFixData);
        }

        // A Test for HashAlgorithm.Create() in Delegate
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestDelegateData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Delegate_Test(string data, string invocation, string codeFixData)
        {
            var testData = string.Format(data, invocation);
            var testCodeFixData = string.Format(codeFixData, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 11, 59, testCodeFixData);
        }

        // Compare the actual diagnostic result with expected result
        private void CompareActualAndExpected(string testData, string methodName, string className, string invocation , int row, int column, string testCodeFixData)
        {
            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventHashAlgorithmCreateRuleId,
                Message = string.Format(PreventHashAlgorithmCreateAnalyzer.MessageFormat, methodName, className, "System.Security.Cryptography." + invocation),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", row, column)
                    }
            };
            VerifyCSharpDiagnostic(testData, expected);
            VerifyCSharpFix(testData, testCodeFixData);
        }
    }
}
