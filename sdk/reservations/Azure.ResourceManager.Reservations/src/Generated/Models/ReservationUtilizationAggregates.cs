// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The aggregate values of reservation utilization. </summary>
    public partial class ReservationUtilizationAggregates
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReservationUtilizationAggregates"/>. </summary>
        internal ReservationUtilizationAggregates()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationUtilizationAggregates"/>. </summary>
        /// <param name="grain"> The grain of the aggregate. </param>
        /// <param name="grainUnit"> The grain unit of the aggregate. </param>
        /// <param name="value"> The aggregate value. </param>
        /// <param name="valueUnit"> The aggregate value unit. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationUtilizationAggregates(float? grain, string grainUnit, float? value, string valueUnit, Dictionary<string, BinaryData> rawData)
        {
            Grain = grain;
            GrainUnit = grainUnit;
            Value = value;
            ValueUnit = valueUnit;
            _rawData = rawData;
        }

        /// <summary> The grain of the aggregate. </summary>
        public float? Grain { get; }
        /// <summary> The grain unit of the aggregate. </summary>
        public string GrainUnit { get; }
        /// <summary> The aggregate value. </summary>
        public float? Value { get; }
        /// <summary> The aggregate value unit. </summary>
        public string ValueUnit { get; }
    }
}
