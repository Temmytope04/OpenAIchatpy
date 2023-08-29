// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class LanguageDetectionResult : IUtf8JsonSerializable, IModelJsonSerializable<LanguageDetectionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LanguageDetectionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LanguageDetectionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LanguageDetectionResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("documents"u8);
            writer.WriteStartArray();
            foreach (var item in Documents)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics);
            }
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
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

        internal static LanguageDetectionResult DeserializeLanguageDetectionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LanguageDetectionDocumentResult> documents = default;
            IList<DocumentError> errors = default;
            Optional<TextDocumentBatchStatistics> statistics = default;
            string modelVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"u8))
                {
                    List<LanguageDetectionDocumentResult> array = new List<LanguageDetectionDocumentResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LanguageDetectionDocumentResult.DeserializeLanguageDetectionDocumentResult(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LanguageDetectionResult(errors, statistics.Value, modelVersion, documents, rawData);
        }

        LanguageDetectionResult IModelJsonSerializable<LanguageDetectionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LanguageDetectionResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLanguageDetectionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LanguageDetectionResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LanguageDetectionResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LanguageDetectionResult IModelSerializable<LanguageDetectionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LanguageDetectionResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLanguageDetectionResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LanguageDetectionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LanguageDetectionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLanguageDetectionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
