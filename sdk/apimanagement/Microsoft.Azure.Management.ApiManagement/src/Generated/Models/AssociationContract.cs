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
    /// Association entity details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AssociationContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AssociationContract class.
        /// </summary>
        public AssociationContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssociationContract class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'created'</param>
        public AssociationContract(string id = default(string), string name = default(string), string type = default(string), ProvisioningState? provisioningState = default(ProvisioningState?))
            : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provisioning state. Possible values include: 'created'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

    }
}
