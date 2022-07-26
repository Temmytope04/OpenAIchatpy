// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementCacheData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString");
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(UseFromLocation))
            {
                writer.WritePropertyName("useFromLocation");
                writer.WriteStringValue(UseFromLocation);
            }
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceUri.AbsoluteUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiManagementCacheData DeserializeApiManagementCacheData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> connectionString = default;
            Optional<string> useFromLocation = default;
            Optional<Uri> resourceId = default;
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
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionString"))
                        {
                            connectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("useFromLocation"))
                        {
                            useFromLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                resourceId = null;
                                continue;
                            }
                            resourceId = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiManagementCacheData(id, name, type, systemData.Value, description.Value, connectionString.Value, useFromLocation.Value, resourceId.Value);
        }
    }
}
