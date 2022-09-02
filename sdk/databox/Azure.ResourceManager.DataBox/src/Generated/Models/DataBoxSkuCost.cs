// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Describes metadata for retrieving price info. </summary>
    public partial class DataBoxSkuCost
    {
        /// <summary> Initializes a new instance of DataBoxSkuCost. </summary>
        internal DataBoxSkuCost()
        {
        }

        /// <summary> Initializes a new instance of DataBoxSkuCost. </summary>
        /// <param name="meterId"> Meter id of the Sku. </param>
        /// <param name="meterType"> The type of the meter. </param>
        /// <param name="multiplier"> Multiplier specifies the region specific value to be multiplied with 1$ guid. Eg: Our new regions will be using 1$ shipping guid with appropriate multiplier specific to region. </param>
        internal DataBoxSkuCost(Guid? meterId, string meterType, double? multiplier)
        {
            MeterId = meterId;
            MeterType = meterType;
            Multiplier = multiplier;
        }

        /// <summary> Meter id of the Sku. </summary>
        public Guid? MeterId { get; }
        /// <summary> The type of the meter. </summary>
        public string MeterType { get; }
        /// <summary> Multiplier specifies the region specific value to be multiplied with 1$ guid. Eg: Our new regions will be using 1$ shipping guid with appropriate multiplier specific to region. </summary>
        public double? Multiplier { get; }
    }
}
