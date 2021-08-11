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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure-SSIS integration runtime outbound network dependency endpoints.
    /// </summary>
    public partial class IntegrationRuntimeOutboundNetworkDependenciesEndpointsResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeOutboundNetworkDependenciesEndpointsResponse
        /// class.
        /// </summary>
        public IntegrationRuntimeOutboundNetworkDependenciesEndpointsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeOutboundNetworkDependenciesEndpointsResponse
        /// class.
        /// </summary>
        /// <param name="value">The list of outbound network dependency
        /// endpoints.</param>
        public IntegrationRuntimeOutboundNetworkDependenciesEndpointsResponse(IList<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> value = default(IList<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of outbound network dependency endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> Value { get; set; }

    }
}
