// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Firewall Policy NAT Rule Collection. </summary>
    public partial class FirewallPolicyNatRuleCollectionInfo : FirewallPolicyRuleCollectionInfo
    {
        /// <summary> Initializes a new instance of <see cref="FirewallPolicyNatRuleCollectionInfo"/>. </summary>
        public FirewallPolicyNatRuleCollectionInfo()
        {
            Rules = new ChangeTrackingList<FirewallPolicyRule>();
            RuleCollectionType = FirewallPolicyRuleCollectionType.FirewallPolicyNatRuleCollection;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyNatRuleCollectionInfo"/>. </summary>
        /// <param name="ruleCollectionType"> The type of the rule collection. </param>
        /// <param name="name"> The name of the rule collection. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="action"> The action type of a Nat rule collection. </param>
        /// <param name="rules">
        /// List of rules included in a rule collection.
        /// Please note <see cref="FirewallPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ApplicationRule"/>, <see cref="NatRule"/> and <see cref="NetworkRule"/>.
        /// </param>
        internal FirewallPolicyNatRuleCollectionInfo(FirewallPolicyRuleCollectionType ruleCollectionType, string name, int? priority, IDictionary<string, BinaryData> serializedAdditionalRawData, FirewallPolicyNatRuleCollectionAction action, IList<FirewallPolicyRule> rules) : base(ruleCollectionType, name, priority, serializedAdditionalRawData)
        {
            Action = action;
            Rules = rules;
            RuleCollectionType = ruleCollectionType;
        }

        /// <summary> The action type of a Nat rule collection. </summary>
        internal FirewallPolicyNatRuleCollectionAction Action { get; set; }
        /// <summary> The type of action. </summary>
        public FirewallPolicyNatRuleCollectionActionType? ActionType
        {
            get => Action is null ? default : Action.ActionType;
            set
            {
                if (Action is null)
                    Action = new FirewallPolicyNatRuleCollectionAction();
                Action.ActionType = value;
            }
        }

        /// <summary>
        /// List of rules included in a rule collection.
        /// Please note <see cref="FirewallPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ApplicationRule"/>, <see cref="NatRule"/> and <see cref="NetworkRule"/>.
        /// </summary>
        public IList<FirewallPolicyRule> Rules { get; }
    }
}
