// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a managed rule group override setting.
    /// </summary>
    public partial class ManagedRuleGroupOverride
    {
        /// <summary>
        /// Initializes a new instance of the ManagedRuleGroupOverride class.
        /// </summary>
        public ManagedRuleGroupOverride()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedRuleGroupOverride class.
        /// </summary>
        /// <param name="ruleGroupName">Describes the managed rule group to
        /// override.</param>
        /// <param name="rules">List of rules that will be disabled. If none
        /// specified, all rules in the group will be disabled.</param>
        public ManagedRuleGroupOverride(string ruleGroupName, IList<ManagedRuleOverride> rules = default(IList<ManagedRuleOverride>))
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the managed rule group to override.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupName")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Gets or sets list of rules that will be disabled. If none
        /// specified, all rules in the group will be disabled.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ManagedRuleOverride> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleGroupName");
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
