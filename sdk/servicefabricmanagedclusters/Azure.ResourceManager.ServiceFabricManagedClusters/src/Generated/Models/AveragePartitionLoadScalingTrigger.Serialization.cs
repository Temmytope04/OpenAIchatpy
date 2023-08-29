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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class AveragePartitionLoadScalingTrigger : IUtf8JsonSerializable, IModelJsonSerializable<AveragePartitionLoadScalingTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AveragePartitionLoadScalingTrigger>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AveragePartitionLoadScalingTrigger>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AveragePartitionLoadScalingTrigger>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            writer.WritePropertyName("lowerLoadThreshold"u8);
            writer.WriteNumberValue(LowerLoadThreshold);
            writer.WritePropertyName("upperLoadThreshold"u8);
            writer.WriteNumberValue(UpperLoadThreshold);
            writer.WritePropertyName("scaleInterval"u8);
            writer.WriteStringValue(ScaleInterval);
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

        internal static AveragePartitionLoadScalingTrigger DeserializeAveragePartitionLoadScalingTrigger(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricName = default;
            double lowerLoadThreshold = default;
            double upperLoadThreshold = default;
            string scaleInterval = default;
            ServiceScalingTriggerKind kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lowerLoadThreshold"u8))
                {
                    lowerLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperLoadThreshold"u8))
                {
                    upperLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("scaleInterval"u8))
                {
                    scaleInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingTriggerKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AveragePartitionLoadScalingTrigger(kind, metricName, lowerLoadThreshold, upperLoadThreshold, scaleInterval, rawData);
        }

        AveragePartitionLoadScalingTrigger IModelJsonSerializable<AveragePartitionLoadScalingTrigger>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AveragePartitionLoadScalingTrigger>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAveragePartitionLoadScalingTrigger(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AveragePartitionLoadScalingTrigger>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AveragePartitionLoadScalingTrigger>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AveragePartitionLoadScalingTrigger IModelSerializable<AveragePartitionLoadScalingTrigger>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AveragePartitionLoadScalingTrigger>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAveragePartitionLoadScalingTrigger(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AveragePartitionLoadScalingTrigger model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AveragePartitionLoadScalingTrigger(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAveragePartitionLoadScalingTrigger(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
