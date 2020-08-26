// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed identity properties retrieved from ARM request headers.
    /// </summary>
    public partial class ManagedIdentityProperties
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIdentityProperties class.
        /// </summary>
        public ManagedIdentityProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIdentityProperties class.
        /// </summary>
        /// <param name="type">Type of the managed identity. Possible values
        /// include: 'None', 'SystemAssigned', 'UserAssigned',
        /// 'SystemAssigned,UserAssigned'</param>
        /// <param name="principalId">Principal Id</param>
        /// <param name="tenantId">Tenant Id</param>
        public ManagedIdentityProperties(string type = default(string), string principalId = default(string), string tenantId = default(string))
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
        /// Gets or sets type of the managed identity. Possible values include:
        /// 'None', 'SystemAssigned', 'UserAssigned',
        /// 'SystemAssigned,UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets principal Id
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

    }
}
