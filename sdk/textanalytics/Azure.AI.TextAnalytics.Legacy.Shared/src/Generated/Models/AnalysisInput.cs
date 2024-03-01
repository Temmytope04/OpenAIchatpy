// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The AnalysisInput. </summary>
    internal partial class AnalysisInput
    {
        /// <summary> Initializes a new instance of <see cref="AnalysisInput"/>. </summary>
        /// <param name="analysisInputValue"> Contains a set of input documents to be analyzed by the service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisInputValue"/> is null. </exception>
        public AnalysisInput(MultiLanguageBatchInput analysisInputValue)
        {
            if (analysisInputValue == null)
            {
                throw new ArgumentNullException(nameof(analysisInputValue));
            }

            AnalysisInputValue = analysisInputValue;
        }

        /// <summary> Contains a set of input documents to be analyzed by the service. </summary>
        public MultiLanguageBatchInput AnalysisInputValue { get; }
    }
}
