// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Infra network profile for the NetworkCloud platform. </summary>
    internal partial class VirtualNetworksPropertiesInfraVnetProfileNetworkCloud
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesInfraVnetProfileNetworkCloud"/>. </summary>
        public VirtualNetworksPropertiesInfraVnetProfileNetworkCloud()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesInfraVnetProfileNetworkCloud"/>. </summary>
        /// <param name="networkId"> The ARM ID of Network Cloud Network Resource to Associate with this VirtualNetwork. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworksPropertiesInfraVnetProfileNetworkCloud(string networkId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkId = networkId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ARM ID of Network Cloud Network Resource to Associate with this VirtualNetwork. </summary>
        public string NetworkId { get; set; }
    }
}
