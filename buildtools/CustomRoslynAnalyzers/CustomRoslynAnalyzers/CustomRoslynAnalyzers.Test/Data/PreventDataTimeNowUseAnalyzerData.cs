using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test.Data
{
    public class PreventDataTimeNowUseAnalyzerData
    {
        private const string BasicCorrectData = @"
using System;

namespace TestPreventTimeNowUseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = 1;
        }
    }
}";
        private const string BasicMethodData = @"
using System;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            var test = {0};
        }}
    }}
}}";
        private const string BasicFieldData = @"
using System;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public DateTime test = {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicParameterData = @"
using System;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            TestMethod({0});
        }}

        public static void TestMethod(DateTime d)
        {{

        }}
    }}
}}";
        private const string BasicPropertyData = @"
using System;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public DateTime test3
        {{
            get
            {{
                return {0};
            }}
        }}
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        private static List<string[]> MethodData => CreateSeperateData(BasicMethodData);
        private static List<string[]> FieldData = CreateSeperateData(BasicFieldData);
        private static List<string[]> ParameterData = CreateSeperateData(BasicParameterData);
        private static List<string[]> PropertyData = CreateSeperateData(BasicPropertyData);

        public static IEnumerable<object[]> TestCorrectData => new List<string[]> { new string[] { BasicCorrectData } };
        public static IEnumerable<object[]> TestMethodData => MethodData;
        public static IEnumerable<object[]> TestFieldData => FieldData;
        public static IEnumerable<object[]> TestParameterData => ParameterData;
        public static IEnumerable<object[]> TestPropertyData => PropertyData;

        private static List<string[]> CreateSeperateData(string basicData)
        {
            return new List<string[]>
            {
                new string[] { basicData, "DateTime.Now"},
                new string[] { basicData, "DateTime.Today"},
                new string[] { basicData, "DateTime.UtcNow"},
            };
        }
    }
}
