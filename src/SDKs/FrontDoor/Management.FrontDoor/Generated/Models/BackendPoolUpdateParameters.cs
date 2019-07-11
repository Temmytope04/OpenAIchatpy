// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A collection of backends that can be routed to.
    /// </summary>
    public partial class BackendPoolUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BackendPoolUpdateParameters
        /// class.
        /// </summary>
        public BackendPoolUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendPoolUpdateParameters
        /// class.
        /// </summary>
        /// <param name="backends">The set of backends for this pool</param>
        /// <param name="loadBalancingSettings">Load balancing settings for a
        /// backend pool</param>
        /// <param name="healthProbeSettings">L7 health probe settings for a
        /// backend pool</param>
        public BackendPoolUpdateParameters(IList<Backend> backends = default(IList<Backend>), SubResource loadBalancingSettings = default(SubResource), SubResource healthProbeSettings = default(SubResource))
        {
            Backends = backends;
            LoadBalancingSettings = loadBalancingSettings;
            HealthProbeSettings = healthProbeSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of backends for this pool
        /// </summary>
        [JsonProperty(PropertyName = "backends")]
        public IList<Backend> Backends { get; set; }

        /// <summary>
        /// Gets or sets load balancing settings for a backend pool
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancingSettings")]
        public SubResource LoadBalancingSettings { get; set; }

        /// <summary>
        /// Gets or sets L7 health probe settings for a backend pool
        /// </summary>
        [JsonProperty(PropertyName = "healthProbeSettings")]
        public SubResource HealthProbeSettings { get; set; }

    }
}
