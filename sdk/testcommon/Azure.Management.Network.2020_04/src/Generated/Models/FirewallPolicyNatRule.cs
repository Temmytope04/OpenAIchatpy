// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Firewall Policy NAT Rule. </summary>
    public partial class FirewallPolicyNatRule : FirewallPolicyRule
    {
        /// <summary> Initializes a new instance of FirewallPolicyNatRule. </summary>
        public FirewallPolicyNatRule()
        {
            RuleType = FirewallPolicyRuleType.FirewallPolicyNatRule;
        }

        /// <summary> Initializes a new instance of FirewallPolicyNatRule. </summary>
        /// <param name="ruleType"> The type of the rule. </param>
        /// <param name="name"> The name of the rule. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule resource. </param>
        /// <param name="action"> The action type of a Nat rule. </param>
        /// <param name="translatedAddress"> The translated address for this NAT rule. </param>
        /// <param name="translatedPort"> The translated port for this NAT rule. </param>
        /// <param name="ruleCondition"> The match conditions for incoming traffic. </param>
        internal FirewallPolicyNatRule(FirewallPolicyRuleType ruleType, string name, int? priority, FirewallPolicyNatRuleAction action, string translatedAddress, string translatedPort, FirewallPolicyRuleCondition ruleCondition) : base(ruleType, name, priority)
        {
            Action = action;
            TranslatedAddress = translatedAddress;
            TranslatedPort = translatedPort;
            RuleCondition = ruleCondition;
            RuleType = ruleType;
        }

        /// <summary> The action type of a Nat rule. </summary>
        public FirewallPolicyNatRuleAction Action { get; set; }
        /// <summary> The translated address for this NAT rule. </summary>
        public string TranslatedAddress { get; set; }
        /// <summary> The translated port for this NAT rule. </summary>
        public string TranslatedPort { get; set; }
        /// <summary> The match conditions for incoming traffic. </summary>
        public FirewallPolicyRuleCondition RuleCondition { get; set; }
    }
}
