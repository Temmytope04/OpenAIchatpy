// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport. </summary>
    internal partial class Viewport
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Viewport"/>. </summary>
        internal Viewport()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Viewport"/>. </summary>
        /// <param name="topLeftPointInternal"> A location represented as a latitude and longitude using short names 'lat' &amp; 'lon'. </param>
        /// <param name="btmRightPointInternal"> A location represented as a latitude and longitude using short names 'lat' &amp; 'lon'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Viewport(LatLongPairAbbreviated topLeftPointInternal, LatLongPairAbbreviated btmRightPointInternal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TopLeftPointInternal = topLeftPointInternal;
            BtmRightPointInternal = btmRightPointInternal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
