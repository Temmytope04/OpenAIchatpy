// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> An Azure storage blob container data set. </summary>
    public partial class BlobContainerDataSet : DataSetData
    {
        /// <summary> Initializes a new instance of BlobContainerDataSet. </summary>
        /// <param name="containerName"> BLOB Container name. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/>, <paramref name="resourceGroup"/>, <paramref name="storageAccountName"/> or <paramref name="subscriptionId"/> is null. </exception>
        public BlobContainerDataSet(string containerName, string resourceGroup, string storageAccountName, string subscriptionId)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (storageAccountName == null)
            {
                throw new ArgumentNullException(nameof(storageAccountName));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            ContainerName = containerName;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = DataSetKind.Container;
        }

        /// <summary> Initializes a new instance of BlobContainerDataSet. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="containerName"> BLOB Container name. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        internal BlobContainerDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, string containerName, string dataSetId, string resourceGroup, string storageAccountName, string subscriptionId) : base(id, name, resourceType, systemData, kind)
        {
            ContainerName = containerName;
            DataSetId = dataSetId;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = kind;
        }

        /// <summary> BLOB Container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> Unique id for identifying a data set resource. </summary>
        public string DataSetId { get; }
        /// <summary> Resource group of storage account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Storage account name of the source data set. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> Subscription id of storage account. </summary>
        public string SubscriptionId { get; set; }
    }
}
