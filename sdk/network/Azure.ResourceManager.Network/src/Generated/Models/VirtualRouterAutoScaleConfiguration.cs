// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The VirtualHub Router autoscale configuration. </summary>
    internal partial class VirtualRouterAutoScaleConfiguration
    {
        /// <summary> Initializes a new instance of VirtualRouterAutoScaleConfiguration. </summary>
        public VirtualRouterAutoScaleConfiguration()
        {
        }

        /// <summary> Initializes a new instance of VirtualRouterAutoScaleConfiguration. </summary>
        /// <param name="minCapacity"> The minimum number of scale units for VirtualHub Router. </param>
        internal VirtualRouterAutoScaleConfiguration(int? minCapacity)
        {
            MinCapacity = minCapacity;
        }

        /// <summary> The minimum number of scale units for VirtualHub Router. </summary>
        public int? MinCapacity { get; set; }
    }
}
