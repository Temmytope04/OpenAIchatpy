// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Defines a managed rule set. </summary>
    public partial class ManagedRuleSet
    {
        /// <summary> Initializes a new instance of ManagedRuleSet. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        public ManagedRuleSet(string ruleSetType, string ruleSetVersion)
        {
            if (ruleSetType == null)
            {
                throw new ArgumentNullException(nameof(ruleSetType));
            }
            if (ruleSetVersion == null)
            {
                throw new ArgumentNullException(nameof(ruleSetVersion));
            }

            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroupOverrides = new ChangeTrackingList<ManagedRuleGroupOverride>();
        }

        /// <summary> Initializes a new instance of ManagedRuleSet. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <param name="ruleGroupOverrides"> Defines the rule group overrides to apply to the rule set. </param>
        internal ManagedRuleSet(string ruleSetType, string ruleSetVersion, IList<ManagedRuleGroupOverride> ruleGroupOverrides)
        {
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroupOverrides = ruleGroupOverrides;
        }

        /// <summary> Defines the rule set type to use. </summary>
        public string RuleSetType { get; set; }
        /// <summary> Defines the version of the rule set to use. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> Defines the rule group overrides to apply to the rule set. </summary>
        public IList<ManagedRuleGroupOverride> RuleGroupOverrides { get; }
    }
}
