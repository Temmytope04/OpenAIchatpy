// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Vault health details definition. </summary>
    public partial class VaultHealthDetails : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VaultHealthDetails"/>. </summary>
        internal VaultHealthDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VaultHealthDetails"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The vault health related data. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VaultHealthDetails(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, VaultHealthProperties properties, AzureLocation? location, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
            _rawData = rawData;
        }

        /// <summary> The vault health related data. </summary>
        public VaultHealthProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
