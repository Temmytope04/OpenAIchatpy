// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary>
    /// Role assignment properties with scope.
    /// Serialized Name: RoleAssignmentPropertiesWithScope
    /// </summary>
    public partial class RoleAssignmentPropertiesWithScope
    {
        /// <summary> Initializes a new instance of RoleAssignmentPropertiesWithScope. </summary>
        internal RoleAssignmentPropertiesWithScope()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentPropertiesWithScope. </summary>
        /// <param name="scope">
        /// The role assignment scope.
        /// Serialized Name: RoleAssignmentPropertiesWithScope.scope
        /// </param>
        /// <param name="roleDefinitionId">
        /// The role definition ID.
        /// Serialized Name: RoleAssignmentPropertiesWithScope.roleDefinitionId
        /// </param>
        /// <param name="principalId">
        /// The principal ID.
        /// Serialized Name: RoleAssignmentPropertiesWithScope.principalId
        /// </param>
        internal RoleAssignmentPropertiesWithScope(string scope, ResourceIdentifier roleDefinitionId, Guid? principalId)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        /// <summary>
        /// The role assignment scope.
        /// Serialized Name: RoleAssignmentPropertiesWithScope.scope
        /// </summary>
        public string Scope { get; }
        /// <summary>
        /// The role definition ID.
        /// Serialized Name: RoleAssignmentPropertiesWithScope.roleDefinitionId
        /// </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary>
        /// The principal ID.
        /// Serialized Name: RoleAssignmentPropertiesWithScope.principalId
        /// </summary>
        public Guid? PrincipalId { get; }
    }
}
