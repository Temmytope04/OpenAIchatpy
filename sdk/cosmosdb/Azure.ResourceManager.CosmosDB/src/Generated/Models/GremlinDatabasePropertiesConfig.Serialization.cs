// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GremlinDatabasePropertiesConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Throughput))
            {
                writer.WritePropertyName("throughput"u8);
                writer.WriteNumberValue(Throughput.Value);
            }
            if (Optional.IsDefined(AutoscaleSettings))
            {
                writer.WritePropertyName("autoscaleSettings"u8);
                writer.WriteObjectValue(AutoscaleSettings);
            }
            writer.WriteEndObject();
        }

        internal static GremlinDatabasePropertiesConfig DeserializeGremlinDatabasePropertiesConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> throughput = default;
            Optional<AutoscaleSettings> autoscaleSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettings.DeserializeAutoscaleSettings(property.Value);
                    continue;
                }
            }
            return new GremlinDatabasePropertiesConfig(Optional.ToNullable(throughput), autoscaleSettings.Value);
        }
    }
}
