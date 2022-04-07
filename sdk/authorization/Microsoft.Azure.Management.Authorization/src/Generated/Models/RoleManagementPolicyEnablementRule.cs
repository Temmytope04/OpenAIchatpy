// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The role management policy enablement rule.
    /// </summary>
    public partial class RoleManagementPolicyEnablementRule : RoleManagementPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RoleManagementPolicyEnablementRule class.
        /// </summary>
        public RoleManagementPolicyEnablementRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RoleManagementPolicyEnablementRule class.
        /// </summary>
        /// <param name="id">The id of the rule.</param>
        /// <param name="target">The target of the current rule.</param>
        /// <param name="enabledRules">The list of enabled rules.</param>
        public RoleManagementPolicyEnablementRule(string id = default(string), RoleManagementPolicyRuleTarget target = default(RoleManagementPolicyRuleTarget), IList<string> enabledRules = default(IList<string>))
            : base(id, target)
        {
            EnabledRules = enabledRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of enabled rules.
        /// </summary>
        [JsonProperty(PropertyName = "enabledRules")]
        public IList<string> EnabledRules { get; set; }

    }
}
