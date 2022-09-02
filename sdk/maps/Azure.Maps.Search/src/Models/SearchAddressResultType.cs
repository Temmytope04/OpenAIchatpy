// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary>
    /// One of:
    /// * POI
    /// * Street
    /// * Geography
    /// * Point Address
    /// * Address Range
    /// * Cross Street
    /// </summary>
    [CodeGenModel("SearchAddressResultType")]
    public readonly partial struct SearchAddressResultType : IEquatable<SearchAddressResultType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchAddressResultType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SearchAddressResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string POIValue = "POI";

        /// <summary> POI. </summary>
        [CodeGenMember("POI")]
        public static SearchAddressResultType PointOfInterest { get; } = new SearchAddressResultType(POIValue);
    }
}
