// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The UnknownAutomationRuleCondition. </summary>
    internal partial class UnknownAutomationRuleCondition : AutomationRuleCondition
    {
        /// <summary> Initializes a new instance of UnknownAutomationRuleCondition. </summary>
        /// <param name="conditionType"></param>
        internal UnknownAutomationRuleCondition(ConditionType conditionType) : base(conditionType)
        {
            ConditionType = conditionType;
        }
    }
}
