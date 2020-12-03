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
    /// Application gateway web application firewall configuration.
    /// </summary>
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayWebApplicationFirewallConfiguration class.
        /// </summary>
        public ApplicationGatewayWebApplicationFirewallConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayWebApplicationFirewallConfiguration class.
        /// </summary>
        /// <param name="enabled">Whether the web application firewall is
        /// enabled or not.</param>
        /// <param name="firewallMode">Web application firewall mode. Possible
        /// values include: 'Detection', 'Prevention'</param>
        /// <param name="ruleSetType">The type of the web application firewall
        /// rule set. Possible values are: 'OWASP'.</param>
        /// <param name="ruleSetVersion">The version of the rule set
        /// type.</param>
        /// <param name="disabledRuleGroups">The disabled rule groups.</param>
        /// <param name="requestBodyCheck">Whether allow WAF to check request
        /// Body.</param>
        /// <param name="maxRequestBodySize">Maximum request body size for
        /// WAF.</param>
        /// <param name="maxRequestBodySizeInKb">Maximum request body size in
        /// Kb for WAF.</param>
        /// <param name="fileUploadLimitInMb">Maximum file upload size in Mb
        /// for WAF.</param>
        /// <param name="exclusions">The exclusion list.</param>
        public ApplicationGatewayWebApplicationFirewallConfiguration(bool enabled, string firewallMode, string ruleSetType, string ruleSetVersion, IList<ApplicationGatewayFirewallDisabledRuleGroup> disabledRuleGroups = default(IList<ApplicationGatewayFirewallDisabledRuleGroup>), bool? requestBodyCheck = default(bool?), int? maxRequestBodySize = default(int?), int? maxRequestBodySizeInKb = default(int?), int? fileUploadLimitInMb = default(int?), IList<ApplicationGatewayFirewallExclusion> exclusions = default(IList<ApplicationGatewayFirewallExclusion>))
        {
            Enabled = enabled;
            FirewallMode = firewallMode;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            DisabledRuleGroups = disabledRuleGroups;
            RequestBodyCheck = requestBodyCheck;
            MaxRequestBodySize = maxRequestBodySize;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadLimitInMb = fileUploadLimitInMb;
            Exclusions = exclusions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the web application firewall is enabled or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets web application firewall mode. Possible values
        /// include: 'Detection', 'Prevention'
        /// </summary>
        [JsonProperty(PropertyName = "firewallMode")]
        public string FirewallMode { get; set; }

        /// <summary>
        /// Gets or sets the type of the web application firewall rule set.
        /// Possible values are: 'OWASP'.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSetType")]
        public string RuleSetType { get; set; }

        /// <summary>
        /// Gets or sets the version of the rule set type.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSetVersion")]
        public string RuleSetVersion { get; set; }

        /// <summary>
        /// Gets or sets the disabled rule groups.
        /// </summary>
        [JsonProperty(PropertyName = "disabledRuleGroups")]
        public IList<ApplicationGatewayFirewallDisabledRuleGroup> DisabledRuleGroups { get; set; }

        /// <summary>
        /// Gets or sets whether allow WAF to check request Body.
        /// </summary>
        [JsonProperty(PropertyName = "requestBodyCheck")]
        public bool? RequestBodyCheck { get; set; }

        /// <summary>
        /// Gets or sets maximum request body size for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "maxRequestBodySize")]
        public int? MaxRequestBodySize { get; set; }

        /// <summary>
        /// Gets or sets maximum request body size in Kb for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "maxRequestBodySizeInKb")]
        public int? MaxRequestBodySizeInKb { get; set; }

        /// <summary>
        /// Gets or sets maximum file upload size in Mb for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "fileUploadLimitInMb")]
        public int? FileUploadLimitInMb { get; set; }

        /// <summary>
        /// Gets or sets the exclusion list.
        /// </summary>
        [JsonProperty(PropertyName = "exclusions")]
        public IList<ApplicationGatewayFirewallExclusion> Exclusions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FirewallMode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FirewallMode");
            }
            if (RuleSetType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetType");
            }
            if (RuleSetVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetVersion");
            }
            if (DisabledRuleGroups != null)
            {
                foreach (var element in DisabledRuleGroups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (MaxRequestBodySize != null)
            {
                if (MaxRequestBodySize > 128)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxRequestBodySize", 128);
                }
                if (MaxRequestBodySize < 8)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxRequestBodySize", 8);
                }
            }
            if (MaxRequestBodySizeInKb != null)
            {
                if (MaxRequestBodySizeInKb > 128)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxRequestBodySizeInKb", 128);
                }
                if (MaxRequestBodySizeInKb < 8)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxRequestBodySizeInKb", 8);
                }
            }
            if (FileUploadLimitInMb != null)
            {
                if (FileUploadLimitInMb < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "FileUploadLimitInMb", 0);
                }
            }
            if (Exclusions != null)
            {
                foreach (var element1 in Exclusions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
