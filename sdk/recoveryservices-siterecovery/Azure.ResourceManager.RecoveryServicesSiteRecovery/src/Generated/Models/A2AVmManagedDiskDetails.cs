// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A managed disk input details. </summary>
    public partial class A2AVmManagedDiskDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="A2AVmManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="primaryStagingAzureStorageAccountId"> The primary staging storage account Arm Id. </param>
        /// <param name="recoveryResourceGroupId"> The target resource group Arm Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/>, <paramref name="primaryStagingAzureStorageAccountId"/> or <paramref name="recoveryResourceGroupId"/> is null. </exception>
        public A2AVmManagedDiskDetails(string diskId, ResourceIdentifier primaryStagingAzureStorageAccountId, ResourceIdentifier recoveryResourceGroupId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));
            Argument.AssertNotNull(primaryStagingAzureStorageAccountId, nameof(primaryStagingAzureStorageAccountId));
            Argument.AssertNotNull(recoveryResourceGroupId, nameof(recoveryResourceGroupId));

            DiskId = diskId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
        }

        /// <summary> Initializes a new instance of <see cref="A2AVmManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="primaryStagingAzureStorageAccountId"> The primary staging storage account Arm Id. </param>
        /// <param name="recoveryResourceGroupId"> The target resource group Arm Id. </param>
        /// <param name="recoveryReplicaDiskAccountType"> The replica disk type. Its an optional value and will be same as source disk type if not user provided. </param>
        /// <param name="recoveryTargetDiskAccountType"> The target disk type after failover. Its an optional value and will be same as source disk type if not user provided. </param>
        /// <param name="recoveryDiskEncryptionSetId"> The recovery disk encryption set Id. </param>
        /// <param name="diskEncryptionInfo"> The recovery disk encryption information (for one / single pass flows). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal A2AVmManagedDiskDetails(string diskId, ResourceIdentifier primaryStagingAzureStorageAccountId, ResourceIdentifier recoveryResourceGroupId, string recoveryReplicaDiskAccountType, string recoveryTargetDiskAccountType, ResourceIdentifier recoveryDiskEncryptionSetId, SiteRecoveryDiskEncryptionInfo diskEncryptionInfo, Dictionary<string, BinaryData> rawData)
        {
            DiskId = diskId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            RecoveryReplicaDiskAccountType = recoveryReplicaDiskAccountType;
            RecoveryTargetDiskAccountType = recoveryTargetDiskAccountType;
            RecoveryDiskEncryptionSetId = recoveryDiskEncryptionSetId;
            DiskEncryptionInfo = diskEncryptionInfo;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="A2AVmManagedDiskDetails"/> for deserialization. </summary>
        internal A2AVmManagedDiskDetails()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The primary staging storage account Arm Id. </summary>
        public ResourceIdentifier PrimaryStagingAzureStorageAccountId { get; }
        /// <summary> The target resource group Arm Id. </summary>
        public ResourceIdentifier RecoveryResourceGroupId { get; }
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
