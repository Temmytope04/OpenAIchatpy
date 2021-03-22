// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Elastic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the properties for a TagRules resource.
    /// </summary>
    public partial class MonitoringTagRulesProperties
    {
        /// <summary>
        /// Initializes a new instance of the MonitoringTagRulesProperties
        /// class.
        /// </summary>
        public MonitoringTagRulesProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonitoringTagRulesProperties
        /// class.
        /// </summary>
        /// <param name="provisioningState">Provisioning state of the
        /// monitoring tag rules. Possible values include: 'Accepted',
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled', 'Deleted', 'NotSpecified'</param>
        /// <param name="logRules">Rules for sending logs.</param>
        public MonitoringTagRulesProperties(string provisioningState = default(string), LogRules logRules = default(LogRules))
        {
            ProvisioningState = provisioningState;
            LogRules = logRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provisioning state of the monitoring tag rules.
        /// Possible values include: 'Accepted', 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Canceled', 'Deleted',
        /// 'NotSpecified'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets rules for sending logs.
        /// </summary>
        [JsonProperty(PropertyName = "logRules")]
        public LogRules LogRules { get; set; }

    }
}
