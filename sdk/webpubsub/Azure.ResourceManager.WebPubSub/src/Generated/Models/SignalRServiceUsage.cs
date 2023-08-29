// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Object that describes a specific usage of the resources. </summary>
    public partial class SignalRServiceUsage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SignalRServiceUsage"/>. </summary>
        internal SignalRServiceUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRServiceUsage"/>. </summary>
        /// <param name="id"> Fully qualified ARM resource id. </param>
        /// <param name="currentValue"> Current value for the usage quota. </param>
        /// <param name="limit"> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </param>
        /// <param name="name"> Localizable String object containing the name and a localized value. </param>
        /// <param name="unit"> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRServiceUsage(ResourceIdentifier id, long? currentValue, long? limit, SignalRServiceUsageName name, string unit, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            Unit = unit;
            _rawData = rawData;
        }

        /// <summary> Fully qualified ARM resource id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Current value for the usage quota. </summary>
        public long? CurrentValue { get; }
        /// <summary> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </summary>
        public long? Limit { get; }
        /// <summary> Localizable String object containing the name and a localized value. </summary>
        public SignalRServiceUsageName Name { get; }
        /// <summary> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </summary>
        public string Unit { get; }
    }
}
