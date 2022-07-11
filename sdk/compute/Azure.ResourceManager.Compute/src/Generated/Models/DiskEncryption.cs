// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Encryption at rest settings for disk or snapshot. </summary>
    public partial class DiskEncryption
    {
        /// <summary> Initializes a new instance of DiskEncryption. </summary>
        public DiskEncryption()
        {
        }

        /// <summary> Initializes a new instance of DiskEncryption. </summary>
        /// <param name="diskEncryptionSetId"> ResourceId of the disk encryption set to use for enabling encryption at rest. </param>
        /// <param name="encryptionType"> The type of key used to encrypt the data of the disk. </param>
        internal DiskEncryption(ResourceIdentifier diskEncryptionSetId, ComputeEncryptionType? encryptionType)
        {
            DiskEncryptionSetId = diskEncryptionSetId;
            EncryptionType = encryptionType;
        }

        /// <summary> ResourceId of the disk encryption set to use for enabling encryption at rest. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
        /// <summary> The type of key used to encrypt the data of the disk. </summary>
        public ComputeEncryptionType? EncryptionType { get; set; }
    }
}
