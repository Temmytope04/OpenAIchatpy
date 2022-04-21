// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ManagementLockData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("level");
            writer.WriteStringValue(Level.ToString());
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsCollectionDefined(Owners))
            {
                writer.WritePropertyName("owners");
                writer.WriteStartArray();
                foreach (var item in Owners)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagementLockData DeserializeManagementLockData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ManagementLockLevel level = default;
            Optional<string> notes = default;
            Optional<IList<ManagementLockOwner>> owners = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("level"))
                        {
                            level = new ManagementLockLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("notes"))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("owners"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ManagementLockOwner> array = new List<ManagementLockOwner>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagementLockOwner.DeserializeManagementLockOwner(item));
                            }
                            owners = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagementLockData(id, name, type, systemData, level, notes.Value, Optional.ToList(owners));
        }
    }
}
