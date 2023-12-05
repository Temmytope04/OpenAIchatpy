// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of HubVirtualNetworkConnections and a URL nextLink to get the next set of results. </summary>
    internal partial class ListHubVirtualNetworkConnectionsResult
    {
        /// <summary> Initializes a new instance of <see cref="ListHubVirtualNetworkConnectionsResult"/>. </summary>
        internal ListHubVirtualNetworkConnectionsResult()
        {
            Value = new ChangeTrackingList<HubVirtualNetworkConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListHubVirtualNetworkConnectionsResult"/>. </summary>
        /// <param name="value"> List of HubVirtualNetworkConnections. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListHubVirtualNetworkConnectionsResult(IReadOnlyList<HubVirtualNetworkConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of HubVirtualNetworkConnections. </summary>
        public IReadOnlyList<HubVirtualNetworkConnectionData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
