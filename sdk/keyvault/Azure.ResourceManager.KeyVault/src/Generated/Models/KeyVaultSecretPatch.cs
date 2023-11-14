// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Parameters for patching a secret. </summary>
    public partial class KeyVaultSecretPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretPatch"/>. </summary>
        public KeyVaultSecretPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretPatch"/>. </summary>
        /// <param name="tags"> The tags that will be assigned to the secret. </param>
        /// <param name="properties"> Properties of the secret. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultSecretPatch(IDictionary<string, string> tags, SecretPatchProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The tags that will be assigned to the secret. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the secret. </summary>
        public SecretPatchProperties Properties { get; set; }
    }
}
