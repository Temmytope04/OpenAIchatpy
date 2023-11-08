// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Optimization objective. </summary>
    public partial class MachineLearningObjective
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningObjective"/>. </summary>
        /// <param name="goal"> [Required] Defines supported metric goals for hyperparameter tuning. </param>
        /// <param name="primaryMetric"> [Required] Name of the metric to optimize. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryMetric"/> is null. </exception>
        public MachineLearningObjective(MachineLearningGoal goal, string primaryMetric)
        {
            Argument.AssertNotNull(primaryMetric, nameof(primaryMetric));

            Goal = goal;
            PrimaryMetric = primaryMetric;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningObjective"/>. </summary>
        /// <param name="goal"> [Required] Defines supported metric goals for hyperparameter tuning. </param>
        /// <param name="primaryMetric"> [Required] Name of the metric to optimize. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningObjective(MachineLearningGoal goal, string primaryMetric, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Goal = goal;
            PrimaryMetric = primaryMetric;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningObjective"/> for deserialization. </summary>
        internal MachineLearningObjective()
        {
        }

        /// <summary> [Required] Defines supported metric goals for hyperparameter tuning. </summary>
        public MachineLearningGoal Goal { get; set; }
        /// <summary> [Required] Name of the metric to optimize. </summary>
        public string PrimaryMetric { get; set; }
    }
}
