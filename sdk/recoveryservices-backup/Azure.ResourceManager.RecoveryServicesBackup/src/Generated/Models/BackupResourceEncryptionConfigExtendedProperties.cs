// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The BackupResourceEncryptionConfigExtendedProperties. </summary>
    public partial class BackupResourceEncryptionConfigExtendedProperties : BackupResourceEncryptionConfig
    {
        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedProperties"/>. </summary>
        public BackupResourceEncryptionConfigExtendedProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedProperties"/>. </summary>
        /// <param name="encryptionAtRestType"> Encryption At Rest Type. </param>
        /// <param name="keyUri"> Key Vault Key URI. </param>
        /// <param name="subscriptionId"> Key Vault Subscription Id. </param>
        /// <param name="lastUpdateStatus"></param>
        /// <param name="infrastructureEncryptionState"></param>
        /// <param name="userAssignedIdentity"> User Assigned Identity Id. </param>
        /// <param name="useSystemAssignedIdentity"> bool to indicate whether to use system Assigned Identity or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupResourceEncryptionConfigExtendedProperties(BackupEncryptionAtRestType? encryptionAtRestType, Uri keyUri, string subscriptionId, LastUpdateStatus? lastUpdateStatus, InfrastructureEncryptionState? infrastructureEncryptionState, ResourceIdentifier userAssignedIdentity, bool? useSystemAssignedIdentity, Dictionary<string, BinaryData> rawData) : base(encryptionAtRestType, keyUri, subscriptionId, lastUpdateStatus, infrastructureEncryptionState, rawData)
        {
            UserAssignedIdentity = userAssignedIdentity;
            UseSystemAssignedIdentity = useSystemAssignedIdentity;
        }

        /// <summary> User Assigned Identity Id. </summary>
        public ResourceIdentifier UserAssignedIdentity { get; set; }
        /// <summary> bool to indicate whether to use system Assigned Identity or not. </summary>
        public bool? UseSystemAssignedIdentity { get; set; }
    }
}
