// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rule condition of type application. </summary>
    public partial class ApplicationRuleCondition : FirewallPolicyRuleCondition
    {
        /// <summary> Initializes a new instance of ApplicationRuleCondition. </summary>
        public ApplicationRuleCondition()
        {
            SourceAddresses = new ChangeTrackingList<string>();
            DestinationAddresses = new ChangeTrackingList<string>();
            Protocols = new ChangeTrackingList<FirewallPolicyRuleConditionApplicationProtocol>();
            TargetUrls = new ChangeTrackingList<string>();
            TargetFqdns = new ChangeTrackingList<string>();
            FqdnTags = new ChangeTrackingList<string>();
            SourceIpGroups = new ChangeTrackingList<string>();
            RuleConditionType = FirewallPolicyRuleConditionType.ApplicationRuleCondition;
        }

        /// <summary> Initializes a new instance of ApplicationRuleCondition. </summary>
        /// <param name="name"> Name of the rule condition. </param>
        /// <param name="description"> Description of the rule condition. </param>
        /// <param name="ruleConditionType"> Rule Condition Type. </param>
        /// <param name="sourceAddresses"> List of source IP addresses for this rule. </param>
        /// <param name="destinationAddresses"> List of destination IP addresses or Service Tags. </param>
        /// <param name="protocols"> Array of Application Protocols. </param>
        /// <param name="targetUrls"> List of Urls for this rule condition. </param>
        /// <param name="targetFqdns"> List of FQDNs for this rule condition. </param>
        /// <param name="fqdnTags"> List of FQDN Tags for this rule condition. </param>
        /// <param name="sourceIpGroups"> List of source IpGroups for this rule. </param>
        internal ApplicationRuleCondition(string name, string description, FirewallPolicyRuleConditionType ruleConditionType, IList<string> sourceAddresses, IList<string> destinationAddresses, IList<FirewallPolicyRuleConditionApplicationProtocol> protocols, IList<string> targetUrls, IList<string> targetFqdns, IList<string> fqdnTags, IList<string> sourceIpGroups) : base(name, description, ruleConditionType)
        {
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            Protocols = protocols;
            TargetUrls = targetUrls;
            TargetFqdns = targetFqdns;
            FqdnTags = fqdnTags;
            SourceIpGroups = sourceIpGroups;
            RuleConditionType = ruleConditionType;
        }

        /// <summary> List of source IP addresses for this rule. </summary>
        public IList<string> SourceAddresses { get; }
        /// <summary> List of destination IP addresses or Service Tags. </summary>
        public IList<string> DestinationAddresses { get; }
        /// <summary> Array of Application Protocols. </summary>
        public IList<FirewallPolicyRuleConditionApplicationProtocol> Protocols { get; }
        /// <summary> List of Urls for this rule condition. </summary>
        public IList<string> TargetUrls { get; }
        /// <summary> List of FQDNs for this rule condition. </summary>
        public IList<string> TargetFqdns { get; }
        /// <summary> List of FQDN Tags for this rule condition. </summary>
        public IList<string> FqdnTags { get; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIpGroups { get; }
    }
}
