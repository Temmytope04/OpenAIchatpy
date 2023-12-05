// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListNetworkVirtualApplianceSkus API service call. </summary>
    internal partial class NetworkVirtualApplianceSkuListResult
    {
        /// <summary> Initializes a new instance of <see cref="NetworkVirtualApplianceSkuListResult"/>. </summary>
        internal NetworkVirtualApplianceSkuListResult()
        {
            Value = new ChangeTrackingList<NetworkVirtualApplianceSkuData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkVirtualApplianceSkuListResult"/>. </summary>
        /// <param name="value"> List of Network Virtual Appliance Skus that are available. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal NetworkVirtualApplianceSkuListResult(IReadOnlyList<NetworkVirtualApplianceSkuData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Network Virtual Appliance Skus that are available. </summary>
        public IReadOnlyList<NetworkVirtualApplianceSkuData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
