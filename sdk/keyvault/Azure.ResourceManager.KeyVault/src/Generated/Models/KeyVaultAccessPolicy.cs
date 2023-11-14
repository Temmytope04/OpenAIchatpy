// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> An identity that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. </summary>
    public partial class KeyVaultAccessPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultAccessPolicy"/>. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </param>
        /// <param name="objectId"> The object ID of a user, service principal or security group in the Azure Active Directory tenant for the vault. The object ID must be unique for the list of access policies. </param>
        /// <param name="permissions"> Permissions the identity has for keys, secrets and certificates. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> or <paramref name="permissions"/> is null. </exception>
        public KeyVaultAccessPolicy(Guid tenantId, string objectId, IdentityAccessPermissions permissions)
        {
            Argument.AssertNotNull(objectId, nameof(objectId));
            Argument.AssertNotNull(permissions, nameof(permissions));

            TenantId = tenantId;
            ObjectId = objectId;
            Permissions = permissions;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultAccessPolicy"/>. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </param>
        /// <param name="objectId"> The object ID of a user, service principal or security group in the Azure Active Directory tenant for the vault. The object ID must be unique for the list of access policies. </param>
        /// <param name="applicationId"> Application ID of the client making request on behalf of a principal. </param>
        /// <param name="permissions"> Permissions the identity has for keys, secrets and certificates. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultAccessPolicy(Guid tenantId, string objectId, Guid? applicationId, IdentityAccessPermissions permissions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TenantId = tenantId;
            ObjectId = objectId;
            ApplicationId = applicationId;
            Permissions = permissions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultAccessPolicy"/> for deserialization. </summary>
        internal KeyVaultAccessPolicy()
        {
        }

        /// <summary> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </summary>
        public Guid TenantId { get; set; }
        /// <summary> The object ID of a user, service principal or security group in the Azure Active Directory tenant for the vault. The object ID must be unique for the list of access policies. </summary>
        public string ObjectId { get; set; }
        /// <summary> Application ID of the client making request on behalf of a principal. </summary>
        public Guid? ApplicationId { get; set; }
        /// <summary> Permissions the identity has for keys, secrets and certificates. </summary>
        public IdentityAccessPermissions Permissions { get; set; }
    }
}
