// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The AzureDevOpsConnectorStatsListResponse. </summary>
    internal partial class AzureDevOpsConnectorStatsListResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsConnectorStatsListResponse"/>. </summary>
        internal AzureDevOpsConnectorStatsListResponse()
        {
            Value = new ChangeTrackingList<AzureDevOpsConnectorStats>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsConnectorStatsListResponse"/>. </summary>
        /// <param name="value"> Gets or sets list of resources. </param>
        /// <param name="nextLink"> Gets or sets next link to scroll over the results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsConnectorStatsListResponse(IReadOnlyList<AzureDevOpsConnectorStats> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets or sets list of resources. </summary>
        public IReadOnlyList<AzureDevOpsConnectorStats> Value { get; }
        /// <summary> Gets or sets next link to scroll over the results. </summary>
        public string NextLink { get; }
    }
}
