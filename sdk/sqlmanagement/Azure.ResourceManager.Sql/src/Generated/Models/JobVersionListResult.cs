// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of job versions. </summary>
    public partial class JobVersionListResult
    {
        /// <summary> Initializes a new instance of JobVersionListResult. </summary>
        internal JobVersionListResult()
        {
            Value = new ChangeTrackingList<Resource>();
        }

        /// <summary> Initializes a new instance of JobVersionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobVersionListResult(IReadOnlyList<Resource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<Resource> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
