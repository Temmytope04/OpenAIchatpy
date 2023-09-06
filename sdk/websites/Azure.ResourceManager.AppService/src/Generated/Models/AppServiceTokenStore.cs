// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the token store. </summary>
    public partial class AppServiceTokenStore
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceTokenStore"/>. </summary>
        public AppServiceTokenStore()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceTokenStore"/>. </summary>
        /// <param name="isEnabled">
        /// &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  The default is &lt;code&gt;false&lt;/code&gt;.
        /// </param>
        /// <param name="tokenRefreshExtensionHours">
        /// The number of hours after session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </param>
        /// <param name="fileSystem"> The configuration settings of the storage of the tokens if a file system is used. </param>
        /// <param name="azureBlobStorage"> The configuration settings of the storage of the tokens if blob storage is used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceTokenStore(bool? isEnabled, double? tokenRefreshExtensionHours, FileSystemTokenStore fileSystem, AppServiceBlobStorageTokenStore azureBlobStorage, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            TokenRefreshExtensionHours = tokenRefreshExtensionHours;
            FileSystem = fileSystem;
            AzureBlobStorage = azureBlobStorage;
            _rawData = rawData;
        }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  The default is &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </summary>
        public double? TokenRefreshExtensionHours { get; set; }
        /// <summary> The configuration settings of the storage of the tokens if a file system is used. </summary>
        internal FileSystemTokenStore FileSystem { get; set; }
        /// <summary> The directory in which the tokens will be stored. </summary>
        public string FileSystemDirectory
        {
            get => FileSystem is null ? default : FileSystem.Directory;
            set
            {
                if (FileSystem is null)
                    FileSystem = new FileSystemTokenStore();
                FileSystem.Directory = value;
            }
        }

        /// <summary> The configuration settings of the storage of the tokens if blob storage is used. </summary>
        internal AppServiceBlobStorageTokenStore AzureBlobStorage { get; set; }
        /// <summary> The name of the app setting containing the SAS URL of the blob storage containing the tokens. </summary>
        public string AzureBlobStorageSasUrlSettingName
        {
            get => AzureBlobStorage is null ? default : AzureBlobStorage.SasUrlSettingName;
            set
            {
                if (AzureBlobStorage is null)
                    AzureBlobStorage = new AppServiceBlobStorageTokenStore();
                AzureBlobStorage.SasUrlSettingName = value;
            }
        }
    }
}
