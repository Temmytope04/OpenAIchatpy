// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListNetworkVirtualApplianceSites API service call. </summary>
    internal partial class NetworkVirtualApplianceSiteListResult
    {
        /// <summary> Initializes a new instance of NetworkVirtualApplianceSiteListResult. </summary>
        internal NetworkVirtualApplianceSiteListResult()
        {
            Value = new ChangeTrackingList<VirtualApplianceSiteData>();
        }

        /// <summary> Initializes a new instance of NetworkVirtualApplianceSiteListResult. </summary>
        /// <param name="value"> List of Network Virtual Appliance sites. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal NetworkVirtualApplianceSiteListResult(IReadOnlyList<VirtualApplianceSiteData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Network Virtual Appliance sites. </summary>
        public IReadOnlyList<VirtualApplianceSiteData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
