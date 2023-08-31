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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmWorkloadSqlDatabaseProtectableItem : IUtf8JsonSerializable, IModelJsonSerializable<VmWorkloadSqlDatabaseProtectableItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmWorkloadSqlDatabaseProtectableItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmWorkloadSqlDatabaseProtectableItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSqlDatabaseProtectableItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName"u8);
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ParentUniqueName))
            {
                writer.WritePropertyName("parentUniqueName"u8);
                writer.WriteStringValue(ParentUniqueName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(IsAutoProtectable))
            {
                writer.WritePropertyName("isAutoProtectable"u8);
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (Optional.IsDefined(IsAutoProtected))
            {
                writer.WritePropertyName("isAutoProtected"u8);
                writer.WriteBooleanValue(IsAutoProtected.Value);
            }
            if (Optional.IsDefined(SubInquiredItemCount))
            {
                writer.WritePropertyName("subinquireditemcount"u8);
                writer.WriteNumberValue(SubInquiredItemCount.Value);
            }
            if (Optional.IsDefined(SubProtectableItemCount))
            {
                writer.WritePropertyName("subprotectableitemcount"u8);
                writer.WriteNumberValue(SubProtectableItemCount.Value);
            }
            if (Optional.IsDefined(PreBackupValidation))
            {
                writer.WritePropertyName("prebackupvalidation"u8);
                writer.WriteObjectValue(PreBackupValidation);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
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

        internal static VmWorkloadSqlDatabaseProtectableItem DeserializeVmWorkloadSqlDatabaseProtectableItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> parentName = default;
            Optional<string> parentUniqueName = default;
            Optional<string> serverName = default;
            Optional<bool> isAutoProtectable = default;
            Optional<bool> isAutoProtected = default;
            Optional<int> subinquireditemcount = default;
            Optional<int> subprotectableitemcount = default;
            Optional<PreBackupValidation> prebackupvalidation = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string protectableItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentUniqueName"u8))
                {
                    parentUniqueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoProtected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtected = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subprotectableitemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subprotectableitemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("prebackupvalidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prebackupvalidation = PreBackupValidation.DeserializePreBackupValidation(property.Value);
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmWorkloadSqlDatabaseProtectableItem(backupManagementType.Value, workloadType.Value, protectableItemType, friendlyName.Value, Optional.ToNullable(protectionState), parentName.Value, parentUniqueName.Value, serverName.Value, Optional.ToNullable(isAutoProtectable), Optional.ToNullable(isAutoProtected), Optional.ToNullable(subinquireditemcount), Optional.ToNullable(subprotectableitemcount), prebackupvalidation.Value, rawData);
        }

        VmWorkloadSqlDatabaseProtectableItem IModelJsonSerializable<VmWorkloadSqlDatabaseProtectableItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSqlDatabaseProtectableItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadSqlDatabaseProtectableItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmWorkloadSqlDatabaseProtectableItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSqlDatabaseProtectableItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmWorkloadSqlDatabaseProtectableItem IModelSerializable<VmWorkloadSqlDatabaseProtectableItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSqlDatabaseProtectableItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmWorkloadSqlDatabaseProtectableItem(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VmWorkloadSqlDatabaseProtectableItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VmWorkloadSqlDatabaseProtectableItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmWorkloadSqlDatabaseProtectableItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
