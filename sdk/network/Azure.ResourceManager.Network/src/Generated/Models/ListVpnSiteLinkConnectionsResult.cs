// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list all vpn connections to a virtual wan vpn gateway. It contains a list of Vpn Connections and a URL nextLink to get the next set of results. </summary>
    public partial class ListVpnSiteLinkConnectionsResult
    {
        /// <summary> Initializes a new instance of ListVpnSiteLinkConnectionsResult. </summary>
        internal ListVpnSiteLinkConnectionsResult()
        {
        }

        /// <summary> Initializes a new instance of ListVpnSiteLinkConnectionsResult. </summary>
        /// <param name="value"> List of VpnSiteLinkConnections. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVpnSiteLinkConnectionsResult(IReadOnlyList<VpnSiteLinkConnection> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VpnSiteLinkConnections. </summary>
        public IReadOnlyList<VpnSiteLinkConnection> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
