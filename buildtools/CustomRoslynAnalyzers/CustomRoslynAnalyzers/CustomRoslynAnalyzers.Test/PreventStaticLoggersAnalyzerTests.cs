using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using TestHelper;
using Xunit;
using CustomRoslynAnalyzers.CodeFix;
using CustomRoslynAnalyzers.Test.Data;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventStaticLoggersAnalyzerTests : CodeFixVerifier
    {
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventStaticLoggersAnalyzer();
        }

        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventStaticLoggerAnalyzerCodeFix();
        }

        // A test for the Correct Case
        [Fact]
        public void CR1002_PreventRegionEndpointUseAnalyzer_Correct_Tests()
        {
            string data = @"
namespace TestPreventStaticLoggersAnalyzer
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

        // A test for all of the senarios including Static Field, Static Property
        [Theory]
        [MemberData(nameof(PreventStaticLoggersAnalyzerData.AllTestData), MemberType = typeof(PreventStaticLoggersAnalyzerData))]
        public void CR1002_PreventStaticLoggersAnalyzer_Multiple_Tests(string dataWithoutLogger, 
            string declaringTypeName, string selfType, string interfaceName, 
            int row, int column, string codeFixDataWithoutLogger, string dataImplementILogger)
        {
            var data = string.Format(dataWithoutLogger, dataImplementILogger);
            var codeFixData = string.Format(codeFixDataWithoutLogger, dataImplementILogger);

            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventStaticLoggersRuleId,
                Message = string.Format(PreventStaticLoggersAnalyzer.MessageFormat, declaringTypeName, selfType, interfaceName),
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
