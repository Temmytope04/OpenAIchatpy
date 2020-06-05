// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListVirtualNetworks API service call. </summary>
    public partial class VirtualNetworkListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkListResult. </summary>
        internal VirtualNetworkListResult()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkListResult. </summary>
        /// <param name="value"> A list of VirtualNetwork resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal VirtualNetworkListResult(IReadOnlyList<VirtualNetwork> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of VirtualNetwork resources in a resource group. </summary>
        public IReadOnlyList<VirtualNetwork> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
