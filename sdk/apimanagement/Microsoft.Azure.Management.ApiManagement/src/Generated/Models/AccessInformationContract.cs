// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tenant Settings.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AccessInformationContract : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the AccessInformationContract class.
        /// </summary>
        public AccessInformationContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessInformationContract class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="accessInformationContractId">Access Information type
        /// ('access' or 'gitAccess')</param>
        /// <param name="principalId">Principal (User) Identifier.</param>
        /// <param name="enabled">Determines whether direct access is
        /// enabled.</param>
        public AccessInformationContract(string id = default(string), string name = default(string), string type = default(string), string accessInformationContractId = default(string), string principalId = default(string), bool? enabled = default(bool?))
            : base(id, name, type)
        {
            AccessInformationContractId = accessInformationContractId;
            PrincipalId = principalId;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets access Information type ('access' or 'gitAccess')
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string AccessInformationContractId { get; set; }

        /// <summary>
        /// Gets or sets principal (User) Identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets determines whether direct access is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

    }
}
