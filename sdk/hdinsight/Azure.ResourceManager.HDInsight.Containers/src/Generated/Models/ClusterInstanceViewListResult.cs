// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The instance view of a HDInsight Cluster. </summary>
    internal partial class ClusterInstanceViewListResult
    {
        /// <summary> Initializes a new instance of ClusterInstanceViewListResult. </summary>
        internal ClusterInstanceViewListResult()
        {
            Value = new ChangeTrackingList<ClusterInstanceViewResult>();
        }

        /// <summary> Initializes a new instance of ClusterInstanceViewListResult. </summary>
        /// <param name="value"> Cluster instance view array. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal ClusterInstanceViewListResult(IReadOnlyList<ClusterInstanceViewResult> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Cluster instance view array. </summary>
        public IReadOnlyList<ClusterInstanceViewResult> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
