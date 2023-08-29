// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Element containing the translated text. </summary>
    public partial class TranslatedTextItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of TranslatedTextItem. </summary>
        /// <param name="translations">
        /// An array of translation results. The size of the array matches the number of target
        /// languages specified through the to query parameter.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="translations"/> is null. </exception>
        internal TranslatedTextItem(IEnumerable<Translation> translations)
        {
            Argument.AssertNotNull(translations, nameof(translations));

            Translations = translations.ToList();
        }

        /// <summary> Initializes a new instance of TranslatedTextItem. </summary>
        /// <param name="detectedLanguage"> The detectedLanguage property is only present in the result object when language auto-detection is requested. </param>
        /// <param name="translations">
        /// An array of translation results. The size of the array matches the number of target
        /// languages specified through the to query parameter.
        /// </param>
        /// <param name="sourceText">
        /// Input text in the default script of the source language. sourceText property is present only when
        /// the input is expressed in a script that's not the usual script for the language. For example,
        /// if the input were Arabic written in Latin script, then sourceText.text would be the same Arabic text
        /// converted into Arab script.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslatedTextItem(DetectedLanguage detectedLanguage, IReadOnlyList<Translation> translations, SourceText sourceText, Dictionary<string, BinaryData> rawData)
        {
            DetectedLanguage = detectedLanguage;
            Translations = translations;
            SourceText = sourceText;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslatedTextItem"/> for deserialization. </summary>
        internal TranslatedTextItem()
        {
        }

        /// <summary> The detectedLanguage property is only present in the result object when language auto-detection is requested. </summary>
        public DetectedLanguage DetectedLanguage { get; }
        /// <summary>
        /// An array of translation results. The size of the array matches the number of target
        /// languages specified through the to query parameter.
        /// </summary>
        public IReadOnlyList<Translation> Translations { get; }
        /// <summary>
        /// Input text in the default script of the source language. sourceText property is present only when
        /// the input is expressed in a script that's not the usual script for the language. For example,
        /// if the input were Arabic written in Latin script, then sourceText.text would be the same Arabic text
        /// converted into Arab script.
        /// </summary>
        public SourceText SourceText { get; }
    }
}
