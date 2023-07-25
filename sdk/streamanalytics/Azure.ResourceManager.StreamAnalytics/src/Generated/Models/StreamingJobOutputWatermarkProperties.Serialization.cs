// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamingJobOutputWatermarkProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WatermarkMode))
            {
                writer.WritePropertyName("watermarkMode"u8);
                writer.WriteStringValue(WatermarkMode.Value.ToString());
            }
            if (Optional.IsDefined(MaxWatermarkDifferenceAcrossPartitions))
            {
                writer.WritePropertyName("maxWatermarkDifferenceAcrossPartitions"u8);
                writer.WriteStringValue(MaxWatermarkDifferenceAcrossPartitions);
            }
            writer.WriteEndObject();
        }

        internal static StreamingJobOutputWatermarkProperties DeserializeStreamingJobOutputWatermarkProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamingJobOutputWatermarkMode> watermarkMode = default;
            Optional<string> maxWatermarkDifferenceAcrossPartitions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("watermarkMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    watermarkMode = new StreamingJobOutputWatermarkMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxWatermarkDifferenceAcrossPartitions"u8))
                {
                    maxWatermarkDifferenceAcrossPartitions = property.Value.GetString();
                    continue;
                }
            }
            return new StreamingJobOutputWatermarkProperties(Optional.ToNullable(watermarkMode), maxWatermarkDifferenceAcrossPartitions.Value);
        }
    }
}
