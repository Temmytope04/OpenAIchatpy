// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Forecasting Training related configuration. </summary>
    public partial class ForecastingTrainingSettings : MachineLearningTrainingSettings
    {
        /// <summary> Initializes a new instance of <see cref="ForecastingTrainingSettings"/>. </summary>
        public ForecastingTrainingSettings()
        {
            AllowedTrainingAlgorithms = new ChangeTrackingList<ForecastingModel>();
            BlockedTrainingAlgorithms = new ChangeTrackingList<ForecastingModel>();
        }

        /// <summary> Initializes a new instance of <see cref="ForecastingTrainingSettings"/>. </summary>
        /// <param name="isDnnTrainingEnabled"> Enable recommendation of DNN models. </param>
        /// <param name="isModelExplainabilityEnabled"> Flag to turn on explainability on best model. </param>
        /// <param name="isOnnxCompatibleModelsEnabled"> Flag for enabling onnx compatible models. </param>
        /// <param name="isStackEnsembleEnabled"> Enable stack ensemble run. </param>
        /// <param name="isVoteEnsembleEnabled"> Enable voting ensemble run. </param>
        /// <param name="ensembleModelDownloadTimeout">
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </param>
        /// <param name="stackEnsembleSettings"> Stack ensemble settings for stack ensemble run. </param>
        /// <param name="trainingMode">
        /// TrainingMode mode - Setting to 'auto' is same as setting it to 'non-distributed' for now, however in the future may result in mixed mode or heuristics based mode selection. Default is 'auto'.
        /// If 'Distributed' then only distributed featurization is used and distributed algorithms are chosen.
        /// If 'NonDistributed' then only non distributed algorithms are chosen.
        /// </param>
        /// <param name="allowedTrainingAlgorithms"> Allowed models for forecasting task. </param>
        /// <param name="blockedTrainingAlgorithms"> Blocked models for forecasting task. </param>
        internal ForecastingTrainingSettings(bool? isDnnTrainingEnabled, bool? isModelExplainabilityEnabled, bool? isOnnxCompatibleModelsEnabled, bool? isStackEnsembleEnabled, bool? isVoteEnsembleEnabled, TimeSpan? ensembleModelDownloadTimeout, MachineLearningStackEnsembleSettings stackEnsembleSettings, TrainingMode? trainingMode, IList<ForecastingModel> allowedTrainingAlgorithms, IList<ForecastingModel> blockedTrainingAlgorithms) : base(isDnnTrainingEnabled, isModelExplainabilityEnabled, isOnnxCompatibleModelsEnabled, isStackEnsembleEnabled, isVoteEnsembleEnabled, ensembleModelDownloadTimeout, stackEnsembleSettings, trainingMode)
        {
            AllowedTrainingAlgorithms = allowedTrainingAlgorithms;
            BlockedTrainingAlgorithms = blockedTrainingAlgorithms;
        }

        /// <summary> Allowed models for forecasting task. </summary>
        public IList<ForecastingModel> AllowedTrainingAlgorithms { get; set; }
        /// <summary> Blocked models for forecasting task. </summary>
        public IList<ForecastingModel> BlockedTrainingAlgorithms { get; set; }
    }
}
