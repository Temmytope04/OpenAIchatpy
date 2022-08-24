// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class KustoDatabaseDataSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("kustoDatabaseResourceId");
            writer.WriteStringValue(KustoDatabaseResourceId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static KustoDatabaseDataSet DeserializeKustoDatabaseDataSet(JsonElement element)
        {
            DataSetKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> dataSetId = default;
            string kustoDatabaseResourceId = default;
            Optional<AzureLocation> location = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new DataSetKind(property.Value.GetString());
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
                        if (property0.NameEquals("dataSetId"))
                        {
                            dataSetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kustoDatabaseResourceId"))
                        {
                            kustoDatabaseResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("location"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            location = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new KustoDatabaseDataSet(id, name, type, systemData.Value, kind, dataSetId.Value, kustoDatabaseResourceId, Optional.ToNullable(location), Optional.ToNullable(provisioningState));
        }
    }
}
