// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the ListPrivateLinkService API service call. </summary>
    public partial class PrivateLinkServiceListResult
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceListResult. </summary>
        internal PrivateLinkServiceListResult()
        {
            Value = new ChangeTrackingList<PrivateLinkService>();
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceListResult. </summary>
        /// <param name="value"> A list of PrivateLinkService resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PrivateLinkServiceListResult(IReadOnlyList<PrivateLinkService> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of PrivateLinkService resources in a resource group. </summary>
        public IReadOnlyList<PrivateLinkService> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
