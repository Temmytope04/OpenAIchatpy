// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureWorkloadSAPHanaRestoreWithRehydrateRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointRehydrationInfo))
            {
                writer.WritePropertyName("recoveryPointRehydrationInfo");
                writer.WriteObjectValue(RecoveryPointRehydrationInfo);
            }
            if (Optional.IsDefined(RecoveryType))
            {
                writer.WritePropertyName("recoveryType");
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId");
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag");
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TargetInfo))
            {
                writer.WritePropertyName("targetInfo");
                writer.WriteObjectValue(TargetInfo);
            }
            if (Optional.IsDefined(RecoveryMode))
            {
                writer.WritePropertyName("recoveryMode");
                writer.WriteStringValue(RecoveryMode.Value.ToString());
            }
            if (Optional.IsDefined(TargetVirtualMachineId))
            {
                writer.WritePropertyName("targetVirtualMachineId");
                writer.WriteStringValue(TargetVirtualMachineId);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static AzureWorkloadSAPHanaRestoreWithRehydrateRequest DeserializeAzureWorkloadSAPHanaRestoreWithRehydrateRequest(JsonElement element)
        {
            Optional<RecoveryPointRehydrationInfo> recoveryPointRehydrationInfo = default;
            Optional<RecoveryType> recoveryType = default;
            Optional<string> sourceResourceId = default;
            Optional<IDictionary<string, string>> propertyBag = default;
            Optional<TargetRestoreInfo> targetInfo = default;
            Optional<RecoveryMode> recoveryMode = default;
            Optional<string> targetVirtualMachineId = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointRehydrationInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointRehydrationInfo = RecoveryPointRehydrationInfo.DeserializeRecoveryPointRehydrationInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryType = new RecoveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"))
                {
                    sourceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyBag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("targetInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetInfo = TargetRestoreInfo.DeserializeTargetRestoreInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryMode = new RecoveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVirtualMachineId"))
                {
                    targetVirtualMachineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new AzureWorkloadSAPHanaRestoreWithRehydrateRequest(objectType, Optional.ToNullable(recoveryType), sourceResourceId.Value, Optional.ToDictionary(propertyBag), targetInfo.Value, Optional.ToNullable(recoveryMode), targetVirtualMachineId.Value, recoveryPointRehydrationInfo.Value);
        }
    }
}
