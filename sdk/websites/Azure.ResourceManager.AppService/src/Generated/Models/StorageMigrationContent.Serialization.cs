// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StorageMigrationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AzurefilesConnectionString))
            {
                writer.WritePropertyName("azurefilesConnectionString"u8);
                writer.WriteStringValue(AzurefilesConnectionString);
            }
            if (Optional.IsDefined(AzurefilesShare))
            {
                writer.WritePropertyName("azurefilesShare"u8);
                writer.WriteStringValue(AzurefilesShare);
            }
            if (Optional.IsDefined(SwitchSiteAfterMigration))
            {
                writer.WritePropertyName("switchSiteAfterMigration"u8);
                writer.WriteBooleanValue(SwitchSiteAfterMigration.Value);
            }
            if (Optional.IsDefined(BlockWriteAccessToSite))
            {
                writer.WritePropertyName("blockWriteAccessToSite"u8);
                writer.WriteBooleanValue(BlockWriteAccessToSite.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageMigrationContent DeserializeStorageMigrationContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> azurefilesConnectionString = default;
            Optional<string> azurefilesShare = default;
            Optional<bool> switchSiteAfterMigration = default;
            Optional<bool> blockWriteAccessToSite = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("azurefilesConnectionString"u8))
                        {
                            azurefilesConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azurefilesShare"u8))
                        {
                            azurefilesShare = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("switchSiteAfterMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            switchSiteAfterMigration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("blockWriteAccessToSite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blockWriteAccessToSite = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageMigrationContent(id, name, type, systemData.Value, azurefilesConnectionString.Value, azurefilesShare.Value, Optional.ToNullable(switchSiteAfterMigration), Optional.ToNullable(blockWriteAccessToSite), kind.Value);
        }
    }
}
