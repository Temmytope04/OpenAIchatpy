// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> AzureBlob CSI Driver settings for the storage profile. </summary>
    internal partial class ManagedClusterStorageProfileBlobCsiDriver
    {
        /// <summary> Initializes a new instance of ManagedClusterStorageProfileBlobCsiDriver. </summary>
        public ManagedClusterStorageProfileBlobCsiDriver()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterStorageProfileBlobCsiDriver. </summary>
        /// <param name="isEnabled"> Whether to enable AzureBlob CSI Driver. The default value is false. </param>
        internal ManagedClusterStorageProfileBlobCsiDriver(bool? isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Whether to enable AzureBlob CSI Driver. The default value is false. </summary>
        public bool? IsEnabled { get; set; }
    }
}
