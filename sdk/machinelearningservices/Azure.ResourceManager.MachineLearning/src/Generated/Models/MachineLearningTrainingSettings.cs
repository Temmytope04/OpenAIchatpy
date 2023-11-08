// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Training related configuration. </summary>
    public partial class MachineLearningTrainingSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningTrainingSettings"/>. </summary>
        public MachineLearningTrainingSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningTrainingSettings"/>. </summary>
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
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningTrainingSettings(bool? isDnnTrainingEnabled, bool? isModelExplainabilityEnabled, bool? isOnnxCompatibleModelsEnabled, bool? isStackEnsembleEnabled, bool? isVoteEnsembleEnabled, TimeSpan? ensembleModelDownloadTimeout, MachineLearningStackEnsembleSettings stackEnsembleSettings, TrainingMode? trainingMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsDnnTrainingEnabled = isDnnTrainingEnabled;
            IsModelExplainabilityEnabled = isModelExplainabilityEnabled;
            IsOnnxCompatibleModelsEnabled = isOnnxCompatibleModelsEnabled;
            IsStackEnsembleEnabled = isStackEnsembleEnabled;
            IsVoteEnsembleEnabled = isVoteEnsembleEnabled;
            EnsembleModelDownloadTimeout = ensembleModelDownloadTimeout;
            StackEnsembleSettings = stackEnsembleSettings;
            TrainingMode = trainingMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enable recommendation of DNN models. </summary>
        public bool? IsDnnTrainingEnabled { get; set; }
        /// <summary> Flag to turn on explainability on best model. </summary>
        public bool? IsModelExplainabilityEnabled { get; set; }
        /// <summary> Flag for enabling onnx compatible models. </summary>
        public bool? IsOnnxCompatibleModelsEnabled { get; set; }
        /// <summary> Enable stack ensemble run. </summary>
        public bool? IsStackEnsembleEnabled { get; set; }
        /// <summary> Enable voting ensemble run. </summary>
        public bool? IsVoteEnsembleEnabled { get; set; }
        /// <summary>
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </summary>
        public TimeSpan? EnsembleModelDownloadTimeout { get; set; }
        /// <summary> Stack ensemble settings for stack ensemble run. </summary>
        public MachineLearningStackEnsembleSettings StackEnsembleSettings { get; set; }
        /// <summary>
        /// TrainingMode mode - Setting to 'auto' is same as setting it to 'non-distributed' for now, however in the future may result in mixed mode or heuristics based mode selection. Default is 'auto'.
        /// If 'Distributed' then only distributed featurization is used and distributed algorithms are chosen.
        /// If 'NonDistributed' then only non distributed algorithms are chosen.
        /// </summary>
        public TrainingMode? TrainingMode { get; set; }
    }
}
