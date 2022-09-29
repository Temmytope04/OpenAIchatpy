// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The resource model definition representing SKU for DevCenter resources. </summary>
    public partial class DevCenterSkuDetails : DevCenterSku
    {
        /// <summary> Initializes a new instance of DevCenterSkuDetails. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DevCenterSkuDetails(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Locations = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<Capability>();
        }

        /// <summary> Initializes a new instance of DevCenterSkuDetails. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        /// <param name="size"> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        /// <param name="resourceType"> The name of the resource type. </param>
        /// <param name="locations"> SKU supported locations. </param>
        /// <param name="capabilities"> Collection of name/value pairs to describe the SKU capabilities. </param>
        internal DevCenterSkuDetails(string name, DevCenterSkuTier? tier, string size, string family, int? capacity, string resourceType, IReadOnlyList<string> locations, IReadOnlyList<Capability> capabilities) : base(name, tier, size, family, capacity)
        {
            ResourceType = resourceType;
            Locations = locations;
            Capabilities = capabilities;
        }

        /// <summary> The name of the resource type. </summary>
        public string ResourceType { get; }
        /// <summary> SKU supported locations. </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> Collection of name/value pairs to describe the SKU capabilities. </summary>
        public IReadOnlyList<Capability> Capabilities { get; }
    }
}
