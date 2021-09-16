// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Commerce.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the offer term.
    /// </summary>
    [Newtonsoft.Json.JsonObject("OfferTermInfo")]
    public partial class OfferTermInfo
    {
        /// <summary>
        /// Initializes a new instance of the OfferTermInfo class.
        /// </summary>
        public OfferTermInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfferTermInfo class.
        /// </summary>
        /// <param name="effectiveDate">Indicates the date from which the offer
        /// term is effective.</param>
        public OfferTermInfo(System.DateTime? effectiveDate = default(System.DateTime?))
        {
            EffectiveDate = effectiveDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the date from which the offer term is
        /// effective.
        /// </summary>
        [JsonProperty(PropertyName = "EffectiveDate")]
        public System.DateTime? EffectiveDate { get; set; }

    }
}
