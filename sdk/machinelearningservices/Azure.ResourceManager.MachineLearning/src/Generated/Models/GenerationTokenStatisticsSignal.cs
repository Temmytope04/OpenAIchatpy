// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Generation token statistics signal definition. </summary>
    public partial class GenerationTokenStatisticsSignal : MonitoringSignalBase
    {
        /// <summary> Initializes a new instance of <see cref="GenerationTokenStatisticsSignal"/>. </summary>
        /// <param name="metricThresholds"> [Required] Gets or sets the metrics to calculate and the corresponding thresholds. </param>
        /// <param name="samplingRate"> [Required] The sample rate of the target data, should be greater than 0 and at most 1. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricThresholds"/> is null. </exception>
        public GenerationTokenStatisticsSignal(IEnumerable<GenerationTokenStatisticsMetricThreshold> metricThresholds, double samplingRate)
        {
            if (metricThresholds == null)
            {
                throw new ArgumentNullException(nameof(metricThresholds));
            }

            MetricThresholds = metricThresholds.ToList();
            SamplingRate = samplingRate;
            SignalType = MonitoringSignalType.GenerationTokenStatistics;
        }

        /// <summary> Initializes a new instance of <see cref="GenerationTokenStatisticsSignal"/>. </summary>
        /// <param name="mode"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="metricThresholds"> [Required] Gets or sets the metrics to calculate and the corresponding thresholds. </param>
        /// <param name="productionData">
        /// Gets or sets the target data for computing metrics.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="samplingRate"> [Required] The sample rate of the target data, should be greater than 0 and at most 1. </param>
        internal GenerationTokenStatisticsSignal(MonitoringNotificationMode? mode, IDictionary<string, string> properties, MonitoringSignalType signalType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<GenerationTokenStatisticsMetricThreshold> metricThresholds, MonitoringInputDataBase productionData, double samplingRate) : base(mode, properties, signalType, serializedAdditionalRawData)
        {
            MetricThresholds = metricThresholds;
            ProductionData = productionData;
            SamplingRate = samplingRate;
            SignalType = signalType;
        }

        /// <summary> Initializes a new instance of <see cref="GenerationTokenStatisticsSignal"/> for deserialization. </summary>
        internal GenerationTokenStatisticsSignal()
        {
        }

        /// <summary> [Required] Gets or sets the metrics to calculate and the corresponding thresholds. </summary>
        public IList<GenerationTokenStatisticsMetricThreshold> MetricThresholds { get; }
        /// <summary>
        /// Gets or sets the target data for computing metrics.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public MonitoringInputDataBase ProductionData { get; set; }
        /// <summary> [Required] The sample rate of the target data, should be greater than 0 and at most 1. </summary>
        public double SamplingRate { get; set; }
    }
}
