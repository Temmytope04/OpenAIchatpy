// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs configuration. </summary>
    public partial class ApplicationLogsConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationLogsConfig"/>. </summary>
        public ApplicationLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationLogsConfig"/>. </summary>
        /// <param name="fileSystem"> Application logs to file system configuration. </param>
        /// <param name="azureTableStorage"> Application logs to azure table storage configuration. </param>
        /// <param name="azureBlobStorage"> Application logs to blob storage configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationLogsConfig(FileSystemApplicationLogsConfig fileSystem, AppServiceTableStorageApplicationLogsConfig azureTableStorage, AppServiceBlobStorageApplicationLogsConfig azureBlobStorage, Dictionary<string, BinaryData> rawData)
        {
            FileSystem = fileSystem;
            AzureTableStorage = azureTableStorage;
            AzureBlobStorage = azureBlobStorage;
            _rawData = rawData;
        }

        /// <summary> Application logs to file system configuration. </summary>
        internal FileSystemApplicationLogsConfig FileSystem { get; set; }
        /// <summary> Log level. </summary>
        public WebAppLogLevel? FileSystemLevel
        {
            get => FileSystem is null ? default : FileSystem.Level;
            set
            {
                if (FileSystem is null)
                    FileSystem = new FileSystemApplicationLogsConfig();
                FileSystem.Level = value;
            }
        }

        /// <summary> Application logs to azure table storage configuration. </summary>
        public AppServiceTableStorageApplicationLogsConfig AzureTableStorage { get; set; }
        /// <summary> Application logs to blob storage configuration. </summary>
        public AppServiceBlobStorageApplicationLogsConfig AzureBlobStorage { get; set; }
    }
}
