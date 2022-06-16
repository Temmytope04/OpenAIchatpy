// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The GalleryTargetExtendedLocation. </summary>
    public partial class GalleryTargetExtendedLocation
    {
        /// <summary> Initializes a new instance of GalleryTargetExtendedLocation. </summary>
        public GalleryTargetExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of GalleryTargetExtendedLocation. </summary>
        /// <param name="name"> The name of the region. </param>
        /// <param name="extendedLocation"> The name of the extended location. </param>
        /// <param name="extendedLocationReplicaCount"> The number of replicas of the Image Version to be created per extended location. This property is updatable. </param>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to store the image. This property is not updatable. </param>
        /// <param name="encryption"> Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact. </param>
        internal GalleryTargetExtendedLocation(string name, GalleryExtendedLocation extendedLocation, int? extendedLocationReplicaCount, StorageAccountType? storageAccountType, EncryptionImages encryption)
        {
            Name = name;
            ExtendedLocation = extendedLocation;
            ExtendedLocationReplicaCount = extendedLocationReplicaCount;
            StorageAccountType = storageAccountType;
            Encryption = encryption;
        }

        /// <summary> The name of the region. </summary>
        public string Name { get; set; }
        /// <summary> The name of the extended location. </summary>
        public GalleryExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The number of replicas of the Image Version to be created per extended location. This property is updatable. </summary>
        public int? ExtendedLocationReplicaCount { get; set; }
        /// <summary> Specifies the storage account type to be used to store the image. This property is not updatable. </summary>
        public StorageAccountType? StorageAccountType { get; set; }
        /// <summary> Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact. </summary>
        public EncryptionImages Encryption { get; set; }
    }
}
