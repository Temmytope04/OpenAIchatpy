// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureVmWorkloadSAPAseSystemWorkloadItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName");
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName");
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(IsAutoProtectable))
            {
                writer.WritePropertyName("isAutoProtectable");
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (Optional.IsDefined(Subinquireditemcount))
            {
                writer.WritePropertyName("subinquireditemcount");
                writer.WriteNumberValue(Subinquireditemcount.Value);
            }
            if (Optional.IsDefined(SubWorkloadItemCount))
            {
                writer.WritePropertyName("subWorkloadItemCount");
                writer.WriteNumberValue(SubWorkloadItemCount.Value);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType");
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType");
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("workloadItemType");
            writer.WriteStringValue(WorkloadItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState");
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AzureVmWorkloadSAPAseSystemWorkloadItem DeserializeAzureVmWorkloadSAPAseSystemWorkloadItem(JsonElement element)
        {
            Optional<string> parentName = default;
            Optional<string> serverName = default;
            Optional<bool> isAutoProtectable = default;
            Optional<int> subinquireditemcount = default;
            Optional<int> subWorkloadItemCount = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string workloadItemType = default;
            Optional<string> friendlyName = default;
            Optional<ProtectionStatus> protectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subWorkloadItemCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subWorkloadItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadItemType"))
                {
                    workloadItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectionState = new ProtectionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AzureVmWorkloadSAPAseSystemWorkloadItem(backupManagementType.Value, workloadType.Value, workloadItemType, friendlyName.Value, Optional.ToNullable(protectionState), parentName.Value, serverName.Value, Optional.ToNullable(isAutoProtectable), Optional.ToNullable(subinquireditemcount), Optional.ToNullable(subWorkloadItemCount));
        }
    }
}
