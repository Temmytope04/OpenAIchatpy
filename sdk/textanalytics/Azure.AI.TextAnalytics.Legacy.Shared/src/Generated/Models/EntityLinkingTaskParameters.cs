// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The EntityLinkingTaskParameters. </summary>
    internal partial class EntityLinkingTaskParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskParameters"/>. </summary>
        public EntityLinkingTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskParameters"/>. </summary>
        /// <param name="modelVersion"></param>
        /// <param name="loggingOptOut"></param>
        /// <param name="stringIndexType"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityLinkingTaskParameters(string modelVersion, bool? loggingOptOut, StringIndexType? stringIndexType, Dictionary<string, BinaryData> rawData)
        {
            ModelVersion = modelVersion;
            LoggingOptOut = loggingOptOut;
            StringIndexType = stringIndexType;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
