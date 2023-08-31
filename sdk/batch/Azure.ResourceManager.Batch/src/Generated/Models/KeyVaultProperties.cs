// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault. </summary>
    internal partial class KeyVaultProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultProperties"/>. </summary>
        public KeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultProperties"/>. </summary>
        /// <param name="keyIdentifier">
        /// Full path to the secret with or without version. Example https://mykeyvault.vault.azure.net/keys/testkey/6e34a81fef704045975661e297a4c053. or https://mykeyvault.vault.azure.net/keys/testkey. To be usable the following prerequisites must be met:
        ///
        ///  The Batch Account has a System Assigned identity
        ///  The account identity has been granted Key/Get, Key/Unwrap and Key/Wrap permissions
        ///  The KeyVault has soft-delete and purge protection enabled
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultProperties(Uri keyIdentifier, Dictionary<string, BinaryData> rawData)
        {
            KeyIdentifier = keyIdentifier;
            _rawData = rawData;
        }

        /// <summary>
        /// Full path to the secret with or without version. Example https://mykeyvault.vault.azure.net/keys/testkey/6e34a81fef704045975661e297a4c053. or https://mykeyvault.vault.azure.net/keys/testkey. To be usable the following prerequisites must be met:
        ///
        ///  The Batch Account has a System Assigned identity
        ///  The account identity has been granted Key/Get, Key/Unwrap and Key/Wrap permissions
        ///  The KeyVault has soft-delete and purge protection enabled
        /// </summary>
        public Uri KeyIdentifier { get; set; }
    }
}
