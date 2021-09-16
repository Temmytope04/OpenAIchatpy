// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The managed identity for the disk encryption set. It should be given
    /// permission on the key vault before it can be used to encrypt disks.
    /// </summary>
    public partial class EncryptionSetIdentity
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionSetIdentity class.
        /// </summary>
        public EncryptionSetIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionSetIdentity class.
        /// </summary>
        /// <param name="type">The type of Managed Identity used by the
        /// DiskEncryptionSet. Only SystemAssigned is supported. Possible
        /// values include: 'SystemAssigned'</param>
        /// <param name="principalId">The object id of the Managed Identity
        /// Resource. This will be sent to the RP from ARM via the
        /// x-ms-identity-principal-id header in the PUT request if the
        /// resource has a systemAssigned(implicit) identity</param>
        /// <param name="tenantId">The tenant id of the Managed Identity
        /// Resource. This will be sent to the RP from ARM via the
        /// x-ms-client-tenant-id header in the PUT request if the resource has
        /// a systemAssigned(implicit) identity</param>
        public EncryptionSetIdentity(string type = default(string), string principalId = default(string), string tenantId = default(string))
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of Managed Identity used by the
        /// DiskEncryptionSet. Only SystemAssigned is supported. Possible
        /// values include: 'SystemAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the object id of the Managed Identity Resource. This will be
        /// sent to the RP from ARM via the x-ms-identity-principal-id header
        /// in the PUT request if the resource has a systemAssigned(implicit)
        /// identity
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id of the Managed Identity Resource. This will be
        /// sent to the RP from ARM via the x-ms-client-tenant-id header in the
        /// PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

    }
}
