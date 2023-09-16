// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DefenderEasm;

namespace Azure.ResourceManager.DefenderEasm.Models
{
    /// <summary> The list of workspaces. </summary>
    internal partial class EasmWorkspaceListResult
    {
        /// <summary> Initializes a new instance of EasmWorkspaceListResult. </summary>
        internal EasmWorkspaceListResult()
        {
            Value = new ChangeTrackingList<EasmWorkspaceData>();
        }

        /// <summary> Initializes a new instance of EasmWorkspaceListResult. </summary>
        /// <param name="nextLink"> The link used to get the next page of Workspace list. </param>
        /// <param name="value"> The list of workspaces. </param>
        internal EasmWorkspaceListResult(string nextLink, IReadOnlyList<EasmWorkspaceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of Workspace list. </summary>
        public string NextLink { get; }
        /// <summary> The list of workspaces. </summary>
        public IReadOnlyList<EasmWorkspaceData> Value { get; }
    }
}
