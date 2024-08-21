// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Describes an automation rule condition that evaluates an array property's value change
    /// Serialized Name: PropertyArrayChangedConditionProperties
    /// </summary>
    public partial class SecurityInsightsPropertyArrayChangedConditionProperties : SecurityInsightsAutomationRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsPropertyArrayChangedConditionProperties"/>. </summary>
        public SecurityInsightsPropertyArrayChangedConditionProperties()
        {
            ConditionType = ConditionType.PropertyArrayChanged;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsPropertyArrayChangedConditionProperties"/>. </summary>
        /// <param name="conditionType"> Serialized Name: AutomationRuleCondition.conditionType. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="conditionProperties"> Serialized Name: PropertyArrayChangedConditionProperties.conditionProperties. </param>
        internal SecurityInsightsPropertyArrayChangedConditionProperties(ConditionType conditionType, IDictionary<string, BinaryData> serializedAdditionalRawData, AutomationRulePropertyArrayChangedValuesCondition conditionProperties) : base(conditionType, serializedAdditionalRawData)
        {
            ConditionProperties = conditionProperties;
            ConditionType = conditionType;
        }

        /// <summary> Serialized Name: PropertyArrayChangedConditionProperties.conditionProperties. </summary>
        public AutomationRulePropertyArrayChangedValuesCondition ConditionProperties { get; set; }
    }
}
