// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included. </summary>
    public partial class AddressRanges
    {
        /// <summary> Initializes a new instance of AddressRanges. </summary>
        internal AddressRanges()
        {
        }

        /// <summary> Initializes a new instance of AddressRanges. </summary>
        /// <param name="rangeLeft"> Address range on the left side of the street. </param>
        /// <param name="rangeRight"> Address range on the right side of the street. </param>
        /// <param name="fromInternal"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <param name="toInternal"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        internal AddressRanges(string rangeLeft, string rangeRight, LatLongPairAbbreviated fromInternal, LatLongPairAbbreviated toInternal)
        {
            RangeLeft = rangeLeft;
            RangeRight = rangeRight;
            FromInternal = fromInternal;
            ToInternal = toInternal;
        }

        /// <summary> Address range on the left side of the street. </summary>
        public string RangeLeft { get; }
        /// <summary> Address range on the right side of the street. </summary>
        public string RangeRight { get; }
    }
}
