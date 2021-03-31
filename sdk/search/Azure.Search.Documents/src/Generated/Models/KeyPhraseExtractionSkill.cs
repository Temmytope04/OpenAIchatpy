// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A skill that uses text analytics for key phrase extraction. </summary>
    public partial class KeyPhraseExtractionSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of KeyPhraseExtractionSkill. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public KeyPhraseExtractionSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (outputs == null)
            {
                throw new ArgumentNullException(nameof(outputs));
            }

            ODataType = "#Microsoft.Skills.Text.KeyPhraseExtractionSkill";
        }

        /// <summary> Initializes a new instance of KeyPhraseExtractionSkill. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character &apos;#&apos;. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is en. </param>
        /// <param name="maxKeyPhraseCount"> A number indicating how many key phrases to return. If absent, all identified key phrases will be returned. </param>
        /// <param name="modelVersion"> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </param>
        internal KeyPhraseExtractionSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, KeyPhraseExtractionSkillLanguage? defaultLanguageCode, int? maxKeyPhraseCount, string modelVersion) : base(oDataType, name, description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            MaxKeyPhraseCount = maxKeyPhraseCount;
            ModelVersion = modelVersion;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.KeyPhraseExtractionSkill";
        }

        /// <summary> A value indicating which language code to use. Default is en. </summary>
        public KeyPhraseExtractionSkillLanguage? DefaultLanguageCode { get; set; }
        /// <summary> A number indicating how many key phrases to return. If absent, all identified key phrases will be returned. </summary>
        public int? MaxKeyPhraseCount { get; set; }
        /// <summary> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </summary>
        public string ModelVersion { get; set; }
    }
}
