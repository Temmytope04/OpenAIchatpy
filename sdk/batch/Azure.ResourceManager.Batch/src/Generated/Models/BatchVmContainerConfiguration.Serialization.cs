// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmContainerConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerType.ToString());
            if (Optional.IsCollectionDefined(ContainerImageNames))
            {
                writer.WritePropertyName("containerImageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContainerRegistries))
            {
                writer.WritePropertyName("containerRegistries"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerRegistries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static BatchVmContainerConfiguration DeserializeBatchVmContainerConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchVmContainerType type = default;
            Optional<IList<string>> containerImageNames = default;
            Optional<IList<BatchVmContainerRegistry>> containerRegistries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new BatchVmContainerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerImageNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    containerImageNames = array;
                    continue;
                }
                if (property.NameEquals("containerRegistries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmContainerRegistry> array = new List<BatchVmContainerRegistry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmContainerRegistry.DeserializeBatchVmContainerRegistry(item));
                    }
                    containerRegistries = array;
                    continue;
                }
            }
            return new BatchVmContainerConfiguration(type, Optional.ToList(containerImageNames), Optional.ToList(containerRegistries));
        }
    }
}
