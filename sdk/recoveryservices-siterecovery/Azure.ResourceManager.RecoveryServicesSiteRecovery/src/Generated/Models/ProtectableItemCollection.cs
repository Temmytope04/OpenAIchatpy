// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Protectable item collection. </summary>
    internal partial class ProtectableItemCollection
    {
        /// <summary> Initializes a new instance of ProtectableItemCollection. </summary>
        internal ProtectableItemCollection()
        {
            Value = new ChangeTrackingList<ProtectableItemData>();
        }

        /// <summary> Initializes a new instance of ProtectableItemCollection. </summary>
        /// <param name="value"> The Protectable item details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal ProtectableItemCollection(IReadOnlyList<ProtectableItemData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The Protectable item details. </summary>
        public IReadOnlyList<ProtectableItemData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
