// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> This is used to represent the various nodes of the distributed container. </summary>
    public partial class DistributedNodesInfo
    {
        /// <summary> Initializes a new instance of DistributedNodesInfo. </summary>
        public DistributedNodesInfo()
        {
        }

        /// <summary> Initializes a new instance of DistributedNodesInfo. </summary>
        /// <param name="nodeName"> Name of the node under a distributed container. </param>
        /// <param name="status">
        /// Status of this Node.
        /// Failed | Succeeded
        /// </param>
        /// <param name="errorDetail"> Error Details if the Status is non-success. </param>
        /// <param name="sourceResourceId"> ARM resource id of the node. </param>
        internal DistributedNodesInfo(string nodeName, string status, BackupErrorDetail errorDetail, string sourceResourceId)
        {
            NodeName = nodeName;
            Status = status;
            ErrorDetail = errorDetail;
            SourceResourceId = sourceResourceId;
        }

        /// <summary> Name of the node under a distributed container. </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// Status of this Node.
        /// Failed | Succeeded
        /// </summary>
        public string Status { get; set; }
        /// <summary> Error Details if the Status is non-success. </summary>
        public BackupErrorDetail ErrorDetail { get; set; }
        /// <summary> ARM resource id of the node. </summary>
        public string SourceResourceId { get; set; }
    }
}
