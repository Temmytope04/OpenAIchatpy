// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Azure VM managed disk input details. </summary>
    public partial class A2AProtectionIntentManagedDiskDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="A2AProtectionIntentManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> is null. </exception>
        public A2AProtectionIntentManagedDiskDetails(string diskId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));

            DiskId = diskId;
        }

        /// <summary> Initializes a new instance of <see cref="A2AProtectionIntentManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="primaryStagingStorageAccountCustomContent">
        /// The primary staging storage account input.
        /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingStorageAccount"/>.
        /// </param>
        /// <param name="recoveryResourceGroupCustomContent">
        /// The recovery resource group input.
        /// Please note <see cref="RecoveryResourceGroupCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryResourceGroup"/>.
        /// </param>
        /// <param name="recoveryReplicaDiskAccountType"> The replica disk type. Its an optional value and will be same as source disk type if not user provided. </param>
        /// <param name="recoveryTargetDiskAccountType"> The target disk type after failover. Its an optional value and will be same as source disk type if not user provided. </param>
        /// <param name="recoveryDiskEncryptionSetId"> The recovery disk encryption set Id. </param>
        /// <param name="diskEncryptionInfo"> The recovery disk encryption information (for one / single pass flows). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal A2AProtectionIntentManagedDiskDetails(string diskId, StorageAccountCustomDetails primaryStagingStorageAccountCustomContent, RecoveryResourceGroupCustomDetails recoveryResourceGroupCustomContent, string recoveryReplicaDiskAccountType, string recoveryTargetDiskAccountType, ResourceIdentifier recoveryDiskEncryptionSetId, SiteRecoveryDiskEncryptionInfo diskEncryptionInfo, Dictionary<string, BinaryData> rawData)
        {
            DiskId = diskId;
            PrimaryStagingStorageAccountCustomContent = primaryStagingStorageAccountCustomContent;
            RecoveryResourceGroupCustomContent = recoveryResourceGroupCustomContent;
            RecoveryReplicaDiskAccountType = recoveryReplicaDiskAccountType;
            RecoveryTargetDiskAccountType = recoveryTargetDiskAccountType;
            RecoveryDiskEncryptionSetId = recoveryDiskEncryptionSetId;
            DiskEncryptionInfo = diskEncryptionInfo;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="A2AProtectionIntentManagedDiskDetails"/> for deserialization. </summary>
        internal A2AProtectionIntentManagedDiskDetails()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; set; }
        /// <summary>
        /// The primary staging storage account input.
        /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingStorageAccount"/>.
        /// </summary>
        public StorageAccountCustomDetails PrimaryStagingStorageAccountCustomContent { get; set; }
        /// <summary>
        /// The recovery resource group input.
        /// Please note <see cref="RecoveryResourceGroupCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryResourceGroup"/>.
        /// </summary>
        public RecoveryResourceGroupCustomDetails RecoveryResourceGroupCustomContent { get; set; }
        /// <summary> The replica disk type. Its an optional value and will be same as source disk type if not user provided. </summary>
        public string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary> The target disk type after failover. Its an optional value and will be same as source disk type if not user provided. </summary>
        public string RecoveryTargetDiskAccountType { get; set; }
        /// <summary> The recovery disk encryption set Id. </summary>
        public ResourceIdentifier RecoveryDiskEncryptionSetId { get; set; }
        /// <summary> The recovery disk encryption information (for one / single pass flows). </summary>
        public SiteRecoveryDiskEncryptionInfo DiskEncryptionInfo { get; set; }
    }
}
