// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> The ComponentsNj115SSchemasVirtualmachinescalesetidentityPropertiesUserassignedidentitiesAdditionalproperties. </summary>
    public partial class ComponentsNj115SSchemasVirtualmachinescalesetidentityPropertiesUserassignedidentitiesAdditionalproperties
    {
        /// <summary> Initializes a new instance of ComponentsNj115SSchemasVirtualmachinescalesetidentityPropertiesUserassignedidentitiesAdditionalproperties. </summary>
        public ComponentsNj115SSchemasVirtualmachinescalesetidentityPropertiesUserassignedidentitiesAdditionalproperties()
        {
        }

        /// <summary> Initializes a new instance of ComponentsNj115SSchemasVirtualmachinescalesetidentityPropertiesUserassignedidentitiesAdditionalproperties. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        internal ComponentsNj115SSchemasVirtualmachinescalesetidentityPropertiesUserassignedidentitiesAdditionalproperties(string principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client id of user assigned identity. </summary>
        public string ClientId { get; }
    }
}
