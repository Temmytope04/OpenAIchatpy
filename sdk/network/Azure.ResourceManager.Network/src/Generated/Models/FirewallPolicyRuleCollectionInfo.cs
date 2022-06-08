// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary>
    /// Properties of the rule collection.
    /// Please note <see cref="FirewallPolicyRuleCollectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FirewallPolicyFilterRuleCollectionInfo"/> and <see cref="FirewallPolicyNatRuleCollectionInfo"/>.
    /// </summary>
    public partial class FirewallPolicyRuleCollectionInfo
    {
        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionInfo. </summary>
        public FirewallPolicyRuleCollectionInfo()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionInfo. </summary>
        /// <param name="ruleCollectionType"> The type of the rule collection. </param>
        /// <param name="name"> The name of the rule collection. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection resource. </param>
        internal FirewallPolicyRuleCollectionInfo(FirewallPolicyRuleCollectionType ruleCollectionType, string name, int? priority)
        {
            RuleCollectionType = ruleCollectionType;
            Name = name;
            Priority = priority;
        }

        /// <summary> The type of the rule collection. </summary>
        internal FirewallPolicyRuleCollectionType RuleCollectionType { get; set; }
        /// <summary> The name of the rule collection. </summary>
        public string Name { get; set; }
        /// <summary> Priority of the Firewall Policy Rule Collection resource. </summary>
        public int? Priority { get; set; }
    }
}
