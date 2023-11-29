// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.EdgeMarketplace.Models
{
    /// <summary> Access token request object. </summary>
    public partial class AccessTokenContent
    {
        /// <summary> Initializes a new instance of <see cref="AccessTokenContent"/>. </summary>
        /// <param name="edgeMarketPlaceRegion"> The region where the disk will be created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeMarketPlaceRegion"/> is null. </exception>
        public AccessTokenContent(string edgeMarketPlaceRegion)
        {
            Argument.AssertNotNull(edgeMarketPlaceRegion, nameof(edgeMarketPlaceRegion));

            EdgeMarketPlaceRegion = edgeMarketPlaceRegion;
        }

        /// <summary> The name of the publisher. </summary>
        public string PublisherName { get; set; }
        /// <summary> The region where the disk will be created. </summary>
        public string EdgeMarketPlaceRegion { get; }
        /// <summary> The region where the disk will be created. </summary>
        public string EgeMarketPlaceResourceId { get; set; }
        /// <summary> The hyperv version. </summary>
        public string HypervGeneration { get; set; }
        /// <summary> The marketplace sku. </summary>
        public string MarketPlaceSku { get; set; }
        /// <summary> The marketplace sku version. </summary>
        public string MarketPlaceSkuVersion { get; set; }
        /// <summary> The device sku. </summary>
        public string DeviceSku { get; set; }
        /// <summary> The device sku version. </summary>
        public string DeviceVersion { get; set; }
    }
}
