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

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerHeatMapQueryExperience : IUtf8JsonSerializable, IModelJsonSerializable<TrafficManagerHeatMapQueryExperience>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrafficManagerHeatMapQueryExperience>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrafficManagerHeatMapQueryExperience>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("endpointId"u8);
            writer.WriteNumberValue(EndpointId);
            writer.WritePropertyName("queryCount"u8);
            writer.WriteNumberValue(QueryCount);
            if (Optional.IsDefined(Latency))
            {
                writer.WritePropertyName("latency"u8);
                writer.WriteNumberValue(Latency.Value);
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

        internal static TrafficManagerHeatMapQueryExperience DeserializeTrafficManagerHeatMapQueryExperience(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int endpointId = default;
            int queryCount = default;
            Optional<double> latency = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointId"u8))
                {
                    endpointId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("queryCount"u8))
                {
                    queryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("latency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latency = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrafficManagerHeatMapQueryExperience(endpointId, queryCount, Optional.ToNullable(latency), rawData);
        }

        TrafficManagerHeatMapQueryExperience IModelJsonSerializable<TrafficManagerHeatMapQueryExperience>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerHeatMapQueryExperience(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrafficManagerHeatMapQueryExperience>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrafficManagerHeatMapQueryExperience IModelSerializable<TrafficManagerHeatMapQueryExperience>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrafficManagerHeatMapQueryExperience(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TrafficManagerHeatMapQueryExperience model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TrafficManagerHeatMapQueryExperience(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrafficManagerHeatMapQueryExperience(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
