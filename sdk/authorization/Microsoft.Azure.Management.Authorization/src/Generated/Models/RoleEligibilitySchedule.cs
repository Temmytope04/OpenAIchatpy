// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role eligibility schedule
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoleEligibilitySchedule
    {
        /// <summary>
        /// Initializes a new instance of the RoleEligibilitySchedule class.
        /// </summary>
        public RoleEligibilitySchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleEligibilitySchedule class.
        /// </summary>
        /// <param name="id">The role eligibility schedule Id.</param>
        /// <param name="name">The role eligibility schedule name.</param>
        /// <param name="type">The role eligibility schedule type.</param>
        /// <param name="scope">The role eligibility schedule scope.</param>
        /// <param name="roleDefinitionId">The role definition ID.</param>
        /// <param name="principalId">The principal ID.</param>
        /// <param name="principalType">The principal type of the assigned
        /// principal ID. Possible values include: 'User', 'Group',
        /// 'ServicePrincipal', 'ForeignGroup'</param>
        /// <param name="roleEligibilityScheduleRequestId">The id of
        /// roleEligibilityScheduleRequest used to create this
        /// roleAssignmentSchedule</param>
        /// <param name="memberType">Membership type of the role eligibility
        /// schedule. Possible values include: 'Inherited', 'Direct',
        /// 'Group'</param>
        /// <param name="status">The status of the role eligibility schedule.
        /// Possible values include: 'Accepted', 'PendingEvaluation',
        /// 'Granted', 'Denied', 'PendingProvisioning', 'Provisioned',
        /// 'PendingRevocation', 'Revoked', 'Canceled', 'Failed',
        /// 'PendingApprovalProvisioning', 'PendingApproval',
        /// 'FailedAsResourceIsLocked', 'PendingAdminDecision',
        /// 'AdminApproved', 'AdminDenied', 'TimedOut', 'ProvisioningStarted',
        /// 'Invalid', 'PendingScheduleCreation', 'ScheduleCreated',
        /// 'PendingExternalProvisioning'</param>
        /// <param name="startDateTime">Start DateTime when role eligibility
        /// schedule</param>
        /// <param name="endDateTime">End DateTime when role eligibility
        /// schedule</param>
        /// <param name="condition">The conditions on the role assignment. This
        /// limits the resources it can be assigned to. e.g.:
        /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'</param>
        /// <param name="conditionVersion">Version of the condition. Currently
        /// accepted value is '2.0'</param>
        /// <param name="createdOn">DateTime when role eligibility schedule was
        /// created</param>
        /// <param name="updatedOn">DateTime when role eligibility schedule was
        /// modified</param>
        /// <param name="expandedProperties">Additional properties of
        /// principal, scope and role definition</param>
        public RoleEligibilitySchedule(string id = default(string), string name = default(string), string type = default(string), string scope = default(string), string roleDefinitionId = default(string), string principalId = default(string), string principalType = default(string), string roleEligibilityScheduleRequestId = default(string), string memberType = default(string), string status = default(string), System.DateTime? startDateTime = default(System.DateTime?), System.DateTime? endDateTime = default(System.DateTime?), string condition = default(string), string conditionVersion = default(string), System.DateTime? createdOn = default(System.DateTime?), System.DateTime? updatedOn = default(System.DateTime?), ExpandedProperties expandedProperties = default(ExpandedProperties))
        {
            Id = id;
            Name = name;
            Type = type;
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RoleEligibilityScheduleRequestId = roleEligibilityScheduleRequestId;
            MemberType = memberType;
            Status = status;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ExpandedProperties = expandedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the role eligibility schedule Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the role eligibility schedule name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the role eligibility schedule type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the role eligibility schedule scope.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the role definition ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the principal ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the principal type of the assigned principal ID.
        /// Possible values include: 'User', 'Group', 'ServicePrincipal',
        /// 'ForeignGroup'
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalType")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// Gets or sets the id of roleEligibilityScheduleRequest used to
        /// create this roleAssignmentSchedule
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleEligibilityScheduleRequestId")]
        public string RoleEligibilityScheduleRequestId { get; set; }

        /// <summary>
        /// Gets or sets membership type of the role eligibility schedule.
        /// Possible values include: 'Inherited', 'Direct', 'Group'
        /// </summary>
        [JsonProperty(PropertyName = "properties.memberType")]
        public string MemberType { get; set; }

        /// <summary>
        /// Gets or sets the status of the role eligibility schedule. Possible
        /// values include: 'Accepted', 'PendingEvaluation', 'Granted',
        /// 'Denied', 'PendingProvisioning', 'Provisioned',
        /// 'PendingRevocation', 'Revoked', 'Canceled', 'Failed',
        /// 'PendingApprovalProvisioning', 'PendingApproval',
        /// 'FailedAsResourceIsLocked', 'PendingAdminDecision',
        /// 'AdminApproved', 'AdminDenied', 'TimedOut', 'ProvisioningStarted',
        /// 'Invalid', 'PendingScheduleCreation', 'ScheduleCreated',
        /// 'PendingExternalProvisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets start DateTime when role eligibility schedule
        /// </summary>
        [JsonProperty(PropertyName = "properties.startDateTime")]
        public System.DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets end DateTime when role eligibility schedule
        /// </summary>
        [JsonProperty(PropertyName = "properties.endDateTime")]
        public System.DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the conditions on the role assignment. This limits the
        /// resources it can be assigned to. e.g.:
        /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [JsonProperty(PropertyName = "properties.condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets version of the condition. Currently accepted value is
        /// '2.0'
        /// </summary>
        [JsonProperty(PropertyName = "properties.conditionVersion")]
        public string ConditionVersion { get; set; }

        /// <summary>
        /// Gets or sets dateTime when role eligibility schedule was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdOn")]
        public System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets dateTime when role eligibility schedule was modified
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedOn")]
        public System.DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets additional properties of principal, scope and role
        /// definition
        /// </summary>
        [JsonProperty(PropertyName = "properties.expandedProperties")]
        public ExpandedProperties ExpandedProperties { get; set; }

    }
}
