// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The DetectedLanguage. </summary>
    internal readonly partial struct DetectedLanguage_internal
    {
        /// <summary> Initializes a new instance of DetectedLanguage_internal. </summary>
        /// <param name="name"> Long name of a detected language (e.g. English, French). </param>
        /// <param name="iso6391Name"> A two letter representation of the detected language according to the ISO 639-1 standard (e.g. en, fr). </param>
        /// <param name="confidenceScore"> A confidence score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="iso6391Name"/> is null. </exception>
        internal DetectedLanguage_internal(string name, string iso6391Name, double confidenceScore)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (iso6391Name == null)
            {
                throw new ArgumentNullException(nameof(iso6391Name));
            }

            Name = name;
            Iso6391Name = iso6391Name;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Long name of a detected language (e.g. English, French). </summary>
        public string Name { get; }
        /// <summary> A two letter representation of the detected language according to the ISO 639-1 standard (e.g. en, fr). </summary>
        public string Iso6391Name { get; }
        /// <summary> A confidence score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. </summary>
        public double ConfidenceScore { get; }
    }
}
