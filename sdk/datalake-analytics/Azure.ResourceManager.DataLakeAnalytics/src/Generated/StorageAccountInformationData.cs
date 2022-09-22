// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary> A class representing the StorageAccountInformation data model. </summary>
    public partial class StorageAccountInformationData : ResourceData
    {
        /// <summary> Initializes a new instance of StorageAccountInformationData. </summary>
        internal StorageAccountInformationData()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountInformationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="suffix"> The optional suffix for the storage account. </param>
        internal StorageAccountInformationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string suffix) : base(id, name, resourceType, systemData)
        {
            Suffix = suffix;
        }

        /// <summary> The optional suffix for the storage account. </summary>
        public string Suffix { get; }
    }
}
