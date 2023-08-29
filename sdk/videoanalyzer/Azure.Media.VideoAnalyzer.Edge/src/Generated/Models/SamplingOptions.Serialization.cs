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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SamplingOptions : IUtf8JsonSerializable, IModelJsonSerializable<SamplingOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SamplingOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SamplingOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SkipSamplesWithoutAnnotation))
            {
                writer.WritePropertyName("skipSamplesWithoutAnnotation"u8);
                writer.WriteStringValue(SkipSamplesWithoutAnnotation);
            }
            if (Optional.IsDefined(MaximumSamplesPerSecond))
            {
                writer.WritePropertyName("maximumSamplesPerSecond"u8);
                writer.WriteStringValue(MaximumSamplesPerSecond);
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

        internal static SamplingOptions DeserializeSamplingOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> skipSamplesWithoutAnnotation = default;
            Optional<string> maximumSamplesPerSecond = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipSamplesWithoutAnnotation"u8))
                {
                    skipSamplesWithoutAnnotation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumSamplesPerSecond"u8))
                {
                    maximumSamplesPerSecond = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SamplingOptions(skipSamplesWithoutAnnotation.Value, maximumSamplesPerSecond.Value, rawData);
        }

        SamplingOptions IModelJsonSerializable<SamplingOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSamplingOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SamplingOptions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SamplingOptions IModelSerializable<SamplingOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSamplingOptions(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SamplingOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SamplingOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSamplingOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
