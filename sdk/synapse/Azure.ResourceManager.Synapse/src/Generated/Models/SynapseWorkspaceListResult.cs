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
    /// <summary> List of workspaces. </summary>
    internal partial class SynapseWorkspaceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceListResult"/>. </summary>
        internal SynapseWorkspaceListResult()
        {
            Value = new ChangeTrackingList<SynapseWorkspaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of workspaces. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseWorkspaceListResult(string nextLink, IReadOnlyList<SynapseWorkspaceData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of workspaces. </summary>
        public IReadOnlyList<SynapseWorkspaceData> Value { get; }
    }
}
