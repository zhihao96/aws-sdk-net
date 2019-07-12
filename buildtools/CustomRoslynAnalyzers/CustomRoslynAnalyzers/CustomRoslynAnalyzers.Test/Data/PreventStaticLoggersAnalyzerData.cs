using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test.Data
{
    class PreventStaticLoggersAnalyzerData
    {
        private const string BasicDataForImplementILogger = @"
    public class Logger : ILogger
    {
        public void Debug(Exception exception, string messageFormat, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string messageFormat, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, string messageFormat, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string messageFormat, params object[] args)
        {
            throw new NotImplementedException();
        }
    }";

        private const string BasicFieldDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    {0}
    class Program
    {{
        public static Logger B;  
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicPropertyDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    {0}
    class Program
    {{
        public static Logger A {{ set; get; }}
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        private const string FieldCodeFixDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    {0}
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1002"")]
        public static Logger B;  
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string PropertyCodeFixDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    {0}
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1002"")]
        public static Logger A {{ set; get; }}
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        public static IEnumerable<object[]> AllTestData => CreateSeperateData();

        private static List<object[]> CreateSeperateData()
        {
            return new List<object[]>
            {
                // Data for the field test
                new object[] { BasicFieldDataWithoutLogger, "Program", "TestPreventStaticLoggersAnalyzer.Logger", "ILogger", 38, 9, FieldCodeFixDataWithoutLogger, BasicDataForImplementILogger},
                // Data for the property test
                new object[] { BasicPropertyDataWithoutLogger, "Program", "TestPreventStaticLoggersAnalyzer.Logger", "ILogger", 38, 9, PropertyCodeFixDataWithoutLogger, BasicDataForImplementILogger},
            };
        }
    }
}
