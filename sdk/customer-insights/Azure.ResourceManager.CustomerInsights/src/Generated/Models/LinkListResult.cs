// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list link operation. </summary>
    internal partial class LinkListResult
    {
        /// <summary> Initializes a new instance of LinkListResult. </summary>
        internal LinkListResult()
        {
            Value = new ChangeTrackingList<LinkResourceFormatData>();
        }

        /// <summary> Initializes a new instance of LinkListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal LinkListResult(IReadOnlyList<LinkResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<LinkResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
