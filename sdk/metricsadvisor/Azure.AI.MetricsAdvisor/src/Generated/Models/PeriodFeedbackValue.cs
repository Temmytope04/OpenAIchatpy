// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The PeriodFeedbackValue. </summary>
    internal partial class PeriodFeedbackValue
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeriodFeedbackValue"/>. </summary>
        /// <param name="periodType"> the type of setting period. </param>
        /// <param name="periodValue"> the number of intervals a period contains, when no period set to 0. </param>
        public PeriodFeedbackValue(MetricPeriodType periodType, int periodValue)
        {
            PeriodType = periodType;
            PeriodValue = periodValue;
        }

        /// <summary> Initializes a new instance of <see cref="PeriodFeedbackValue"/>. </summary>
        /// <param name="periodType"> the type of setting period. </param>
        /// <param name="periodValue"> the number of intervals a period contains, when no period set to 0. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeriodFeedbackValue(MetricPeriodType periodType, int periodValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PeriodType = periodType;
            PeriodValue = periodValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PeriodFeedbackValue"/> for deserialization. </summary>
        internal PeriodFeedbackValue()
        {
        }

        /// <summary> the type of setting period. </summary>
        public MetricPeriodType PeriodType { get; set; }
        /// <summary> the number of intervals a period contains, when no period set to 0. </summary>
        public int PeriodValue { get; set; }
    }
}
