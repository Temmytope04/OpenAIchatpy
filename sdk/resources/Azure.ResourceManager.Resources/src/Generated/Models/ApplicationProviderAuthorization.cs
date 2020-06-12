// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The managed application provider authorization. </summary>
    public partial class ApplicationProviderAuthorization
    {
        /// <summary> Initializes a new instance of ApplicationProviderAuthorization. </summary>
        /// <param name="principalId"> The provider&apos;s principal identifier. This is the identity that the provider will use to call ARM to manage the managed application resources. </param>
        /// <param name="roleDefinitionId"> The provider&apos;s role definition identifier. This role will define all the permissions that the provider must have on the managed application&apos;s container resource group. This role definition cannot have permission to delete the resource group. </param>
        public ApplicationProviderAuthorization(string principalId, string roleDefinitionId)
        {
            if (principalId == null)
            {
                throw new ArgumentNullException(nameof(principalId));
            }
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> The provider&apos;s principal identifier. This is the identity that the provider will use to call ARM to manage the managed application resources. </summary>
        public string PrincipalId { get; set; }
        /// <summary> The provider&apos;s role definition identifier. This role will define all the permissions that the provider must have on the managed application&apos;s container resource group. This role definition cannot have permission to delete the resource group. </summary>
        public string RoleDefinitionId { get; set; }
    }
}
