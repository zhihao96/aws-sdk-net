using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using TestHelper;
using Xunit;

namespace CustomRoslynAnalyzers.Test
{
    public class PreventStaticLoggersAnalyzerTests : DiagnosticVerifier
    {
        private const string DiagnosticMessage = "Static member {0} of type {1} implements {2}. Instances of {2} should not be stored in static variables. Logger configuration can change during SDK use, but static references are not impacted by this.";

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PreventStaticLoggersAnalyzer();
        }

        [Fact]
        public void CR1002_PreventStaticLoggersAnalyzer_Field_Test()
        {
            var test = @"
using System;

namespace TestPreventStaticLoggersAnalyzer
{
    public interface ILogger
    {
        void TestMethod();
    }
    public class Logger : ILogger
    {
        public void TestMethod()
        {
        }
    }
    class Program
    {
        public static Logger B;  
        static void Main(string[] args)
        {
        }
    }
}";
            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventStaticLoggersRuleId,
                Message = string.Format(DiagnosticMessage, "Program", "TestPreventStaticLoggersAnalyzer.Logger", "ILogger"),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 18, 9)
                    }
            };
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void CR1002_PreventStaticLoggersAnalyzer_Property_Test()
        {
            var test = @"
using System;

namespace TestPreventStaticLoggersAnalyzer
{
    public interface ILogger
    {
        void TestMethod();
    }
    public class Logger : ILogger
    {
        public void TestMethod()
        {
        }
    }
    class Program
    {
        public static Logger A { set; get; }
        static void Main(string[] args)
        {
        }
    }
}";
            var expected = new DiagnosticResult
            {
                Id = DiagnosticIds.PreventStaticLoggersRuleId,
                Message = string.Format(DiagnosticMessage, "Program", "TestPreventStaticLoggersAnalyzer.Logger", "ILogger"),
                Severity = DiagnosticSeverity.Error,
                Locations =
                    new[]
                    {
                        new DiagnosticResultLocation("Test0.cs", 18, 9)
                    }
            };
            VerifyCSharpDiagnostic(test, expected);
        }
    }
}
