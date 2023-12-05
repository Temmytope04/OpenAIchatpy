// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Response for the LTR backup API call. </summary>
    public partial class PostgreSqlFlexibleServerLtrBackupResult
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLtrBackupResult"/>. </summary>
        internal PostgreSqlFlexibleServerLtrBackupResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLtrBackupResult"/>. </summary>
        /// <param name="datasourceSizeInBytes"> Size of datasource in bytes. </param>
        /// <param name="dataTransferredInBytes"> Data transferred in bytes. </param>
        /// <param name="backupName"> Name of Backup operation. </param>
        /// <param name="backupMetadata"> Metadata to be stored in RP. Store everything that will be required to perform a successful restore using this Recovery point. e.g. Versions, DataFormat etc. </param>
        /// <param name="status"> Service-set extensible enum indicating the status of operation. </param>
        /// <param name="startOn"> Start time of the operation. </param>
        /// <param name="endOn"> End time of the operation. </param>
        /// <param name="percentComplete"> PercentageCompleted. </param>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorMessage"> The error message. </param>
        internal PostgreSqlFlexibleServerLtrBackupResult(long? datasourceSizeInBytes, long? dataTransferredInBytes, string backupName, string backupMetadata, PostgreSqlExecutionStatus? status, DateTimeOffset? startOn, DateTimeOffset? endOn, double? percentComplete, string errorCode, string errorMessage)
        {
            DatasourceSizeInBytes = datasourceSizeInBytes;
            DataTransferredInBytes = dataTransferredInBytes;
            BackupName = backupName;
            BackupMetadata = backupMetadata;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            PercentComplete = percentComplete;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        /// <summary> Size of datasource in bytes. </summary>
        public long? DatasourceSizeInBytes { get; }
        /// <summary> Data transferred in bytes. </summary>
        public long? DataTransferredInBytes { get; }
        /// <summary> Name of Backup operation. </summary>
        public string BackupName { get; }
        /// <summary> Metadata to be stored in RP. Store everything that will be required to perform a successful restore using this Recovery point. e.g. Versions, DataFormat etc. </summary>
        public string BackupMetadata { get; }
        /// <summary> Service-set extensible enum indicating the status of operation. </summary>
        public PostgreSqlExecutionStatus? Status { get; }
        /// <summary> Start time of the operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of the operation. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> PercentageCompleted. </summary>
        public double? PercentComplete { get; }
        /// <summary> The error code. </summary>
        public string ErrorCode { get; }
        /// <summary> The error message. </summary>
        public string ErrorMessage { get; }
    }
}
