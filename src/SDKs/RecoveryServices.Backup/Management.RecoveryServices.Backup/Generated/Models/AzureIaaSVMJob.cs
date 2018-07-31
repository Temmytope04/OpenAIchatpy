// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure IaaS VM workload-specifc job object.
    /// </summary>
    public partial class AzureIaaSVMJob : Job
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJob class.
        /// </summary>
        public AzureIaaSVMJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJob class.
        /// </summary>
        /// <param name="entityFriendlyName">Friendly name of the entity on
        /// which the current job is executing.</param>
        /// <param name="backupManagementType">Backup management type to
        /// execute the current job. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="status">Job status.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="activityId">ActivityId of job.</param>
        /// <param name="duration">Time elapsed during the execution of this
        /// job.</param>
        /// <param name="actionsInfo">Gets or sets the state/actions applicable
        /// on this job like cancel/retry.</param>
        /// <param name="errorDetails">Error details on execution of this
        /// job.</param>
        /// <param name="virtualMachineVersion">Specifies whether the backup
        /// item is a Classic or an Azure Resource Manager VM.</param>
        /// <param name="extendedInfo">Additional information for this
        /// job.</param>
        public AzureIaaSVMJob(string entityFriendlyName = default(string), BackupManagementType? backupManagementType = default(BackupManagementType?), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), IList<JobSupportedAction?> actionsInfo = default(IList<JobSupportedAction?>), IList<AzureIaaSVMErrorInfo> errorDetails = default(IList<AzureIaaSVMErrorInfo>), string virtualMachineVersion = default(string), AzureIaaSVMJobExtendedInfo extendedInfo = default(AzureIaaSVMJobExtendedInfo))
            : base(entityFriendlyName, backupManagementType, operation, status, startTime, endTime, activityId)
        {
            Duration = duration;
            ActionsInfo = actionsInfo;
            ErrorDetails = errorDetails;
            VirtualMachineVersion = virtualMachineVersion;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time elapsed during the execution of this job.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the state/actions applicable on this job like
        /// cancel/retry.
        /// </summary>
        [JsonProperty(PropertyName = "actionsInfo")]
        public IList<JobSupportedAction?> ActionsInfo { get; set; }

        /// <summary>
        /// Gets or sets error details on execution of this job.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<AzureIaaSVMErrorInfo> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the backup item is a Classic or an
        /// Azure Resource Manager VM.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineVersion")]
        public string VirtualMachineVersion { get; set; }

        /// <summary>
        /// Gets or sets additional information for this job.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public AzureIaaSVMJobExtendedInfo ExtendedInfo { get; set; }

    }
}
