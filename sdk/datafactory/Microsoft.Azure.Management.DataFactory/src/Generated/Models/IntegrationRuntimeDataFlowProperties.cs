// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data flow properties for managed integration runtime.
    /// </summary>
    public partial class IntegrationRuntimeDataFlowProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeDataFlowProperties class.
        /// </summary>
        public IntegrationRuntimeDataFlowProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeDataFlowProperties class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="computeType">Compute type of the cluster which will
        /// execute data flow job. Possible values include: 'General',
        /// 'MemoryOptimized', 'ComputeOptimized'</param>
        /// <param name="coreCount">Core count of the cluster which will
        /// execute data flow job. Supported values are: 8, 16, 32, 48, 80, 144
        /// and 272.</param>
        /// <param name="timeToLive">Time to live (in minutes) setting of the
        /// cluster which will execute data flow job.</param>
        /// <param name="cleanup">Cluster will not be recycled and it will be
        /// used in next data flow activity run until TTL (time to live) is
        /// reached if this is set as false. Default is true.</param>
        /// <param name="customProperties">Custom properties are used to tune
        /// the data flow runtime performance.</param>
        public IntegrationRuntimeDataFlowProperties(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string computeType = default(string), int? coreCount = default(int?), int? timeToLive = default(int?), bool? cleanup = default(bool?), IList<IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem> customProperties = default(IList<IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem>))
        {
            AdditionalProperties = additionalProperties;
            ComputeType = computeType;
            CoreCount = coreCount;
            TimeToLive = timeToLive;
            Cleanup = cleanup;
            CustomProperties = customProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets compute type of the cluster which will execute data
        /// flow job. Possible values include: 'General', 'MemoryOptimized',
        /// 'ComputeOptimized'
        /// </summary>
        [JsonProperty(PropertyName = "computeType")]
        public string ComputeType { get; set; }

        /// <summary>
        /// Gets or sets core count of the cluster which will execute data flow
        /// job. Supported values are: 8, 16, 32, 48, 80, 144 and 272.
        /// </summary>
        [JsonProperty(PropertyName = "coreCount")]
        public int? CoreCount { get; set; }

        /// <summary>
        /// Gets or sets time to live (in minutes) setting of the cluster which
        /// will execute data flow job.
        /// </summary>
        [JsonProperty(PropertyName = "timeToLive")]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Gets or sets cluster will not be recycled and it will be used in
        /// next data flow activity run until TTL (time to live) is reached if
        /// this is set as false. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "cleanup")]
        public bool? Cleanup { get; set; }

        /// <summary>
        /// Gets or sets custom properties are used to tune the data flow
        /// runtime performance.
        /// </summary>
        [JsonProperty(PropertyName = "customProperties")]
        public IList<IntegrationRuntimeDataFlowPropertiesCustomPropertiesItem> CustomProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeToLive < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TimeToLive", 0);
            }
        }
    }
}
