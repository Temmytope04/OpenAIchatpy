// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Featurization Configuration. </summary>
    public partial class MachineLearningFeaturizationSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeaturizationSettings"/>. </summary>
        public MachineLearningFeaturizationSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeaturizationSettings"/>. </summary>
        /// <param name="datasetLanguage"> Dataset language, useful for the text data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningFeaturizationSettings(string datasetLanguage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DatasetLanguage = datasetLanguage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Dataset language, useful for the text data. </summary>
        public string DatasetLanguage { get; set; }
    }
}
