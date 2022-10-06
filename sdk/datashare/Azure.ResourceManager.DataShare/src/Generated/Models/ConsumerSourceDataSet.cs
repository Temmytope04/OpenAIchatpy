// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A consumer side dataSet data transfer object. </summary>
    public partial class ConsumerSourceDataSet : ResourceData
    {
        /// <summary> Initializes a new instance of ConsumerSourceDataSet. </summary>
        public ConsumerSourceDataSet()
        {
        }

        /// <summary> Initializes a new instance of ConsumerSourceDataSet. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dataSetId"> DataSet Id. </param>
        /// <param name="dataSetLocation"> Location of the data set. </param>
        /// <param name="dataSetName"> DataSet name. </param>
        /// <param name="dataSetPath"> DataSet path. </param>
        /// <param name="dataSetType"> Type of data set. </param>
        internal ConsumerSourceDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? dataSetId, AzureLocation? dataSetLocation, string dataSetName, string dataSetPath, ShareDataSetType? dataSetType) : base(id, name, resourceType, systemData)
        {
            DataSetId = dataSetId;
            DataSetLocation = dataSetLocation;
            DataSetName = dataSetName;
            DataSetPath = dataSetPath;
            DataSetType = dataSetType;
        }

        /// <summary> DataSet Id. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Location of the data set. </summary>
        public AzureLocation? DataSetLocation { get; }
        /// <summary> DataSet name. </summary>
        public string DataSetName { get; }
        /// <summary> DataSet path. </summary>
        public string DataSetPath { get; }
        /// <summary> Type of data set. </summary>
        public ShareDataSetType? DataSetType { get; }
    }
}
