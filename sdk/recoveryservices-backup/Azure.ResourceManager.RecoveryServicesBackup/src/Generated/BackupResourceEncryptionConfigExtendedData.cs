// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary> A class representing the BackupResourceEncryptionConfigExtended data model. </summary>
    public partial class BackupResourceEncryptionConfigExtendedData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BackupResourceEncryptionConfigExtendedData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> BackupResourceEncryptionConfigExtendedResource properties. </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupResourceEncryptionConfigExtendedData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupResourceEncryptionConfigExtendedProperties properties, ETag? eTag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedData"/> for deserialization. </summary>
        internal BackupResourceEncryptionConfigExtendedData()
        {
        }

        /// <summary> BackupResourceEncryptionConfigExtendedResource properties. </summary>
        public BackupResourceEncryptionConfigExtendedProperties Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
