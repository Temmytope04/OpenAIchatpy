// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSNetworkStatus defines the observed state of HybridAKSNetwork. </summary>
    internal partial class VirtualNetworksPropertiesStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesStatus"/>. </summary>
        internal VirtualNetworksPropertiesStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesStatus"/>. </summary>
        /// <param name="provisioningStatus"> Contains Provisioning errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworksPropertiesStatus(VirtualNetworksPropertiesStatusProvisioningStatus provisioningStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningStatus = provisioningStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Contains Provisioning errors. </summary>
        public VirtualNetworksPropertiesStatusProvisioningStatus ProvisioningStatus { get; }
    }
}
