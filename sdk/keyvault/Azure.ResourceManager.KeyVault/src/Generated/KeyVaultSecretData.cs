// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary>
    /// A class representing the KeyVaultSecret data model.
    /// Resource information with extended details.
    /// </summary>
    public partial class KeyVaultSecretData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretData"/>. </summary>
        /// <param name="properties"> Properties of the secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public KeyVaultSecretData(SecretProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the secret. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        internal KeyVaultSecretData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecretProperties properties, AzureLocation? location, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
            Tags = tags;
        }

        /// <summary> Properties of the secret. </summary>
        public SecretProperties Properties { get; set; }
        /// <summary> Azure location of the key vault resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Tags assigned to the key vault resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
