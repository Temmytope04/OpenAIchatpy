// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class DatabaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Charset))
            {
                writer.WritePropertyName("charset");
                writer.WriteStringValue(Charset);
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DatabaseData DeserializeDatabaseData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> charset = default;
            Optional<string> collation = default;
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("charset"))
                        {
                            charset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("collation"))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DatabaseData(id, name, type, systemData.Value, charset.Value, collation.Value);
        }
    }
}
