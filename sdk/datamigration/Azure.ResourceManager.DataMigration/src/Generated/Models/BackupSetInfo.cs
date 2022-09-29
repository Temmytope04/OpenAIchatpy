// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Information of backup set. </summary>
    public partial class BackupSetInfo
    {
        /// <summary> Initializes a new instance of BackupSetInfo. </summary>
        internal BackupSetInfo()
        {
            ListOfBackupFiles = new ChangeTrackingList<BackupFileInfo>();
        }

        /// <summary> Initializes a new instance of BackupSetInfo. </summary>
        /// <param name="backupSetId"> Id for the set of backup files. </param>
        /// <param name="firstLsn"> First log sequence number of the backup file. </param>
        /// <param name="lastLsn"> Last log sequence number of the backup file. </param>
        /// <param name="lastModifiedOn"> Last modified time of the backup file in share location. </param>
        /// <param name="backupType"> Enum of the different backup types. </param>
        /// <param name="listOfBackupFiles"> List of files in the backup set. </param>
        /// <param name="databaseName"> Name of the database to which the backup set belongs. </param>
        /// <param name="backupStartOn"> Date and time that the backup operation began. </param>
        /// <param name="backupFinishedOn"> Date and time that the backup operation finished. </param>
        /// <param name="isBackupRestored"> Whether the backup set is restored or not. </param>
        internal BackupSetInfo(string backupSetId, string firstLsn, string lastLsn, DateTimeOffset? lastModifiedOn, BackupType? backupType, IReadOnlyList<BackupFileInfo> listOfBackupFiles, string databaseName, DateTimeOffset? backupStartOn, DateTimeOffset? backupFinishedOn, bool? isBackupRestored)
        {
            BackupSetId = backupSetId;
            FirstLsn = firstLsn;
            LastLsn = lastLsn;
            LastModifiedOn = lastModifiedOn;
            BackupType = backupType;
            ListOfBackupFiles = listOfBackupFiles;
            DatabaseName = databaseName;
            BackupStartOn = backupStartOn;
            BackupFinishedOn = backupFinishedOn;
            IsBackupRestored = isBackupRestored;
        }

        /// <summary> Id for the set of backup files. </summary>
        public string BackupSetId { get; }
        /// <summary> First log sequence number of the backup file. </summary>
        public string FirstLsn { get; }
        /// <summary> Last log sequence number of the backup file. </summary>
        public string LastLsn { get; }
        /// <summary> Last modified time of the backup file in share location. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Enum of the different backup types. </summary>
        public BackupType? BackupType { get; }
        /// <summary> List of files in the backup set. </summary>
        public IReadOnlyList<BackupFileInfo> ListOfBackupFiles { get; }
        /// <summary> Name of the database to which the backup set belongs. </summary>
        public string DatabaseName { get; }
        /// <summary> Date and time that the backup operation began. </summary>
        public DateTimeOffset? BackupStartOn { get; }
        /// <summary> Date and time that the backup operation finished. </summary>
        public DateTimeOffset? BackupFinishedOn { get; }
        /// <summary> Whether the backup set is restored or not. </summary>
        public bool? IsBackupRestored { get; }
    }
}
