// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of sync database ID properties. </summary>
    internal partial class SyncDatabaseIdListResult
    {
        /// <summary> Initializes a new instance of <see cref="SyncDatabaseIdListResult"/>. </summary>
        internal SyncDatabaseIdListResult()
        {
            Value = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="SyncDatabaseIdListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SyncDatabaseIdListResult(IReadOnlyList<SubResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SubResource> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
