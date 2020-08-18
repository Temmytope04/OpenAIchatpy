// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ListAzureFirewalls API service call. </summary>
    public partial class AzureFirewallListResult
    {
        /// <summary> Initializes a new instance of AzureFirewallListResult. </summary>
        internal AzureFirewallListResult()
        {
            Value = new ChangeTrackingList<AzureFirewall>();
        }

        /// <summary> Initializes a new instance of AzureFirewallListResult. </summary>
        /// <param name="value"> List of Azure Firewalls in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal AzureFirewallListResult(IReadOnlyList<AzureFirewall> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Azure Firewalls in a resource group. </summary>
        public IReadOnlyList<AzureFirewall> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
