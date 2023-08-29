// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> DPM workload-specific job object. </summary>
    public partial class DpmBackupJob : BackupGenericJob
    {
        /// <summary> Initializes a new instance of <see cref="DpmBackupJob"/>. </summary>
        public DpmBackupJob()
        {
            ActionsInfo = new ChangeTrackingList<JobSupportedAction>();
            ErrorDetails = new ChangeTrackingList<DpmErrorInfo>();
            JobType = "DpmJob";
        }

        /// <summary> Initializes a new instance of <see cref="DpmBackupJob"/>. </summary>
        /// <param name="entityFriendlyName"> Friendly name of the entity on which the current job is executing. </param>
        /// <param name="backupManagementType"> Backup management type to execute the current job. </param>
        /// <param name="operation"> The operation name. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="activityId"> ActivityId of job. </param>
        /// <param name="jobType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="duration"> Time elapsed for job. </param>
        /// <param name="dpmServerName"> DPM server name managing the backup item or backup job. </param>
        /// <param name="containerName"> Name of cluster/server protecting current backup item, if any. </param>
        /// <param name="containerType"> Type of container. </param>
        /// <param name="workloadType"> Type of backup item. </param>
        /// <param name="actionsInfo"> The state/actions applicable on this job like cancel/retry. </param>
        /// <param name="errorDetails"> The errors. </param>
        /// <param name="extendedInfo"> Additional information for this job. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DpmBackupJob(string entityFriendlyName, BackupManagementType? backupManagementType, string operation, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, string activityId, string jobType, TimeSpan? duration, string dpmServerName, string containerName, string containerType, string workloadType, IList<JobSupportedAction> actionsInfo, IList<DpmErrorInfo> errorDetails, DpmBackupJobExtendedInfo extendedInfo, Dictionary<string, BinaryData> rawData) : base(entityFriendlyName, backupManagementType, operation, status, startOn, endOn, activityId, jobType, rawData)
        {
            Duration = duration;
            DpmServerName = dpmServerName;
            ContainerName = containerName;
            ContainerType = containerType;
            WorkloadType = workloadType;
            ActionsInfo = actionsInfo;
            ErrorDetails = errorDetails;
            ExtendedInfo = extendedInfo;
            JobType = jobType ?? "DpmJob";
        }

        /// <summary> Time elapsed for job. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> DPM server name managing the backup item or backup job. </summary>
        public string DpmServerName { get; set; }
        /// <summary> Name of cluster/server protecting current backup item, if any. </summary>
        public string ContainerName { get; set; }
        /// <summary> Type of container. </summary>
        public string ContainerType { get; set; }
        /// <summary> Type of backup item. </summary>
        public string WorkloadType { get; set; }
        /// <summary> The state/actions applicable on this job like cancel/retry. </summary>
        public IList<JobSupportedAction> ActionsInfo { get; }
        /// <summary> The errors. </summary>
        public IList<DpmErrorInfo> ErrorDetails { get; }
        /// <summary> Additional information for this job. </summary>
        public DpmBackupJobExtendedInfo ExtendedInfo { get; set; }
    }
}
