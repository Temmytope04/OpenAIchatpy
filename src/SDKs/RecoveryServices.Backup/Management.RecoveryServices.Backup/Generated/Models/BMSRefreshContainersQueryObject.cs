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
    using System.Linq;

    /// <summary>
    /// The query filters that can be used with the refresh container API.
    /// </summary>
    public partial class BMSRefreshContainersQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSRefreshContainersQueryObject
        /// class.
        /// </summary>
        public BMSRefreshContainersQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BMSRefreshContainersQueryObject
        /// class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type for this
        /// container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        public BMSRefreshContainersQueryObject(BackupManagementType? backupManagementType = default(BackupManagementType?))
        {
            BackupManagementType = backupManagementType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup management type for this container. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
        /// 'DefaultBackup'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public BackupManagementType? BackupManagementType { get; set; }

    }
}
