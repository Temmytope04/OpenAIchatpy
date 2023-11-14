// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MonitoringThreshold. </summary>
    internal partial class MonitoringThreshold
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitoringThreshold"/>. </summary>
        public MonitoringThreshold()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringThreshold"/>. </summary>
        /// <param name="value"> The threshold value. If null, the set default is dependent on the metric type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoringThreshold(double? value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The threshold value. If null, the set default is dependent on the metric type. </summary>
        public double? Value { get; set; }
    }
}
