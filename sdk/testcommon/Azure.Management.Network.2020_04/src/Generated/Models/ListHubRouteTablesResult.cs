// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> List of RouteTables and a URL nextLink to get the next set of results. </summary>
    public partial class ListHubRouteTablesResult
    {
        /// <summary> Initializes a new instance of ListHubRouteTablesResult. </summary>
        internal ListHubRouteTablesResult()
        {
            Value = new ChangeTrackingList<HubRouteTable>();
        }

        /// <summary> Initializes a new instance of ListHubRouteTablesResult. </summary>
        /// <param name="value"> List of RouteTables. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListHubRouteTablesResult(IReadOnlyList<HubRouteTable> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of RouteTables. </summary>
        public IReadOnlyList<HubRouteTable> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
