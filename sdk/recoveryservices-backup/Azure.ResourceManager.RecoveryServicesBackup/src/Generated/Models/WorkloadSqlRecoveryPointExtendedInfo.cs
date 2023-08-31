// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Extended info class details. </summary>
    public partial class WorkloadSqlRecoveryPointExtendedInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadSqlRecoveryPointExtendedInfo"/>. </summary>
        public WorkloadSqlRecoveryPointExtendedInfo()
        {
            DataDirectoryPaths = new ChangeTrackingList<SqlDataDirectory>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadSqlRecoveryPointExtendedInfo"/>. </summary>
        /// <param name="dataDirectoryInfoCapturedOn"> UTC time at which data directory info was captured. </param>
        /// <param name="dataDirectoryPaths"> List of data directory paths during restore operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadSqlRecoveryPointExtendedInfo(DateTimeOffset? dataDirectoryInfoCapturedOn, IList<SqlDataDirectory> dataDirectoryPaths, Dictionary<string, BinaryData> rawData)
        {
            DataDirectoryInfoCapturedOn = dataDirectoryInfoCapturedOn;
            DataDirectoryPaths = dataDirectoryPaths;
            _rawData = rawData;
        }

        /// <summary> UTC time at which data directory info was captured. </summary>
        public DateTimeOffset? DataDirectoryInfoCapturedOn { get; set; }
        /// <summary> List of data directory paths during restore operation. </summary>
        public IList<SqlDataDirectory> DataDirectoryPaths { get; }
    }
}
