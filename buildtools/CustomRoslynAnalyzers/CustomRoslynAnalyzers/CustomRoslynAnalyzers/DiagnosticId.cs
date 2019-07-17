using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers
{
    public static class DiagnosticIds
    {
        // Category: AwsSdkRules
        public const string PreventMD5UseRuleId = "CR1000:PreventMD5UseRule";
        public const string PreventHashAlgorithmCreateRuleId = "CR1001:PreventHashAlgorithmCreateRule";
        public const string PreventStaticLoggersRuleId = "CR1002:PreventStaticLoggersRule";
        public const string PreventDateTimeNowUseRuleId = "CR1003:PreventDateTimeNowUseRule";
        public const string PreventRegionEndpointUseRuleId = "CR1004:PreventRegionEndpointUseRule";
    }
}
