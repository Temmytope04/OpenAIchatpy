// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> IP Address Space. </summary>
    public partial class IPAddressSpaceInfo
    {
        /// <summary> Initializes a new instance of <see cref="IPAddressSpaceInfo"/>. </summary>
        public IPAddressSpaceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IPAddressSpaceInfo"/>. </summary>
        /// <param name="resourceId"> Resource Id. </param>
        /// <param name="addressSpace"> Address Space. </param>
        internal IPAddressSpaceInfo(ResourceIdentifier resourceId, string addressSpace)
        {
            ResourceId = resourceId;
            AddressSpace = addressSpace;
        }

        /// <summary> Resource Id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Address Space. </summary>
        public string AddressSpace { get; set; }
    }
}
