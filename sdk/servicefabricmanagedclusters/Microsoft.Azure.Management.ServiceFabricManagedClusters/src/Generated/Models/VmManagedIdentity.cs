// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identities for the virtual machine scale set under the node type.
    /// </summary>
    public partial class VmManagedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the VmManagedIdentity class.
        /// </summary>
        public VmManagedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VmManagedIdentity class.
        /// </summary>
        /// <param name="userAssignedIdentities">The list of user identities
        /// associated with the virtual machine scale set under the node type.
        /// Each entry will be an ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.</param>
        public VmManagedIdentity(IList<string> userAssignedIdentities = default(IList<string>))
        {
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of user identities associated with the
        /// virtual machine scale set under the node type. Each entry will be
        /// an ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IList<string> UserAssignedIdentities { get; set; }

    }
}
