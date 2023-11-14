// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The parameters used to check the availability of the vault name. </summary>
    public partial class KeyVaultNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The vault name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KeyVaultNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = "Microsoft.KeyVault/vaults";
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The vault name. </param>
        /// <param name="resourceType"> The type of resource, Microsoft.KeyVault/vaults. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultNameAvailabilityContent(string name, ResourceType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultNameAvailabilityContent"/> for deserialization. </summary>
        internal KeyVaultNameAvailabilityContent()
        {
        }

        /// <summary> The vault name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.KeyVault/vaults. </summary>
        public ResourceType ResourceType { get; }
    }
}
