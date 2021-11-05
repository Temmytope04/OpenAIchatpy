// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list VpnSiteLinks. It contains a list of VpnSiteLinks and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVpnSiteLinksResult
    {
        /// <summary> Initializes a new instance of ListVpnSiteLinksResult. </summary>
        internal ListVpnSiteLinksResult()
        {
            Value = new ChangeTrackingList<VpnSiteLink>();
        }

        /// <summary> Initializes a new instance of ListVpnSiteLinksResult. </summary>
        /// <param name="value"> List of VpnSitesLinks. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVpnSiteLinksResult(IReadOnlyList<VpnSiteLink> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VpnSitesLinks. </summary>
        public IReadOnlyList<VpnSiteLink> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
