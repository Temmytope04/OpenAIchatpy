// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> An ADLS Gen 1 folder data set. </summary>
    public partial class AdlsGen1FolderDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of <see cref="AdlsGen1FolderDataSet"/>. </summary>
        /// <param name="accountName"> The ADLS account name. </param>
        /// <param name="folderPath"> The folder path within the ADLS account. </param>
        /// <param name="resourceGroup"> Resource group of ADLS account. </param>
        /// <param name="subscriptionId"> Subscription id of ADLS account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="folderPath"/>, <paramref name="resourceGroup"/> or <paramref name="subscriptionId"/> is null. </exception>
        public AdlsGen1FolderDataSet(string accountName, string folderPath, string resourceGroup, string subscriptionId)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(folderPath, nameof(folderPath));
            Argument.AssertNotNull(resourceGroup, nameof(resourceGroup));
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));

            AccountName = accountName;
            FolderPath = folderPath;
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            Kind = DataSetKind.AdlsGen1Folder;
        }

        /// <summary> Initializes a new instance of <see cref="AdlsGen1FolderDataSet"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="accountName"> The ADLS account name. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="folderPath"> The folder path within the ADLS account. </param>
        /// <param name="resourceGroup"> Resource group of ADLS account. </param>
        /// <param name="subscriptionId"> Subscription id of ADLS account. </param>
        internal AdlsGen1FolderDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string accountName, Guid? dataSetId, string folderPath, string resourceGroup, string subscriptionId) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AccountName = accountName;
            DataSetId = dataSetId;
            FolderPath = folderPath;
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="AdlsGen1FolderDataSet"/> for deserialization. </summary>
        internal AdlsGen1FolderDataSet()
        {
        }

        /// <summary> The ADLS account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> The folder path within the ADLS account. </summary>
        public string FolderPath { get; set; }
        /// <summary> Resource group of ADLS account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Subscription id of ADLS account. </summary>
        public string SubscriptionId { get; set; }
    }
}
