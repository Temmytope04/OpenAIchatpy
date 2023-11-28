// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Backup Vault. </summary>
    public partial class DataProtectionBackupVaultProperties
    {
        /// <summary> Initializes a new instance of DataProtectionBackupVaultProperties. </summary>
        /// <param name="storageSettings"> Storage Settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSettings"/> is null. </exception>
        public DataProtectionBackupVaultProperties(IEnumerable<DataProtectionBackupStorageSetting> storageSettings)
        {
            Argument.AssertNotNull(storageSettings, nameof(storageSettings));

            StorageSettings = storageSettings.ToList();
            ReplicatedRegions = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of DataProtectionBackupVaultProperties. </summary>
        /// <param name="monitoringSettings"> Monitoring Settings. </param>
        /// <param name="provisioningState"> Provisioning state of the BackupVault resource. </param>
        /// <param name="resourceMoveState"> Resource move state for backup vault. </param>
        /// <param name="resourceMoveDetails"> Resource move details for backup vault. </param>
        /// <param name="securitySettings"> Security Settings. </param>
        /// <param name="storageSettings"> Storage Settings. </param>
        /// <param name="isVaultProtectedByResourceGuard"> Is vault protected by resource guard. </param>
        /// <param name="featureSettings"> Feature Settings. </param>
        /// <param name="secureScore"> Secure Score of Backup Vault. </param>
        /// <param name="replicatedRegions"> List of replicated regions for Backup Vault. </param>
        internal DataProtectionBackupVaultProperties(MonitoringSettings monitoringSettings, DataProtectionBackupProvisioningState? provisioningState, BackupVaultResourceMoveState? resourceMoveState, BackupVaultResourceMoveDetails resourceMoveDetails, BackupVaultSecuritySettings securitySettings, IList<DataProtectionBackupStorageSetting> storageSettings, bool? isVaultProtectedByResourceGuard, BackupVaultFeatureSettings featureSettings, BackupVaultSecureScoreLevel? secureScore, IList<AzureLocation> replicatedRegions)
        {
            MonitoringSettings = monitoringSettings;
            ProvisioningState = provisioningState;
            ResourceMoveState = resourceMoveState;
            ResourceMoveDetails = resourceMoveDetails;
            SecuritySettings = securitySettings;
            StorageSettings = storageSettings;
            IsVaultProtectedByResourceGuard = isVaultProtectedByResourceGuard;
            FeatureSettings = featureSettings;
            SecureScore = secureScore;
            ReplicatedRegions = replicatedRegions;
        }

        /// <summary> Monitoring Settings. </summary>
        internal MonitoringSettings MonitoringSettings { get; set; }
        /// <summary> Gets or sets the alert settings for all job failures. </summary>
        public AzureMonitorAlertsState? AlertSettingsForAllJobFailures
        {
            get => MonitoringSettings is null ? default : MonitoringSettings.AlertSettingsForAllJobFailures;
            set
            {
                if (MonitoringSettings is null)
                    MonitoringSettings = new MonitoringSettings();
                MonitoringSettings.AlertSettingsForAllJobFailures = value;
            }
        }

        /// <summary> Provisioning state of the BackupVault resource. </summary>
        public DataProtectionBackupProvisioningState? ProvisioningState { get; }
        /// <summary> Resource move state for backup vault. </summary>
        public BackupVaultResourceMoveState? ResourceMoveState { get; }
        /// <summary> Resource move details for backup vault. </summary>
        public BackupVaultResourceMoveDetails ResourceMoveDetails { get; }
        /// <summary> Security Settings. </summary>
        public BackupVaultSecuritySettings SecuritySettings { get; set; }
        /// <summary> Storage Settings. </summary>
        public IList<DataProtectionBackupStorageSetting> StorageSettings { get; }
        /// <summary> Feature Settings. </summary>
        public BackupVaultFeatureSettings FeatureSettings { get; set; }
        /// <summary> Secure Score of Backup Vault. </summary>
        public BackupVaultSecureScoreLevel? SecureScore { get; }
        /// <summary> List of replicated regions for Backup Vault. </summary>
        public IList<AzureLocation> ReplicatedRegions { get; }
    }
}
