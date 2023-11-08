// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role definition. </summary>
    public partial class KeyVaultRoleDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleDefinition"/>. </summary>
        public KeyVaultRoleDefinition()
        {
            Permissions = new ChangeTrackingList<KeyVaultPermission>();
            AssignableScopes = new ChangeTrackingList<KeyVaultRoleScope>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleDefinition"/>. </summary>
        /// <param name="id"> The role definition ID. </param>
        /// <param name="name"> The role definition name. </param>
        /// <param name="type"> The role definition type. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="description"> The role definition description. </param>
        /// <param name="roleType"> The role type. </param>
        /// <param name="permissions"> Role definition permissions. </param>
        /// <param name="assignableScopes"> Role definition assignable scopes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultRoleDefinition(string id, string name, KeyVaultRoleDefinitionType? type, string roleName, string description, KeyVaultRoleType? roleType, IList<KeyVaultPermission> permissions, IList<KeyVaultRoleScope> assignableScopes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Type = type;
            RoleName = roleName;
            Description = description;
            RoleType = roleType;
            Permissions = permissions;
            AssignableScopes = assignableScopes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The role definition ID. </summary>
        public string Id { get; }
        /// <summary> The role definition name. </summary>
        public string Name { get; }
        /// <summary> The role definition type. </summary>
        public KeyVaultRoleDefinitionType? Type { get; }
        /// <summary> The role name. </summary>
        public string RoleName { get; set; }
        /// <summary> The role definition description. </summary>
        public string Description { get; set; }
        /// <summary> The role type. </summary>
        public KeyVaultRoleType? RoleType { get; set; }
        /// <summary> Role definition permissions. </summary>
        public IList<KeyVaultPermission> Permissions { get; }
        /// <summary> Role definition assignable scopes. </summary>
        public IList<KeyVaultRoleScope> AssignableScopes { get; }
    }
}
