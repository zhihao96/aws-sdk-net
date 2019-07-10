using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using TestHelper;
using Xunit;
using CustomRoslynAnalyzers.Test.Data;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventHashAlgorithmCreateAnalyzerTests : DiagnosticVerifier
    {
        // Correct Case Test
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestCorrectData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyzer_Correct_Test(string data)
        {
            var expected = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expected);
        }

        // Test HashAlgorithm.Create() in method
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestMethodData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyzer_Method_Test(string data, string invocation)
        {
            var testData = string.Format(data, invocation);
            CompareActualAndExpected(testData, "Main", "Program", invocation, 11, 24);   
        }

        // Test DateTime.Use and DateTime.Now and DateTime.UtcNow in field
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestFieldData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Field_Test(string data, string invocation)
        {
            var testData = string.Format(data, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 9, 37);
        }

        // Test DateTime.Use and DateTime.Now and DateTime.UtcNow in Property
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestPropertyData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Property_Test(string data, string invocation)
        {
            var testData = string.Format(data, invocation);
            CompareActualAndExpected(testData, "null", "Program", invocation, 13, 24);
        }

        // Test DateTime.Use and DateTime.Now and DateTime.UtcNow in Parameter
        [Theory]
        [MemberData(nameof(PreventHashAlgorithmCreateAnalyzerData.TestParameterData), MemberType = typeof(PreventHashAlgorithmCreateAnalyzerData))]
        public void CR1001_PreventHashAlgorithmCreateAnalyze_Parameter_Test(string data, string invocation)
        {
            var testData = string.Format(data, invocation);
            CompareActualAndExpected(testData, "Main", "Program", invocation, 11, 24);
        }

        // Compare the actual diagnostic result with expected result
        private void CompareActualAndExpected(string testData, string methodName, string className, string invocation , int row, int column)
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
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventHashAlgorithmCreateAnalyzer();
        }
    }
}
