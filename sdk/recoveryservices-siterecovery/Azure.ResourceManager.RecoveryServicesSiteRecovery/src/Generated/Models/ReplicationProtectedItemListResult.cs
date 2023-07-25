// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication protected item collection. </summary>
    internal partial class ReplicationProtectedItemListResult
    {
        /// <summary> Initializes a new instance of ReplicationProtectedItemListResult. </summary>
        internal ReplicationProtectedItemListResult()
        {
            Value = new ChangeTrackingList<ReplicationProtectedItemData>();
        }

        /// <summary> Initializes a new instance of ReplicationProtectedItemListResult. </summary>
        /// <param name="value"> The Replication protected item details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal ReplicationProtectedItemListResult(IReadOnlyList<ReplicationProtectedItemData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The Replication protected item details. </summary>
        public IReadOnlyList<ReplicationProtectedItemData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
