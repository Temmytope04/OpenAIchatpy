// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ServerKeyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerKeyType))
            {
                writer.WritePropertyName("serverKeyType");
                writer.WriteStringValue(ServerKeyType.Value.ToString());
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerKeyData DeserializeServerKeyData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> subregion = default;
            Optional<ServerKeyType> serverKeyType = default;
            Optional<Uri> uri = default;
            Optional<string> thumbprint = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<bool> autoRotationEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("subregion"))
                        {
                            subregion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverKeyType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverKeyType = new ServerKeyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uri = null;
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoRotationEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoRotationEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerKeyData(id, name, type, systemData.Value, kind.Value, Optional.ToNullable(location), subregion.Value, Optional.ToNullable(serverKeyType), uri.Value, thumbprint.Value, Optional.ToNullable(creationDate), Optional.ToNullable(autoRotationEnabled));
        }
    }
}
