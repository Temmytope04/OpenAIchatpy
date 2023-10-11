// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing the CostManagementAlert data model.
    /// An individual alert.
    /// </summary>
    public partial class CostManagementAlertData : ResourceData
    {
        /// <summary> Initializes a new instance of CostManagementAlertData. </summary>
        public CostManagementAlertData()
        {
        }

        /// <summary> Initializes a new instance of CostManagementAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="definition"> defines the type of alert. </param>
        /// <param name="description"> Alert description. </param>
        /// <param name="source"> Source of alert. </param>
        /// <param name="details"> Alert details. </param>
        /// <param name="costEntityId"> related budget. </param>
        /// <param name="status"> alert status. </param>
        /// <param name="createdOn"> dateTime in which alert was created. </param>
        /// <param name="closeOn"> dateTime in which alert was closed. </param>
        /// <param name="modifiedOn"> dateTime in which alert was last modified. </param>
        /// <param name="statusModificationUserName"> User who last modified the alert. </param>
        /// <param name="statusModifiedOn"> dateTime in which the alert status was last modified. </param>
        /// <param name="eTag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        internal CostManagementAlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertPropertiesDefinition definition, string description, CostManagementAlertSource? source, AlertPropertiesDetails details, string costEntityId, CostManagementAlertStatus? status, DateTimeOffset? createdOn, DateTimeOffset? closeOn, DateTimeOffset? modifiedOn, string statusModificationUserName, DateTimeOffset? statusModifiedOn, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Definition = definition;
            Description = description;
            Source = source;
            Details = details;
            CostEntityId = costEntityId;
            Status = status;
            CreatedOn = createdOn;
            CloseOn = closeOn;
            ModifiedOn = modifiedOn;
            StatusModificationUserName = statusModificationUserName;
            StatusModifiedOn = statusModifiedOn;
            ETag = eTag;
        }

        /// <summary> defines the type of alert. </summary>
        public AlertPropertiesDefinition Definition { get; set; }
        /// <summary> Alert description. </summary>
        public string Description { get; set; }
        /// <summary> Source of alert. </summary>
        public CostManagementAlertSource? Source { get; set; }
        /// <summary> Alert details. </summary>
        public AlertPropertiesDetails Details { get; set; }
        /// <summary> related budget. </summary>
        public string CostEntityId { get; set; }
        /// <summary> alert status. </summary>
        public CostManagementAlertStatus? Status { get; set; }
        /// <summary> dateTime in which alert was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> dateTime in which alert was closed. </summary>
        public DateTimeOffset? CloseOn { get; set; }
        /// <summary> dateTime in which alert was last modified. </summary>
        public DateTimeOffset? ModifiedOn { get; set; }
        /// <summary> User who last modified the alert. </summary>
        public string StatusModificationUserName { get; set; }
        /// <summary> dateTime in which the alert status was last modified. </summary>
        public DateTimeOffset? StatusModifiedOn { get; set; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
