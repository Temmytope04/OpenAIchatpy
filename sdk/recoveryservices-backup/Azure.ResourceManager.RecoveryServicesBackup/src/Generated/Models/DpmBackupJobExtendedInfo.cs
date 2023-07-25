// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information on the DPM workload-specific job. </summary>
    public partial class DpmBackupJobExtendedInfo
    {
        /// <summary> Initializes a new instance of DpmBackupJobExtendedInfo. </summary>
        public DpmBackupJobExtendedInfo()
        {
            TasksList = new ChangeTrackingList<DpmBackupJobTaskDetails>();
            PropertyBag = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DpmBackupJobExtendedInfo. </summary>
        /// <param name="tasksList"> List of tasks associated with this job. </param>
        /// <param name="propertyBag"> The job properties. </param>
        /// <param name="dynamicErrorMessage"> Non localized error message on job execution. </param>
        internal DpmBackupJobExtendedInfo(IList<DpmBackupJobTaskDetails> tasksList, IDictionary<string, string> propertyBag, string dynamicErrorMessage)
        {
            TasksList = tasksList;
            PropertyBag = propertyBag;
            DynamicErrorMessage = dynamicErrorMessage;
        }

        /// <summary> List of tasks associated with this job. </summary>
        public IList<DpmBackupJobTaskDetails> TasksList { get; }
        /// <summary> The job properties. </summary>
        public IDictionary<string, string> PropertyBag { get; }
        /// <summary> Non localized error message on job execution. </summary>
        public string DynamicErrorMessage { get; set; }
    }
}
