// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Represents a predictive metric value in the given bucket. </summary>
    public partial class PredictiveValue
    {
        /// <summary> Initializes a new instance of <see cref="PredictiveValue"/>. </summary>
        /// <param name="timeStamp"> the timestamp for the metric value in ISO 8601 format. </param>
        /// <param name="value"> Predictive value in this time bucket. </param>
        internal PredictiveValue(DateTimeOffset timeStamp, double value)
        {
            TimeStamp = timeStamp;
            Value = value;
        }

        /// <summary> the timestamp for the metric value in ISO 8601 format. </summary>
        public DateTimeOffset TimeStamp { get; }
        /// <summary> Predictive value in this time bucket. </summary>
        public double Value { get; }
    }
}
