// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceManagementAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources");
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ResourceManagementAction DeserializeResourceManagementAction(JsonElement element)
        {
            Optional<IList<ResourceManagementEntity>> resources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceManagementEntity> array = new List<ResourceManagementEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceManagementEntity.DeserializeResourceManagementEntity(item));
                    }
                    resources = array;
                    continue;
                }
            }
            return new ResourceManagementAction(Optional.ToList(resources));
        }
    }
}
