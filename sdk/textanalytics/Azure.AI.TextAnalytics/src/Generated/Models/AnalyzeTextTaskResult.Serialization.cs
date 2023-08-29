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
    internal partial class AnalyzeTextTaskResult : IUtf8JsonSerializable, IModelJsonSerializable<AnalyzeTextTaskResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnalyzeTextTaskResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnalyzeTextTaskResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static AnalyzeTextTaskResult DeserializeAnalyzeTextTaskResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "EntityLinkingResults": return EntityLinkingTaskResult.DeserializeEntityLinkingTaskResult(element);
                    case "EntityRecognitionResults": return EntitiesTaskResult.DeserializeEntitiesTaskResult(element);
                    case "KeyPhraseExtractionResults": return KeyPhraseTaskResult.DeserializeKeyPhraseTaskResult(element);
                    case "LanguageDetectionResults": return LanguageDetectionTaskResult.DeserializeLanguageDetectionTaskResult(element);
                    case "PiiEntityRecognitionResults": return PiiTaskResult.DeserializePiiTaskResult(element);
                    case "SentimentAnalysisResults": return SentimentTaskResult.DeserializeSentimentTaskResult(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            AnalyzeTextTaskResultsKind kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownAnalyzeTextTaskResult(kind, rawData);
        }

        AnalyzeTextTaskResult IModelJsonSerializable<AnalyzeTextTaskResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextTaskResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnalyzeTextTaskResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnalyzeTextTaskResult IModelSerializable<AnalyzeTextTaskResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnalyzeTextTaskResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AnalyzeTextTaskResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AnalyzeTextTaskResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnalyzeTextTaskResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
