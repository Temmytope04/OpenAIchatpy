// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2ReprotectContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MasterTargetId))
            {
                writer.WritePropertyName("masterTargetId"u8);
                writer.WriteStringValue(MasterTargetId);
            }
            if (Optional.IsDefined(ProcessServerId))
            {
                writer.WritePropertyName("processServerId"u8);
                writer.WriteStringValue(ProcessServerId.Value);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(LogStorageAccountId))
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
