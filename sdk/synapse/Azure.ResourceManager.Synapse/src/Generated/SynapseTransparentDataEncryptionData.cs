// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseTransparentDataEncryption data model.
    /// Represents a Sql pool transparent data encryption configuration.
    /// </summary>
    public partial class SynapseTransparentDataEncryptionData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseTransparentDataEncryptionData"/>. </summary>
        public SynapseTransparentDataEncryptionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseTransparentDataEncryptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="status"> The status of the database transparent data encryption. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseTransparentDataEncryptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, SynapseTransparentDataEncryptionStatus? status, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The status of the database transparent data encryption. </summary>
        public SynapseTransparentDataEncryptionStatus? Status { get; set; }
    }
}
