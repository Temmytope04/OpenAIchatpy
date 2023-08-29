// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> An object describing the detected language. </summary>
    public partial class DetectedLanguage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of DetectedLanguage. </summary>
        /// <param name="language"> A string representing the code of the detected language. </param>
        /// <param name="score">
        /// A float value indicating the confidence in the result.
        /// The score is between zero and one and a low score indicates a low confidence.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="language"/> is null. </exception>
        internal DetectedLanguage(string language, float score)
        {
            Argument.AssertNotNull(language, nameof(language));

            Language = language;
            Score = score;
        }

        /// <summary> Initializes a new instance of DetectedLanguage. </summary>
        /// <param name="language"> A string representing the code of the detected language. </param>
        /// <param name="score">
        /// A float value indicating the confidence in the result.
        /// The score is between zero and one and a low score indicates a low confidence.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectedLanguage(string language, float score, Dictionary<string, BinaryData> rawData)
        {
            Language = language;
            Score = score;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/> for deserialization. </summary>
        internal DetectedLanguage()
        {
        }

        /// <summary> A string representing the code of the detected language. </summary>
        public string Language { get; }
        /// <summary>
        /// A float value indicating the confidence in the result.
        /// The score is between zero and one and a low score indicates a low confidence.
        /// </summary>
        public float Score { get; }
    }
}
