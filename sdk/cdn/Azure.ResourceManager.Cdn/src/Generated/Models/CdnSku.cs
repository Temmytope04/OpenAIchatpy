// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Standard_Verizon = The SKU name for a Standard Verizon CDN profile.
    /// Premium_Verizon = The SKU name for a Premium Verizon CDN profile.
    /// Custom_Verizon = The SKU name for a Custom Verizon CDN profile.
    /// Standard_Akamai = The SKU name for an Akamai CDN profile.
    /// Standard_ChinaCdn = The SKU name for a China CDN profile for VOD, Web and download scenarios using GB based billing model.
    /// Standard_Microsoft = The SKU name for a Standard Microsoft CDN profile.
    /// Standard_AzureFrontDoor =  The SKU name for an Azure Front Door Standard profile.
    /// Premium_AzureFrontDoor = The SKU name for an Azure Front Door Premium profile.
    /// Standard_955BandWidth_ChinaCdn = The SKU name for a China CDN profile for VOD, Web and download scenarios using 95-5 peak bandwidth billing model.
    /// Standard_AvgBandWidth_ChinaCdn = The SKU name for a China CDN profile for VOD, Web and download scenarios using monthly average peak bandwidth billing model.
    /// StandardPlus_ChinaCdn = The SKU name for a China CDN profile for live-streaming using GB based billing model.
    /// StandardPlus_955BandWidth_ChinaCdn = The SKU name for a China CDN live-streaming profile using 95-5 peak bandwidth billing model.
    /// StandardPlus_AvgBandWidth_ChinaCdn = The SKU name for a China CDN live-streaming profile using monthly average peak bandwidth billing model.
    ///
    /// </summary>
    public partial class CdnSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CdnSku"/>. </summary>
        public CdnSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CdnSku"/>. </summary>
        /// <param name="name"> Name of the pricing tier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnSku(CdnSkuName? name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Name of the pricing tier. </summary>
        public CdnSkuName? Name { get; set; }
    }
}
