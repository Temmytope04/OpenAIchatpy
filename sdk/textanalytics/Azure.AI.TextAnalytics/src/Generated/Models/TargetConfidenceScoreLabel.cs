// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Represents the confidence scores across all sentiment classes: positive and negative. </summary>
    internal partial class TargetConfidenceScoreLabel
    {
        /// <summary> Initializes a new instance of TargetConfidenceScoreLabel. </summary>
        /// <param name="positive"> Confidence score for positive sentiment. </param>
        /// <param name="negative"> Confidence score for negative sentiment. </param>
        public TargetConfidenceScoreLabel(double positive, double negative)
        {
            Positive = positive;
            Negative = negative;
        }

        /// <summary> Confidence score for positive sentiment. </summary>
        public double Positive { get; set; }
        /// <summary> Confidence score for negative sentiment. </summary>
        public double Negative { get; set; }
    }
}
