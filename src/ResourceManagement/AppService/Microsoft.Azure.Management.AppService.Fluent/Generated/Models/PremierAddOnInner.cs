// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Premier add-on.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PremierAddOnInner : Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the PremierAddOnInner class.
        /// </summary>
        public PremierAddOnInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PremierAddOnInner class.
        /// </summary>
        /// <param name="sku">SKU.</param>
        /// <param name="product">Product.</param>
        /// <param name="vendor">Vendor.</param>
        /// <param name="premierAddOnName">Name.</param>
        /// <param name="premierAddOnLocation">Location.</param>
        /// <param name="premierAddOnTags">Tags.</param>
        /// <param name="marketplacePublisher">Marketplace publisher.</param>
        /// <param name="marketplaceOffer">Marketplace offer.</param>
        public PremierAddOnInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string sku = default(string), string product = default(string), string vendor = default(string), string premierAddOnName = default(string), string premierAddOnLocation = default(string), IDictionary<string, string> premierAddOnTags = default(IDictionary<string, string>), string marketplacePublisher = default(string), string marketplaceOffer = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Product = product;
            Vendor = vendor;
            PremierAddOnName = premierAddOnName;
            PremierAddOnLocation = premierAddOnLocation;
            PremierAddOnTags = premierAddOnTags;
            MarketplacePublisher = marketplacePublisher;
            MarketplaceOffer = marketplaceOffer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets vendor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string PremierAddOnName { get; set; }

        /// <summary>
        /// Gets or sets location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string PremierAddOnLocation { get; set; }

        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> PremierAddOnTags { get; set; }

        /// <summary>
        /// Gets or sets marketplace publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplacePublisher")]
        public string MarketplacePublisher { get; set; }

        /// <summary>
        /// Gets or sets marketplace offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplaceOffer")]
        public string MarketplaceOffer { get; set; }

    }
}
