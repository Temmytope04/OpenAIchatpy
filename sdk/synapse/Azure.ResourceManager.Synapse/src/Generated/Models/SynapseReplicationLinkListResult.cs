// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Represents the response to a List Sql pool replication link request. </summary>
    internal partial class SynapseReplicationLinkListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseReplicationLinkListResult"/>. </summary>
        internal SynapseReplicationLinkListResult()
        {
            Value = new ChangeTrackingList<SynapseReplicationLinkData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseReplicationLinkListResult"/>. </summary>
        /// <param name="value"> The list of Sql pool replication links housed in the Sql pool. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseReplicationLinkListResult(IReadOnlyList<SynapseReplicationLinkData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of Sql pool replication links housed in the Sql pool. </summary>
        public IReadOnlyList<SynapseReplicationLinkData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
