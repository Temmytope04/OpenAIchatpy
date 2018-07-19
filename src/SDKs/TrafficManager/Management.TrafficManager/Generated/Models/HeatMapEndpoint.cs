// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class which is a sparse representation of a Traffic Manager endpoint.
    /// </summary>
    public partial class HeatMapEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the HeatMapEndpoint class.
        /// </summary>
        public HeatMapEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HeatMapEndpoint class.
        /// </summary>
        /// <param name="resourceId">The ARM Resource ID of this Traffic
        /// Manager endpoint.</param>
        /// <param name="endpointId">A number uniquely identifying this
        /// endpoint in query experiences.</param>
        public HeatMapEndpoint(string resourceId = default(string), int? endpointId = default(int?))
        {
            ResourceId = resourceId;
            EndpointId = endpointId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM Resource ID of this Traffic Manager endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets a number uniquely identifying this endpoint in query
        /// experiences.
        /// </summary>
        [JsonProperty(PropertyName = "endpointId")]
        public int? EndpointId { get; set; }

    }
}
