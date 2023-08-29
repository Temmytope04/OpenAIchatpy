// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models
{
    /// <summary> Managed private endpoint. </summary>
    public partial class ManagedPrivateEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpoint"/>. </summary>
        public ManagedPrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpoint"/>. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="properties"> Managed private endpoint properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedPrivateEndpoint(string id, string name, string type, ManagedPrivateEndpointProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </summary>
        public string Id { get; }
        /// <summary> The name of the resource. </summary>
        public string Name { get; }
        /// <summary> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </summary>
        public string Type { get; }
        /// <summary> Managed private endpoint properties. </summary>
        public ManagedPrivateEndpointProperties Properties { get; set; }
    }
}
