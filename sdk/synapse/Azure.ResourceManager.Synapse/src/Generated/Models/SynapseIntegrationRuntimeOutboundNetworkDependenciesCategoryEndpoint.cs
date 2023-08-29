// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Azure-SSIS integration runtime outbound network dependency endpoints for one category. </summary>
    public partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint"/>. </summary>
        internal SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint()
        {
            Endpoints = new ChangeTrackingList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint"/>. </summary>
        /// <param name="category"> The category of outbound network dependency. </param>
        /// <param name="endpoints"> The endpoints for outbound network dependency. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(string category, IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint> endpoints, Dictionary<string, BinaryData> rawData)
        {
            Category = category;
            Endpoints = endpoints;
            _rawData = rawData;
        }

        /// <summary> The category of outbound network dependency. </summary>
        public string Category { get; }
        /// <summary> The endpoints for outbound network dependency. </summary>
        public IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint> Endpoints { get; }
    }
}
