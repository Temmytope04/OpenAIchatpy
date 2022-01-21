// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs");
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static SearchIndexerSkill DeserializeSearchIndexerSkill(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Skills.Custom.AmlSkill": return AmlSkill.DeserializeAmlSkill(element);
                    case "#Microsoft.Skills.Custom.WebApiSkill": return WebApiSkill.DeserializeWebApiSkill(element);
                    case "#Microsoft.Skills.Text.CustomEntityLookupSkill": return CustomEntityLookupSkill.DeserializeCustomEntityLookupSkill(element);
                    case "#Microsoft.Skills.Text.EntityRecognitionSkill": return EntityRecognitionSkill.DeserializeEntityRecognitionSkill(element);
                    case "#Microsoft.Skills.Text.KeyPhraseExtractionSkill": return KeyPhraseExtractionSkill.DeserializeKeyPhraseExtractionSkill(element);
                    case "#Microsoft.Skills.Text.LanguageDetectionSkill": return LanguageDetectionSkill.DeserializeLanguageDetectionSkill(element);
                    case "#Microsoft.Skills.Text.MergeSkill": return MergeSkill.DeserializeMergeSkill(element);
                    case "#Microsoft.Skills.Text.PIIDetectionSkill": return PiiDetectionSkill.DeserializePiiDetectionSkill(element);
                    case "#Microsoft.Skills.Text.SentimentSkill": return SentimentSkill.DeserializeSentimentSkill(element);
                    case "#Microsoft.Skills.Text.SplitSkill": return SplitSkill.DeserializeSplitSkill(element);
                    case "#Microsoft.Skills.Text.TranslationSkill": return TextTranslationSkill.DeserializeTextTranslationSkill(element);
                    case "#Microsoft.Skills.Text.V3.EntityLinkingSkill": return EntityLinkingSkill.DeserializeEntityLinkingSkill(element);
                    case "#Microsoft.Skills.Text.V3.EntityRecognitionSkill": return EntityRecognitionSkillV3.DeserializeEntityRecognitionSkillV3(element);
                    case "#Microsoft.Skills.Text.V3.SentimentSkill": return SentimentSkillV3.DeserializeSentimentSkillV3(element);
                    case "#Microsoft.Skills.Util.ConditionalSkill": return ConditionalSkill.DeserializeConditionalSkill(element);
                    case "#Microsoft.Skills.Util.DocumentExtractionSkill": return DocumentExtractionSkill.DeserializeDocumentExtractionSkill(element);
                    case "#Microsoft.Skills.Util.ShaperSkill": return ShaperSkill.DeserializeShaperSkill(element);
                    case "#Microsoft.Skills.Vision.ImageAnalysisSkill": return ImageAnalysisSkill.DeserializeImageAnalysisSkill(element);
                    case "#Microsoft.Skills.Vision.OcrSkill": return OcrSkill.DeserializeOcrSkill(element);
                }
            }
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new SearchIndexerSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs);
        }
    }
}
