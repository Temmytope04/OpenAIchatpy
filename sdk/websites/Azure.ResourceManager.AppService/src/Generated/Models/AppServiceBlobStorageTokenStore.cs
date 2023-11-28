// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the storage of the tokens if blob storage is used. </summary>
    internal partial class AppServiceBlobStorageTokenStore
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageTokenStore"/>. </summary>
        public AppServiceBlobStorageTokenStore()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageTokenStore"/>. </summary>
        /// <param name="sasUrlSettingName"> The name of the app setting containing the SAS URL of the blob storage containing the tokens. </param>
        internal AppServiceBlobStorageTokenStore(string sasUrlSettingName)
        {
            SasUrlSettingName = sasUrlSettingName;
        }

        /// <summary> The name of the app setting containing the SAS URL of the blob storage containing the tokens. </summary>
        public string SasUrlSettingName { get; set; }
    }
}
