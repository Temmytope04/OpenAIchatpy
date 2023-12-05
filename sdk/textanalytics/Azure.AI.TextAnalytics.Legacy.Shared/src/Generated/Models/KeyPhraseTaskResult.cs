// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The KeyPhraseTaskResult. </summary>
    internal partial class KeyPhraseTaskResult
    {
        /// <summary> Initializes a new instance of <see cref="KeyPhraseTaskResult"/>. </summary>
        internal KeyPhraseTaskResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyPhraseTaskResult"/>. </summary>
        /// <param name="results"></param>
        internal KeyPhraseTaskResult(KeyPhraseResult results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public KeyPhraseResult Results { get; }
    }
}
