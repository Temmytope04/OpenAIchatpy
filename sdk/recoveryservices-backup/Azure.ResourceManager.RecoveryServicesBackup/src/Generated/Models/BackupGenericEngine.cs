// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// The base backup engine class. All workload specific backup engines derive from this class.
    /// Please note <see cref="BackupGenericEngine"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BackupServerEngine"/> and <see cref="DpmBackupEngine"/>.
    /// </summary>
    public abstract partial class BackupGenericEngine
    {
        /// <summary> Initializes a new instance of BackupGenericEngine. </summary>
        protected BackupGenericEngine()
        {
        }

        /// <summary> Initializes a new instance of BackupGenericEngine. </summary>
        /// <param name="friendlyName"> Friendly name of the backup engine. </param>
        /// <param name="backupManagementType"> Type of backup management for the backup engine. </param>
        /// <param name="registrationStatus"> Registration status of the backup engine with the Recovery Services Vault. </param>
        /// <param name="backupEngineState"> Status of the backup engine with the Recovery Services Vault. = {Active/Deleting/DeleteFailed}. </param>
        /// <param name="healthStatus"> Backup status of the backup engine. </param>
        /// <param name="backupEngineType"> Type of the backup engine. </param>
        /// <param name="canReRegister"> Flag indicating if the backup engine be registered, once already registered. </param>
        /// <param name="backupEngineId"> ID of the backup engine. </param>
        /// <param name="dpmVersion"> Backup engine version. </param>
        /// <param name="azureBackupAgentVersion"> Backup agent version. </param>
        /// <param name="isAzureBackupAgentUpgradeAvailable"> To check if backup agent upgrade available. </param>
        /// <param name="isDpmUpgradeAvailable"> To check if backup engine upgrade available. </param>
        /// <param name="extendedInfo"> Extended info of the backupengine. </param>
        internal BackupGenericEngine(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string backupEngineState, string healthStatus, BackupEngineType backupEngineType, bool? canReRegister, string backupEngineId, string dpmVersion, string azureBackupAgentVersion, bool? isAzureBackupAgentUpgradeAvailable, bool? isDpmUpgradeAvailable, BackupEngineExtendedInfo extendedInfo)
        {
            FriendlyName = friendlyName;
            BackupManagementType = backupManagementType;
            RegistrationStatus = registrationStatus;
            BackupEngineState = backupEngineState;
            HealthStatus = healthStatus;
            BackupEngineType = backupEngineType;
            CanReRegister = canReRegister;
            BackupEngineId = backupEngineId;
            DpmVersion = dpmVersion;
            AzureBackupAgentVersion = azureBackupAgentVersion;
            IsAzureBackupAgentUpgradeAvailable = isAzureBackupAgentUpgradeAvailable;
            IsDpmUpgradeAvailable = isDpmUpgradeAvailable;
            ExtendedInfo = extendedInfo;
        }

        /// <summary> Friendly name of the backup engine. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Type of backup management for the backup engine. </summary>
        public BackupManagementType? BackupManagementType { get; set; }
        /// <summary> Registration status of the backup engine with the Recovery Services Vault. </summary>
        public string RegistrationStatus { get; set; }
        /// <summary> Status of the backup engine with the Recovery Services Vault. = {Active/Deleting/DeleteFailed}. </summary>
        public string BackupEngineState { get; set; }
        /// <summary> Backup status of the backup engine. </summary>
        public string HealthStatus { get; set; }
        /// <summary> Type of the backup engine. </summary>
        internal BackupEngineType BackupEngineType { get; set; }
        /// <summary> Flag indicating if the backup engine be registered, once already registered. </summary>
        public bool? CanReRegister { get; set; }
        /// <summary> ID of the backup engine. </summary>
        public string BackupEngineId { get; set; }
        /// <summary> Backup engine version. </summary>
        public string DpmVersion { get; set; }
        /// <summary> Backup agent version. </summary>
        public string AzureBackupAgentVersion { get; set; }
        /// <summary> To check if backup agent upgrade available. </summary>
        public bool? IsAzureBackupAgentUpgradeAvailable { get; set; }
        /// <summary> To check if backup engine upgrade available. </summary>
        public bool? IsDpmUpgradeAvailable { get; set; }
        /// <summary> Extended info of the backupengine. </summary>
        public BackupEngineExtendedInfo ExtendedInfo { get; set; }
    }
}
