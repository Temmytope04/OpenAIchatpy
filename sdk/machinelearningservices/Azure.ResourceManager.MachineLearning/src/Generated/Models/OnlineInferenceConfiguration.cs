// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Online inference configuration options. </summary>
    public partial class OnlineInferenceConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OnlineInferenceConfiguration"/>. </summary>
        public OnlineInferenceConfiguration()
        {
            Configurations = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="OnlineInferenceConfiguration"/>. </summary>
        /// <param name="configurations"> Additional configurations. </param>
        /// <param name="entryScript"> Entry script or command to invoke. </param>
        /// <param name="livenessRoute"> The route to check the liveness of the inference server container. </param>
        /// <param name="readinessRoute"> The route to check the readiness of the inference server container. </param>
        /// <param name="scoringRoute"> The port to send the scoring requests to, within the inference server container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OnlineInferenceConfiguration(IDictionary<string, string> configurations, string entryScript, MachineLearningInferenceContainerRoute livenessRoute, MachineLearningInferenceContainerRoute readinessRoute, MachineLearningInferenceContainerRoute scoringRoute, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Configurations = configurations;
            EntryScript = entryScript;
            LivenessRoute = livenessRoute;
            ReadinessRoute = readinessRoute;
            ScoringRoute = scoringRoute;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Additional configurations. </summary>
        public IDictionary<string, string> Configurations { get; set; }
        /// <summary> Entry script or command to invoke. </summary>
        public string EntryScript { get; set; }
        /// <summary> The route to check the liveness of the inference server container. </summary>
        public MachineLearningInferenceContainerRoute LivenessRoute { get; set; }
        /// <summary> The route to check the readiness of the inference server container. </summary>
        public MachineLearningInferenceContainerRoute ReadinessRoute { get; set; }
        /// <summary> The port to send the scoring requests to, within the inference server container. </summary>
        public MachineLearningInferenceContainerRoute ScoringRoute { get; set; }
    }
}
