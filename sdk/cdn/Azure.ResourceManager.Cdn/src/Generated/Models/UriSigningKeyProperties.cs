// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Url signing key parameters. </summary>
    public partial class UriSigningKeyProperties : FrontDoorSecretProperties
    {
        /// <summary> Initializes a new instance of <see cref="UriSigningKeyProperties"/>. </summary>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="secretSource"> Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyId"/> or <paramref name="secretSource"/> is null. </exception>
        public UriSigningKeyProperties(string keyId, WritableSubResource secretSource)
        {
            Argument.AssertNotNull(keyId, nameof(keyId));
            Argument.AssertNotNull(secretSource, nameof(secretSource));

            KeyId = keyId;
            SecretSource = secretSource;
            SecretType = SecretType.UriSigningKey;
        }

        /// <summary> Initializes a new instance of <see cref="UriSigningKeyProperties"/>. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="secretSource"> Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </param>
        /// <param name="secretVersion"> Version of the secret to be used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UriSigningKeyProperties(SecretType secretType, string keyId, WritableSubResource secretSource, string secretVersion, Dictionary<string, BinaryData> rawData) : base(secretType, rawData)
        {
            KeyId = keyId;
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            SecretType = secretType;
        }

        /// <summary> Initializes a new instance of <see cref="UriSigningKeyProperties"/> for deserialization. </summary>
        internal UriSigningKeyProperties()
        {
        }

        /// <summary> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </summary>
        public string KeyId { get; set; }
        /// <summary> Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </summary>
        internal WritableSubResource SecretSource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SecretSourceId
        {
            get => SecretSource is null ? default : SecretSource.Id;
            set
            {
                if (SecretSource is null)
                    SecretSource = new WritableSubResource();
                SecretSource.Id = value;
            }
        }

        /// <summary> Version of the secret to be used. </summary>
        public string SecretVersion { get; set; }
    }
}
