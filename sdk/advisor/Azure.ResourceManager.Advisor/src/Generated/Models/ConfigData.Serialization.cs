// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class ConfigData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Exclude))
            {
                writer.WritePropertyName("exclude"u8);
                writer.WriteBooleanValue(Exclude.Value);
            }
            if (Optional.IsDefined(LowCpuThreshold))
            {
                writer.WritePropertyName("lowCpuThreshold"u8);
                writer.WriteStringValue(LowCpuThreshold.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Digests))
            {
                writer.WritePropertyName("digests"u8);
                writer.WriteStartArray();
                foreach (var item in Digests)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConfigData DeserializeConfigData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> exclude = default;
            Optional<CpuThreshold> lowCpuThreshold = default;
            Optional<IList<DigestConfig>> digests = default;
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
                        if (property0.NameEquals("exclude"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exclude = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lowCpuThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lowCpuThreshold = new CpuThreshold(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("digests"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DigestConfig> array = new List<DigestConfig>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DigestConfig.DeserializeDigestConfig(item));
                            }
                            digests = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConfigData(id, name, type, systemData.Value, Optional.ToNullable(exclude), Optional.ToNullable(lowCpuThreshold), Optional.ToList(digests));
        }
    }
}
