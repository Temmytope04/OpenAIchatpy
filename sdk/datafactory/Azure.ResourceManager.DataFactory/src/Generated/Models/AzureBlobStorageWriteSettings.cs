// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure blob write settings. </summary>
    public partial class AzureBlobStorageWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of AzureBlobStorageWriteSettings. </summary>
        public AzureBlobStorageWriteSettings()
        {
            StoreWriteSettingsType = "AzureBlobStorageWriteSettings";
        }

        /// <summary> Initializes a new instance of AzureBlobStorageWriteSettings. </summary>
        /// <param name="storeWriteSettingsType"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="blockSizeInMB"> Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer). </param>
        internal AzureBlobStorageWriteSettings(string storeWriteSettingsType, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, BinaryData copyBehavior, IDictionary<string, BinaryData> additionalProperties, BinaryData blockSizeInMB) : base(storeWriteSettingsType, maxConcurrentConnections, disableMetricsCollection, copyBehavior, additionalProperties)
        {
            BlockSizeInMB = blockSizeInMB;
            StoreWriteSettingsType = storeWriteSettingsType ?? "AzureBlobStorageWriteSettings";
        }

        /// <summary> Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer). </summary>
        public BinaryData BlockSizeInMB { get; set; }
    }
}
