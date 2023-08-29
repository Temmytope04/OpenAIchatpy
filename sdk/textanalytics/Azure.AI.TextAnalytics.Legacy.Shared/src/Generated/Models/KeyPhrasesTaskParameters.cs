// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The KeyPhrasesTaskParameters. </summary>
    internal partial class KeyPhrasesTaskParameters
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesTaskParameters"/>. </summary>
        public KeyPhrasesTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesTaskParameters"/>. </summary>
        /// <param name="modelVersion"></param>
        /// <param name="loggingOptOut"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyPhrasesTaskParameters(string modelVersion, bool? loggingOptOut, Dictionary<string, BinaryData> rawData)
        {
            ModelVersion = modelVersion;
            LoggingOptOut = loggingOptOut;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
    }
}
