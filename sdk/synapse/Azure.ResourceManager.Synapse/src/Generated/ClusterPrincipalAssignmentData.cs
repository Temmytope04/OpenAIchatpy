// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the ClusterPrincipalAssignment data model. </summary>
    public partial class ClusterPrincipalAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of ClusterPrincipalAssignmentData. </summary>
        public ClusterPrincipalAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of ClusterPrincipalAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="principalId"> The principal ID assigned to the cluster principal. It can be a user email, application ID, or security group name. </param>
        /// <param name="role"> Cluster principal role. </param>
        /// <param name="tenantId"> The tenant id of the principal. </param>
        /// <param name="principalType"> Principal type. </param>
        /// <param name="tenantName"> The tenant name of the principal. </param>
        /// <param name="principalName"> The principal name. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="aadObjectId"> The service principal object id in AAD (Azure active directory). </param>
        internal ClusterPrincipalAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string principalId, ClusterPrincipalRole? role, Guid? tenantId, PrincipalType? principalType, string tenantName, string principalName, ResourceProvisioningState? provisioningState, string aadObjectId) : base(id, name, resourceType, systemData)
        {
            PrincipalId = principalId;
            Role = role;
            TenantId = tenantId;
            PrincipalType = principalType;
            TenantName = tenantName;
            PrincipalName = principalName;
            ProvisioningState = provisioningState;
            AadObjectId = aadObjectId;
        }

        /// <summary> The principal ID assigned to the cluster principal. It can be a user email, application ID, or security group name. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Cluster principal role. </summary>
        public ClusterPrincipalRole? Role { get; set; }
        /// <summary> The tenant id of the principal. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Principal type. </summary>
        public PrincipalType? PrincipalType { get; set; }
        /// <summary> The tenant name of the principal. </summary>
        public string TenantName { get; }
        /// <summary> The principal name. </summary>
        public string PrincipalName { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The service principal object id in AAD (Azure active directory). </summary>
        public string AadObjectId { get; }
    }
}
