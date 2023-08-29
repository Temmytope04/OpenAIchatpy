// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing the StorageSyncWorkflow data model.
    /// Workflow resource.
    /// </summary>
    public partial class StorageSyncWorkflowData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageSyncWorkflowData"/>. </summary>
        public StorageSyncWorkflowData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncWorkflowData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastStepName"> last step name. </param>
        /// <param name="status"> workflow status. </param>
        /// <param name="operation"> operation direction. </param>
        /// <param name="steps"> workflow steps. </param>
        /// <param name="lastOperationId"> workflow last operation identifier. </param>
        /// <param name="commandName"> workflow command name. </param>
        /// <param name="createdOn"> workflow created timestamp. </param>
        /// <param name="lastStatusUpdatedOn"> workflow last status timestamp. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSyncWorkflowData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string lastStepName, StorageSyncWorkflowStatus? status, StorageSyncOperationDirection? operation, string steps, Guid? lastOperationId, string commandName, DateTimeOffset? createdOn, DateTimeOffset? lastStatusUpdatedOn, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            LastStepName = lastStepName;
            Status = status;
            Operation = operation;
            Steps = steps;
            LastOperationId = lastOperationId;
            CommandName = commandName;
            CreatedOn = createdOn;
            LastStatusUpdatedOn = lastStatusUpdatedOn;
            _rawData = rawData;
        }

        /// <summary> last step name. </summary>
        public string LastStepName { get; set; }
        /// <summary> workflow status. </summary>
        public StorageSyncWorkflowStatus? Status { get; set; }
        /// <summary> operation direction. </summary>
        public StorageSyncOperationDirection? Operation { get; set; }
        /// <summary> workflow steps. </summary>
        public string Steps { get; set; }
        /// <summary> workflow last operation identifier. </summary>
        public Guid? LastOperationId { get; set; }
        /// <summary> workflow command name. </summary>
        public string CommandName { get; }
        /// <summary> workflow created timestamp. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> workflow last status timestamp. </summary>
        public DateTimeOffset? LastStatusUpdatedOn { get; }
    }
}
