// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppBackupInfo : IUtf8JsonSerializable, IModelJsonSerializable<WebAppBackupInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebAppBackupInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebAppBackupInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupName))
            {
                writer.WritePropertyName("backupName"u8);
                writer.WriteStringValue(BackupName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BackupSchedule))
            {
                writer.WritePropertyName("backupSchedule"u8);
                writer.WriteObjectValue(BackupSchedule);
            }
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static WebAppBackupInfo DeserializeWebAppBackupInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> backupName = default;
            Optional<bool> enabled = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<WebAppBackupSchedule> backupSchedule = default;
            Optional<IList<AppServiceDatabaseBackupSetting>> databases = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("backupName"u8))
                        {
                            backupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("backupSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupSchedule = WebAppBackupSchedule.DeserializeWebAppBackupSchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("databases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceDatabaseBackupSetting> array = new List<AppServiceDatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceDatabaseBackupSetting.DeserializeAppServiceDatabaseBackupSetting(item));
                            }
                            databases = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebAppBackupInfo(id, name, type, systemData.Value, backupName.Value, Optional.ToNullable(enabled), storageAccountUrl.Value, backupSchedule.Value, Optional.ToList(databases), kind.Value, rawData);
        }

        WebAppBackupInfo IModelJsonSerializable<WebAppBackupInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppBackupInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebAppBackupInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebAppBackupInfo IModelSerializable<WebAppBackupInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebAppBackupInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(WebAppBackupInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator WebAppBackupInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebAppBackupInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
