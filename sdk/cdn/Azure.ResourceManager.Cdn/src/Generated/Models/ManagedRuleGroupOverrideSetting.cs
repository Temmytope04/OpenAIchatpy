// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleGroupOverrideSetting
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupOverrideSetting"/>. </summary>
        /// <param name="ruleGroupName"> Describes the managed rule group within the rule set to override. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleGroupName"/> is null. </exception>
        public ManagedRuleGroupOverrideSetting(string ruleGroupName)
        {
            Argument.AssertNotNull(ruleGroupName, nameof(ruleGroupName));

            RuleGroupName = ruleGroupName;
            Rules = new ChangeTrackingList<ManagedRuleOverrideSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupOverrideSetting"/>. </summary>
        /// <param name="ruleGroupName"> Describes the managed rule group within the rule set to override. </param>
        /// <param name="rules"> List of rules that will be disabled. If none specified, all rules in the group will be disabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleGroupOverrideSetting(string ruleGroupName, IList<ManagedRuleOverrideSetting> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupOverrideSetting"/> for deserialization. </summary>
        internal ManagedRuleGroupOverrideSetting()
        {
        }

        /// <summary> Describes the managed rule group within the rule set to override. </summary>
        public string RuleGroupName { get; set; }
        /// <summary> List of rules that will be disabled. If none specified, all rules in the group will be disabled. </summary>
        public IList<ManagedRuleOverrideSetting> Rules { get; }
    }
}
