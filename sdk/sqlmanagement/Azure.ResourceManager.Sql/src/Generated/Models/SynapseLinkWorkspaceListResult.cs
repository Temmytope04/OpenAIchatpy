// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of synapselink workspaces. </summary>
    internal partial class SynapseLinkWorkspaceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseLinkWorkspaceListResult"/>. </summary>
        internal SynapseLinkWorkspaceListResult()
        {
            Value = new ChangeTrackingList<SqlSynapseLinkWorkspace>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseLinkWorkspaceListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseLinkWorkspaceListResult(IReadOnlyList<SqlSynapseLinkWorkspace> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlSynapseLinkWorkspace> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
