// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Private endpoint. </summary>
    internal partial class PrivateEndpoint
    {
        /// <summary> Initializes a new instance of <see cref="PrivateEndpoint"/>. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpoint"/>. </summary>
        /// <param name="id"> Full qualified Id of the private endpoint. </param>
        internal PrivateEndpoint(ResourceIdentifier id)
        {
            Id = id;
        }

        /// <summary> Full qualified Id of the private endpoint. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
