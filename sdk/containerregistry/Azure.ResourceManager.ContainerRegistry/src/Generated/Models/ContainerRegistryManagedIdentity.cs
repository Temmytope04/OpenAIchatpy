// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Managed identity for the resource. </summary>
    public partial class ContainerRegistryManagedIdentity
    {
        /// <summary> Initializes a new instance of ContainerRegistryManagedIdentity. </summary>
        public ContainerRegistryManagedIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserIdentityProperties>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryManagedIdentity. </summary>
        /// <param name="principalId"> The principal ID of resource identity. </param>
        /// <param name="tenantId"> The tenant ID of resource. </param>
        /// <param name="identityType"> The identity type. </param>
        /// <param name="userAssignedIdentities">
        /// The list of user identities associated with the resource. The user identity 
        /// dictionary key references will be ARM resource ids in the form: 
        /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        ///     providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
        /// </param>
        internal ContainerRegistryManagedIdentity(Guid? principalId, Guid? tenantId, ContainerRegistryManagedIdentityType? identityType, IDictionary<string, UserIdentityProperties> userAssignedIdentities)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            IdentityType = identityType;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The principal ID of resource identity. </summary>
        public Guid? PrincipalId { get; set; }
        /// <summary> The tenant ID of resource. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> The identity type. </summary>
        public ContainerRegistryManagedIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity 
        /// dictionary key references will be ARM resource ids in the form: 
        /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        ///     providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
        /// </summary>
        public IDictionary<string, UserIdentityProperties> UserAssignedIdentities { get; }
    }
}
