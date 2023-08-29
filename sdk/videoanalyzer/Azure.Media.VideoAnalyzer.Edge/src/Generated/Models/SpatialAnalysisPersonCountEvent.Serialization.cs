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
    public partial class SpatialAnalysisPersonCountEvent : IUtf8JsonSerializable, IModelJsonSerializable<SpatialAnalysisPersonCountEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SpatialAnalysisPersonCountEvent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SpatialAnalysisPersonCountEvent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonCountEvent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Trigger))
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger.Value.ToString());
            }
            if (Optional.IsDefined(OutputFrequency))
            {
                writer.WritePropertyName("outputFrequency"u8);
                writer.WriteStringValue(OutputFrequency);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteStringValue(Threshold);
            }
            if (Optional.IsDefined(Focus))
            {
                writer.WritePropertyName("focus"u8);
                writer.WriteStringValue(Focus.Value.ToString());
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

        internal static SpatialAnalysisPersonCountEvent DeserializeSpatialAnalysisPersonCountEvent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SpatialAnalysisPersonCountEventTrigger> trigger = default;
            Optional<string> outputFrequency = default;
            Optional<string> threshold = default;
            Optional<SpatialAnalysisOperationFocus> focus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trigger = new SpatialAnalysisPersonCountEventTrigger(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputFrequency"u8))
                {
                    outputFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("focus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    focus = new SpatialAnalysisOperationFocus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SpatialAnalysisPersonCountEvent(threshold.Value, Optional.ToNullable(focus), Optional.ToNullable(trigger), outputFrequency.Value, rawData);
        }

        SpatialAnalysisPersonCountEvent IModelJsonSerializable<SpatialAnalysisPersonCountEvent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonCountEvent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSpatialAnalysisPersonCountEvent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SpatialAnalysisPersonCountEvent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonCountEvent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SpatialAnalysisPersonCountEvent IModelSerializable<SpatialAnalysisPersonCountEvent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonCountEvent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSpatialAnalysisPersonCountEvent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SpatialAnalysisPersonCountEvent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SpatialAnalysisPersonCountEvent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSpatialAnalysisPersonCountEvent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
