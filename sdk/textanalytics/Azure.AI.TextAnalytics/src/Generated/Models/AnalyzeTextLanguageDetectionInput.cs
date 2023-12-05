// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The AnalyzeTextLanguageDetectionInput. </summary>
    internal partial class AnalyzeTextLanguageDetectionInput : AnalyzeTextTask
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeTextLanguageDetectionInput"/>. </summary>
        public AnalyzeTextLanguageDetectionInput()
        {
            Kind = AnalyzeTextTaskKind.LanguageDetection;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextLanguageDetectionInput"/>. </summary>
        /// <param name="kind"> Enumeration of supported Text Analysis tasks. </param>
        /// <param name="analysisInput"></param>
        /// <param name="parameters"> Supported parameters for a Language Detection task. </param>
        internal AnalyzeTextLanguageDetectionInput(AnalyzeTextTaskKind kind, LanguageDetectionAnalysisInput analysisInput, LanguageDetectionTaskParameters parameters) : base(kind)
        {
            AnalysisInput = analysisInput;
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Gets or sets the analysis input. </summary>
        public LanguageDetectionAnalysisInput AnalysisInput { get; set; }
        /// <summary> Supported parameters for a Language Detection task. </summary>
        public LanguageDetectionTaskParameters Parameters { get; set; }
    }
}
