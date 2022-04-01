// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ExtendedLocation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public partial class Identity
    {
        /// <summary>
        /// Initializes a new instance of the Identity class.
        /// </summary>
        public Identity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Identity class.
        /// </summary>
        /// <param name="principalId">The principal ID of resource
        /// identity.</param>
        /// <param name="tenantId">The tenant ID of resource.</param>
        /// <param name="type">The identity type. Possible values include:
        /// 'SystemAssigned', 'None'</param>
        public Identity(string principalId = default(string), string tenantId = default(string), string type = default(string))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal ID of resource identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant ID of resource.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the identity type. Possible values include:
        /// 'SystemAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
