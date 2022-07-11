// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Private endpoint which the connection belongs to. </summary>
    internal partial class PrivateEndpointProperty
    {
        /// <summary> Initializes a new instance of PrivateEndpointProperty. </summary>
        public PrivateEndpointProperty()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointProperty. </summary>
        /// <param name="id"> Resource id of the private endpoint. </param>
        internal PrivateEndpointProperty(ResourceIdentifier id)
        {
            Id = id;
        }

        /// <summary> Resource id of the private endpoint. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
