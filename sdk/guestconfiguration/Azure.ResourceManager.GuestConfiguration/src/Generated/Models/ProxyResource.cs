// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> ARM proxy resource. </summary>
    public partial class ProxyResource : GuestConfigurationResourceData
    {
        /// <summary> Initializes a new instance of ProxyResource. </summary>
        public ProxyResource()
        {
        }

        /// <summary> Initializes a new instance of ProxyResource. </summary>
        /// <param name="id"> ARM resource id of the guest configuration assignment. </param>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="location"> Region where the VM is located. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        internal ProxyResource(string id, string name, AzureLocation? location, string resourceType) : base(id, name, location, resourceType)
        {
        }
    }
}
