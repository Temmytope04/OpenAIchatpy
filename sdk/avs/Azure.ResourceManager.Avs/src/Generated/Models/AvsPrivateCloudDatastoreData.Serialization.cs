// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class AvsPrivateCloudDatastoreData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(NetAppVolume))
            {
                writer.WritePropertyName("netAppVolume");
                JsonSerializer.Serialize(writer, NetAppVolume);
            }
            if (Optional.IsDefined(DiskPoolVolume))
            {
                writer.WritePropertyName("diskPoolVolume");
                writer.WriteObjectValue(DiskPoolVolume);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AvsPrivateCloudDatastoreData DeserializeAvsPrivateCloudDatastoreData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AvsPrivateCloudDatastoreProvisioningState> provisioningState = default;
            Optional<WritableSubResource> netAppVolume = default;
            Optional<DiskPoolVolume> diskPoolVolume = default;
            Optional<DatastoreStatus> status = default;
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new AvsPrivateCloudDatastoreProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("netAppVolume"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            netAppVolume = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("diskPoolVolume"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskPoolVolume = DiskPoolVolume.DeserializeDiskPoolVolume(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new DatastoreStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AvsPrivateCloudDatastoreData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), netAppVolume, diskPoolVolume.Value, Optional.ToNullable(status));
        }
    }
}
