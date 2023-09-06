// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextLanguageDetectionInput : IUtf8JsonSerializable, IModelJsonSerializable<AnalyzeTextLanguageDetectionInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnalyzeTextLanguageDetectionInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnalyzeTextLanguageDetectionInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLanguageDetectionInput>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AnalysisInput))
            {
                writer.WritePropertyName("analysisInput"u8);
                if (AnalysisInput is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LanguageDetectionAnalysisInput>)AnalysisInput).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                if (Parameters is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LanguageDetectionTaskParameters>)Parameters).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AnalyzeTextLanguageDetectionInput DeserializeAnalyzeTextLanguageDetectionInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LanguageDetectionAnalysisInput> analysisInput = default;
            Optional<LanguageDetectionTaskParameters> parameters = default;
            AnalyzeTextTaskKind kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("analysisInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analysisInput = LanguageDetectionAnalysisInput.DeserializeLanguageDetectionAnalysisInput(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = LanguageDetectionTaskParameters.DeserializeLanguageDetectionTaskParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnalyzeTextLanguageDetectionInput(kind, analysisInput.Value, parameters.Value, rawData);
        }

        AnalyzeTextLanguageDetectionInput IModelJsonSerializable<AnalyzeTextLanguageDetectionInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLanguageDetectionInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextLanguageDetectionInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnalyzeTextLanguageDetectionInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLanguageDetectionInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnalyzeTextLanguageDetectionInput IModelSerializable<AnalyzeTextLanguageDetectionInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLanguageDetectionInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnalyzeTextLanguageDetectionInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnalyzeTextLanguageDetectionInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnalyzeTextLanguageDetectionInput"/> to convert. </param>
        public static implicit operator RequestContent(AnalyzeTextLanguageDetectionInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnalyzeTextLanguageDetectionInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnalyzeTextLanguageDetectionInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnalyzeTextLanguageDetectionInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
