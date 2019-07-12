using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestHelper;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using CustomRoslynAnalyzers.Test.Data;
using CustomRoslynAnalyzers.CodeFix;
using Microsoft.CodeAnalysis.CodeFixes;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventMD5AnalyzerTests : CodeFixVerifier
    {
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventMD5UseAnalyzer();
        }
        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new PreventMD5UseAnalyzerCodeFix();
        }

        // A test for correct test
        [Fact]
        public void CR1000_PreventMD5UseAnalyzer_Correct_Test()
        {
            string data = @"
using System.Security.Cryptography;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void test3(object m)
        {
        }
    }
}";
            var expected = new DiagnosticResult[0];
            VerifyCSharpDiagnostic(data, expected);
        }

        /// A test for all of the senarios including 
        /// Field, Property, InsideMethod, 
        /// Declare Method, PassIn Parameter to Method, Lambda Expression, Delegate
        [Theory]
        [MemberData(nameof(PreventMD5UseAnalyzerData.TestInsideMethodData), MemberType = typeof(PreventMD5UseAnalyzerData))]
        public void CR1000_PreventMD5UseAnalyzer_Multiple_Tests(string data, string typeData, string belongsToData, int row, int column, string codeFixData)
        {
            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventMD5UseRuleId,
                Message = string.Format(PreventMD5UseAnalyzer.MessageFormat, typeData, belongsToData),
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
