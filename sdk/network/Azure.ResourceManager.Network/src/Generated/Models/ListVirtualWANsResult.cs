// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list VirtualWANs. It contains a list of VirtualWANs and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVirtualWANsResult
    {
        /// <summary> Initializes a new instance of ListVirtualWANsResult. </summary>
        internal ListVirtualWANsResult()
        {
            Value = new ChangeTrackingList<VirtualWANData>();
        }

        /// <summary> Initializes a new instance of ListVirtualWANsResult. </summary>
        /// <param name="value"> List of VirtualWANs. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVirtualWANsResult(IReadOnlyList<VirtualWANData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VirtualWANs. </summary>
        public IReadOnlyList<VirtualWANData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
