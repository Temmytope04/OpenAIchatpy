// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Core
{
    /// <summary> Identity for the resource. </summary>
    public partial class IdentityAutoGenerated
    {
        /// <summary> Initializes a new instance of IdentityAutoGenerated2. </summary>
        public IdentityAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of IdentityAutoGenerated2. </summary>
        /// <param name="principalId"> The principal ID of resource identity. </param>
        /// <param name="tenantId"> The tenant ID of resource. </param>
        /// <param name="type"> The identity type. </param>
        internal IdentityAutoGenerated(string principalId, string tenantId, ResourceIdentityType? type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> The principal ID of resource identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant ID of resource. </summary>
        public string TenantId { get; }
        /// <summary> The identity type. </summary>
        public ResourceIdentityType? Type { get; set; }
    }
}
