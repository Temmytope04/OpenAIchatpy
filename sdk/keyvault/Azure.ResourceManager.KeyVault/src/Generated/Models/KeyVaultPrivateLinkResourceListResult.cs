// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class KeyVaultPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of <see cref="KeyVaultPrivateLinkResourceListResult"/>. </summary>
        internal KeyVaultPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<KeyVaultPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal KeyVaultPrivateLinkResourceListResult(IReadOnlyList<KeyVaultPrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<KeyVaultPrivateLinkResourceData> Value { get; }
    }
}
