// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The FeatureAttributionMetricThreshold. </summary>
    public partial class FeatureAttributionMetricThreshold
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FeatureAttributionMetricThreshold"/>. </summary>
        /// <param name="metric"> [Required] The feature attribution metric to calculate. </param>
        public FeatureAttributionMetricThreshold(FeatureAttributionMetric metric)
        {
            Metric = metric;
        }

        /// <summary> Initializes a new instance of <see cref="FeatureAttributionMetricThreshold"/>. </summary>
        /// <param name="metric"> [Required] The feature attribution metric to calculate. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FeatureAttributionMetricThreshold(FeatureAttributionMetric metric, MonitoringThreshold threshold, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metric = metric;
            Threshold = threshold;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FeatureAttributionMetricThreshold"/> for deserialization. </summary>
        internal FeatureAttributionMetricThreshold()
        {
        }

        /// <summary> [Required] The feature attribution metric to calculate. </summary>
        public FeatureAttributionMetric Metric { get; set; }
        /// <summary> The threshold value. If null, a default value will be set depending on the selected metric. </summary>
        internal MonitoringThreshold Threshold { get; set; }
        /// <summary> The threshold value. If null, the set default is dependent on the metric type. </summary>
        public double? ThresholdValue
        {
            get => Threshold is null ? default : Threshold.Value;
            set
            {
                if (Threshold is null)
                    Threshold = new MonitoringThreshold();
                Threshold.Value = value;
            }
        }
    }
}
