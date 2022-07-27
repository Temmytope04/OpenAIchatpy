// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing the RoleEligibilityScheduleRequest data model. </summary>
    public partial class RoleEligibilityScheduleRequestData : ResourceData
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestData. </summary>
        public RoleEligibilityScheduleRequestData()
        {
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope">
        /// The role eligibility schedule request scope.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.scope
        /// </param>
        /// <param name="roleDefinitionId">
        /// The role definition ID.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.roleDefinitionId
        /// </param>
        /// <param name="principalId">
        /// The principal ID.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.principalId
        /// </param>
        /// <param name="principalType">
        /// The principal type of the assigned principal ID.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.principalType
        /// </param>
        /// <param name="requestType">
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.requestType
        /// </param>
        /// <param name="status">
        /// The status of the role eligibility schedule request.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.status
        /// </param>
        /// <param name="approvalId">
        /// The approvalId of the role eligibility schedule request.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.approvalId
        /// </param>
        /// <param name="scheduleInfo">
        /// Schedule info of the role eligibility schedule
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.scheduleInfo
        /// </param>
        /// <param name="targetRoleEligibilityScheduleId">
        /// The resultant role eligibility schedule id or the role eligibility schedule id being updated
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.targetRoleEligibilityScheduleId
        /// </param>
        /// <param name="targetRoleEligibilityScheduleInstanceId">
        /// The role eligibility schedule instance id being updated
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.targetRoleEligibilityScheduleInstanceId
        /// </param>
        /// <param name="justification">
        /// Justification for the role eligibility
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.justification
        /// </param>
        /// <param name="ticketInfo">
        /// Ticket Info of the role eligibility
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.ticketInfo
        /// </param>
        /// <param name="condition">
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.condition
        /// </param>
        /// <param name="conditionVersion">
        /// Version of the condition. Currently accepted value is &apos;2.0&apos;
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.conditionVersion
        /// </param>
        /// <param name="createdOn">
        /// DateTime when role eligibility schedule request was created
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.createdOn
        /// </param>
        /// <param name="requestorId">
        /// Id of the user who created this request
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.requestorId
        /// </param>
        /// <param name="expandedProperties">
        /// Additional properties of principal, scope and role definition
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.expandedProperties
        /// </param>
        internal RoleEligibilityScheduleRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, Guid? principalId, PrincipalType? principalType, RequestType? requestType, RoleEligibilityScheduleRequestStatus? status, string approvalId, RoleEligibilityScheduleRequestPropertiesScheduleInfo scheduleInfo, string targetRoleEligibilityScheduleId, string targetRoleEligibilityScheduleInstanceId, string justification, RoleEligibilityScheduleRequestPropertiesTicketInfo ticketInfo, string condition, string conditionVersion, DateTimeOffset? createdOn, Guid? requestorId, ExpandedProperties expandedProperties) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RequestType = requestType;
            Status = status;
            ApprovalId = approvalId;
            ScheduleInfo = scheduleInfo;
            TargetRoleEligibilityScheduleId = targetRoleEligibilityScheduleId;
            TargetRoleEligibilityScheduleInstanceId = targetRoleEligibilityScheduleInstanceId;
            Justification = justification;
            TicketInfo = ticketInfo;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            RequestorId = requestorId;
            ExpandedProperties = expandedProperties;
        }

        /// <summary>
        /// The role eligibility schedule request scope.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.scope
        /// </summary>
        public string Scope { get; }
        /// <summary>
        /// The role definition ID.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.roleDefinitionId
        /// </summary>
        public ResourceIdentifier RoleDefinitionId { get; set; }
        /// <summary>
        /// The principal ID.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.principalId
        /// </summary>
        public Guid? PrincipalId { get; set; }
        /// <summary>
        /// The principal type of the assigned principal ID.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.principalType
        /// </summary>
        public PrincipalType? PrincipalType { get; }
        /// <summary>
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.requestType
        /// </summary>
        public RequestType? RequestType { get; set; }
        /// <summary>
        /// The status of the role eligibility schedule request.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.status
        /// </summary>
        public RoleEligibilityScheduleRequestStatus? Status { get; }
        /// <summary>
        /// The approvalId of the role eligibility schedule request.
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.approvalId
        /// </summary>
        public string ApprovalId { get; }
        /// <summary>
        /// Schedule info of the role eligibility schedule
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.scheduleInfo
        /// </summary>
        public RoleEligibilityScheduleRequestPropertiesScheduleInfo ScheduleInfo { get; set; }
        /// <summary>
        /// The resultant role eligibility schedule id or the role eligibility schedule id being updated
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.targetRoleEligibilityScheduleId
        /// </summary>
        public string TargetRoleEligibilityScheduleId { get; set; }
        /// <summary>
        /// The role eligibility schedule instance id being updated
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.targetRoleEligibilityScheduleInstanceId
        /// </summary>
        public string TargetRoleEligibilityScheduleInstanceId { get; set; }
        /// <summary>
        /// Justification for the role eligibility
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.justification
        /// </summary>
        public string Justification { get; set; }
        /// <summary>
        /// Ticket Info of the role eligibility
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.ticketInfo
        /// </summary>
        public RoleEligibilityScheduleRequestPropertiesTicketInfo TicketInfo { get; set; }
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.condition
        /// </summary>
        public string Condition { get; set; }
        /// <summary>
        /// Version of the condition. Currently accepted value is &apos;2.0&apos;
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.conditionVersion
        /// </summary>
        public string ConditionVersion { get; set; }
        /// <summary>
        /// DateTime when role eligibility schedule request was created
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.createdOn
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// Id of the user who created this request
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.requestorId
        /// </summary>
        public Guid? RequestorId { get; }
        /// <summary>
        /// Additional properties of principal, scope and role definition
        /// Serialized Name: RoleEligibilityScheduleRequest.properties.expandedProperties
        /// </summary>
        public ExpandedProperties ExpandedProperties { get; }
    }
}
