// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// The encryption identity properties.
    /// </summary>
    public partial class EncryptionIdentity
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionIdentity class.
        /// </summary>
        public EncryptionIdentity() { }

        /// <summary>
        /// Initializes a new instance of the EncryptionIdentity class.
        /// </summary>
        /// <param name="principalId">The principal identifier associated with
        /// the encryption.</param>
        /// <param name="tenantId">The tenant identifier associated with the
        /// encryption.</param>
        public EncryptionIdentity(System.Guid? principalId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
        }
        /// <summary>
        /// Static constructor for EncryptionIdentity class.
        /// </summary>
        static EncryptionIdentity()
        {
            Type = "SystemAssigned";
        }

        /// <summary>
        /// Gets the principal identifier associated with the encryption.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; protected set; }

        /// <summary>
        /// Gets the tenant identifier associated with the encryption.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; protected set; }

        /// <summary>
        /// The type of encryption being used. Currently the only supported
        /// type is 'SystemAssigned'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

    }
}


