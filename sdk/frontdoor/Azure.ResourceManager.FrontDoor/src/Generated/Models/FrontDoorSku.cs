// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The pricing tier of the web application firewall policy. </summary>
    internal partial class FrontDoorSku
    {
        /// <summary> Initializes a new instance of <see cref="FrontDoorSku"/>. </summary>
        public FrontDoorSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorSku"/>. </summary>
        /// <param name="name"> Name of the pricing tier. </param>
        internal FrontDoorSku(FrontDoorSkuName? name)
        {
            Name = name;
        }

        /// <summary> Name of the pricing tier. </summary>
        public FrontDoorSkuName? Name { get; set; }
    }
}
