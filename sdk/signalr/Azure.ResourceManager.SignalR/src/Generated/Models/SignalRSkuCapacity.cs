// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Describes scaling information of a sku. </summary>
    public partial class SignalRSkuCapacity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SignalRSkuCapacity"/>. </summary>
        internal SignalRSkuCapacity()
        {
            AllowedValues = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRSkuCapacity"/>. </summary>
        /// <param name="minimum"> The lowest permitted capacity for this resource. </param>
        /// <param name="maximum"> The highest permitted capacity for this resource. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="allowedValues"> Allows capacity value list. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRSkuCapacity(int? minimum, int? maximum, int? @default, IReadOnlyList<int> allowedValues, SignalRScaleType? scaleType, Dictionary<string, BinaryData> rawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            AllowedValues = allowedValues;
            ScaleType = scaleType;
            _rawData = rawData;
        }

        /// <summary> The lowest permitted capacity for this resource. </summary>
        public int? Minimum { get; }
        /// <summary> The highest permitted capacity for this resource. </summary>
        public int? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public int? Default { get; }
        /// <summary> Allows capacity value list. </summary>
        public IReadOnlyList<int> AllowedValues { get; }
        /// <summary> The scale type applicable to the sku. </summary>
        public SignalRScaleType? ScaleType { get; }
    }
}
