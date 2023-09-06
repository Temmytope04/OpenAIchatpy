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
    internal partial struct DetectedLanguageInternal : IUtf8JsonSerializable, IModelJsonSerializable<DetectedLanguageInternal>, IModelJsonSerializable<object>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DetectedLanguageInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DetectedLanguageInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            else
            {
                writer.WriteNull("name");
            }
            if (Iso6391Name != null)
            {
                writer.WritePropertyName("iso6391Name"u8);
                writer.WriteStringValue(Iso6391Name);
            }
            else
            {
                writer.WriteNull("iso6391Name");
            }
            writer.WritePropertyName("confidenceScore"u8);
            writer.WriteNumberValue(ConfidenceScore);
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

        void IModelJsonSerializable<object>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            else
            {
                writer.WriteNull("name");
            }
            if (Iso6391Name != null)
            {
                writer.WritePropertyName("iso6391Name"u8);
                writer.WriteStringValue(Iso6391Name);
            }
            else
            {
                writer.WriteNull("iso6391Name");
            }
            writer.WritePropertyName("confidenceScore"u8);
            writer.WriteNumberValue(ConfidenceScore);
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

        internal static DetectedLanguageInternal DeserializeDetectedLanguageInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            string name = default;
            string iso6391Name = default;
            double confidenceScore = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iso6391Name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        iso6391Name = null;
                        continue;
                    }
                    iso6391Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DetectedLanguageInternal(name, iso6391Name, confidenceScore, rawData);
        }

        DetectedLanguageInternal IModelJsonSerializable<DetectedLanguageInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectedLanguageInternal(doc.RootElement, options);
        }

        object IModelJsonSerializable<object>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectedLanguageInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DetectedLanguageInternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DetectedLanguageInternal IModelSerializable<DetectedLanguageInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDetectedLanguageInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<object>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        object IModelSerializable<object>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectedLanguageInternal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDetectedLanguageInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DetectedLanguageInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DetectedLanguageInternal"/> to convert. </param>
        public static implicit operator RequestContent(DetectedLanguageInternal model)
        {
            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DetectedLanguageInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DetectedLanguageInternal(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDetectedLanguageInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
