// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Result of the request to list Microsoft.Features operations. It contains a list of operations and a URL link to get the next set of results. </summary>
    public partial class OperationListResultAutoGenerated
    {
        /// <summary> Initializes a new instance of OperationListResultAutoGenerated. </summary>
        internal OperationListResultAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of OperationListResultAutoGenerated. </summary>
        /// <param name="value"> List of Microsoft.Features operations. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal OperationListResultAutoGenerated(IReadOnlyList<OperationAutoGenerated> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Microsoft.Features operations. </summary>
        public IReadOnlyList<OperationAutoGenerated> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
