// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the ListServiceCommunity API service call. </summary>
    public partial class BgpServiceCommunityListResult
    {
        /// <summary> Initializes a new instance of BgpServiceCommunityListResult. </summary>
        internal BgpServiceCommunityListResult()
        {
            Value = new ChangeTrackingList<BgpServiceCommunity>();
        }

        /// <summary> Initializes a new instance of BgpServiceCommunityListResult. </summary>
        /// <param name="value"> A list of service community resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal BgpServiceCommunityListResult(IReadOnlyList<BgpServiceCommunity> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of service community resources. </summary>
        public IReadOnlyList<BgpServiceCommunity> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
