// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    public partial class ElasticSanVolumeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData"u8);
                writer.WriteObjectValue(CreationData);
            }
            writer.WritePropertyName("sizeGiB"u8);
            writer.WriteNumberValue(SizeGiB);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ElasticSanVolumeData DeserializeElasticSanVolumeData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> volumeId = default;
            Optional<ElasticSanVolumeDataSourceInfo> creationData = default;
            long sizeGiB = default;
            Optional<IscsiTargetInfo> storageTarget = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("volumeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            volumeId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationData = ElasticSanVolumeDataSourceInfo.DeserializeElasticSanVolumeDataSourceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sizeGiB"u8))
                        {
                            sizeGiB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("storageTarget"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageTarget = IscsiTargetInfo.DeserializeIscsiTargetInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ElasticSanVolumeData(id, name, type, systemData.Value, Optional.ToNullable(volumeId), creationData.Value, sizeGiB, storageTarget.Value);
        }
    }
}
