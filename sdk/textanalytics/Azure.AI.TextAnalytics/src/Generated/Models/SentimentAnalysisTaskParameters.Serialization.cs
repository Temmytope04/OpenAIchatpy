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
    internal partial class SentimentAnalysisTaskParameters : IUtf8JsonSerializable, IModelJsonSerializable<SentimentAnalysisTaskParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SentimentAnalysisTaskParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SentimentAnalysisTaskParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTaskParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OpinionMining))
            {
                writer.WritePropertyName("opinionMining"u8);
                writer.WriteBooleanValue(OpinionMining.Value);
            }
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
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

        internal static SentimentAnalysisTaskParameters DeserializeSentimentAnalysisTaskParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> opinionMining = default;
            Optional<StringIndexType> stringIndexType = default;
            Optional<string> modelVersion = default;
            Optional<bool> loggingOptOut = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("opinionMining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    opinionMining = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SentimentAnalysisTaskParameters(Optional.ToNullable(loggingOptOut), modelVersion.Value, Optional.ToNullable(opinionMining), Optional.ToNullable(stringIndexType), rawData);
        }

        SentimentAnalysisTaskParameters IModelJsonSerializable<SentimentAnalysisTaskParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTaskParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSentimentAnalysisTaskParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SentimentAnalysisTaskParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTaskParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SentimentAnalysisTaskParameters IModelSerializable<SentimentAnalysisTaskParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTaskParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSentimentAnalysisTaskParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SentimentAnalysisTaskParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SentimentAnalysisTaskParameters"/> to convert. </param>
        public static implicit operator RequestContent(SentimentAnalysisTaskParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SentimentAnalysisTaskParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SentimentAnalysisTaskParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSentimentAnalysisTaskParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
