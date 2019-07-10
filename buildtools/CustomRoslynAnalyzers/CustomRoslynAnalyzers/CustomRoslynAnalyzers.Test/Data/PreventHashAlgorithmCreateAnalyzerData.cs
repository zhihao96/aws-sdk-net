using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test.Data
{
    class PreventHashAlgorithmCreateAnalyzerData
    {
        private const string BasicCorrectData = @"
using System;
using System.Security.Cryptography;

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
using System.Security.Cryptography;

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
using System.Security.Cryptography;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public HashAlgorithm test = {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicPropertyData = @"
using System;
using System.Security.Cryptography;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public HashAlgorithm test4
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
        private const string BasicParameterData = @"
using System;
using System.Security.Cryptography;

namespace TestPreventHashAlgorithmCreateAnalyzer
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            TestMethod({0});
        }}

        public static void TestMethod(HashAlgorithm h)
        {{
        }}
    }}
}}";

        public static IEnumerable<object[]> TestCorrectData => new List<string[]> { new string[] { BasicCorrectData } };
        private static List<string[]> MethodData => CreateSeperateData(BasicMethodData);
        private static List<string[]> FieldData => CreateSeperateData(BasicFieldData);
        private static List<string[]> PropertyData => CreateSeperateData(BasicPropertyData);
        private static List<string[]> ParameterData => CreateSeperateData(BasicParameterData);

        public static IEnumerable<object[]> TestMethodData => MethodData;
        public static IEnumerable<object[]> TestFieldData => FieldData;
        public static IEnumerable<object[]> TestPropertyData => PropertyData;
        public static IEnumerable<object[]> TestParameterData => ParameterData;

        private static List<string[]> CreateSeperateData(string basicData)
        {
            return new List<string[]>
            {
                new string[] { basicData, "HashAlgorithm.Create()"},
                new string[] { basicData, "HashAlgorithm.Create(\"test\")"},
            };
        }
    }
}
