// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    public partial class DataMigrationServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicKey))
            {
                writer.WritePropertyName("publicKey"u8);
                writer.WriteStringValue(PublicKey);
            }
            if (Optional.IsDefined(VirtualSubnetId))
            {
                writer.WritePropertyName("virtualSubnetId"u8);
                writer.WriteStringValue(VirtualSubnetId);
            }
            if (Optional.IsDefined(VirtualNicId))
            {
                writer.WritePropertyName("virtualNicId"u8);
                writer.WriteStringValue(VirtualNicId);
            }
            if (Optional.IsDefined(AutoStopDelay))
            {
                writer.WritePropertyName("autoStopDelay"u8);
                writer.WriteStringValue(AutoStopDelay);
            }
            if (Optional.IsDefined(DeleteResourcesOnStop))
            {
                writer.WritePropertyName("deleteResourcesOnStop"u8);
                writer.WriteBooleanValue(DeleteResourcesOnStop.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataMigrationServiceData DeserializeDataMigrationServiceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<string> kind = default;
            Optional<ServiceSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ServiceProvisioningState> provisioningState = default;
            Optional<string> publicKey = default;
            Optional<string> virtualSubnetId = default;
            Optional<string> virtualNicId = default;
            Optional<string> autoStopDelay = default;
            Optional<bool> deleteResourcesOnStop = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ServiceSku.DeserializeServiceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ServiceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicKey"u8))
                        {
                            publicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualSubnetId"u8))
                        {
                            virtualSubnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNicId"u8))
                        {
                            virtualNicId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoStopDelay"u8))
                        {
                            autoStopDelay = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleteResourcesOnStop"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteResourcesOnStop = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataMigrationServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), kind.Value, sku.Value, Optional.ToNullable(provisioningState), publicKey.Value, virtualSubnetId.Value, virtualNicId.Value, autoStopDelay.Value, Optional.ToNullable(deleteResourcesOnStop));
        }
    }
}
