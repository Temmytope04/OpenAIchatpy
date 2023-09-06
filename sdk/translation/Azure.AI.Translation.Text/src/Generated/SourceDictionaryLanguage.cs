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
    /// <summary> Properties ot the source dictionary language. </summary>
    public partial class SourceDictionaryLanguage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of SourceDictionaryLanguage. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="translations"> List of languages with alterative translations and examples for the query expressed in the source language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="nativeName"/>, <paramref name="dir"/> or <paramref name="translations"/> is null. </exception>
        internal SourceDictionaryLanguage(string name, string nativeName, string dir, IEnumerable<TargetDictionaryLanguage> translations)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(nativeName, nameof(nativeName));
            Argument.AssertNotNull(dir, nameof(dir));
            Argument.AssertNotNull(translations, nameof(translations));

            Name = name;
            NativeName = nativeName;
            Dir = dir;
            Translations = translations.ToList();
        }

        /// <summary> Initializes a new instance of SourceDictionaryLanguage. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="translations"> List of languages with alterative translations and examples for the query expressed in the source language. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceDictionaryLanguage(string name, string nativeName, string dir, IReadOnlyList<TargetDictionaryLanguage> translations, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            NativeName = nativeName;
            Dir = dir;
            Translations = translations;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SourceDictionaryLanguage"/> for deserialization. </summary>
        internal SourceDictionaryLanguage()
        {
        }

        /// <summary> Display name of the language in the locale requested via Accept-Language header. </summary>
        public string Name { get; }
        /// <summary> Display name of the language in the locale native for this language. </summary>
        public string NativeName { get; }
        /// <summary> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </summary>
        public string Dir { get; }
        /// <summary> List of languages with alterative translations and examples for the query expressed in the source language. </summary>
        public IReadOnlyList<TargetDictionaryLanguage> Translations { get; }
    }
}
