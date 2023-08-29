// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> AML file system container storage interface information. </summary>
    public partial class AmlFileSystemContainerStorageInterface
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemContainerStorageInterface"/>. </summary>
        internal AmlFileSystemContainerStorageInterface()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemContainerStorageInterface"/>. </summary>
        /// <param name="persistentVolumeClaim"> Recommended AKS Persistent Volume Claim for the CSI driver, in Base64 encoded YAML. </param>
        /// <param name="persistentVolume"> Recommended AKS Persistent Volume for the CSI driver, in Base64 encoded YAML. </param>
        /// <param name="storageClass"> Recommended AKS Storage Class for the CSI driver, in Base64 encoded YAML. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlFileSystemContainerStorageInterface(string persistentVolumeClaim, string persistentVolume, string storageClass, Dictionary<string, BinaryData> rawData)
        {
            PersistentVolumeClaim = persistentVolumeClaim;
            PersistentVolume = persistentVolume;
            StorageClass = storageClass;
            _rawData = rawData;
        }

        /// <summary> Recommended AKS Persistent Volume Claim for the CSI driver, in Base64 encoded YAML. </summary>
        public string PersistentVolumeClaim { get; }
        /// <summary> Recommended AKS Persistent Volume for the CSI driver, in Base64 encoded YAML. </summary>
        public string PersistentVolume { get; }
        /// <summary> Recommended AKS Storage Class for the CSI driver, in Base64 encoded YAML. </summary>
        public string StorageClass { get; }
    }
}
