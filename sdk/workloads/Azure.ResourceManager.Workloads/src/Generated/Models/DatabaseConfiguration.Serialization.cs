// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DatabaseConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseType))
            {
                writer.WritePropertyName("databaseType"u8);
                writer.WriteStringValue(DatabaseType.Value.ToString());
            }
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("virtualMachineConfiguration"u8);
            writer.WriteObjectValue(VirtualMachineConfiguration);
            writer.WritePropertyName("instanceCount"u8);
            writer.WriteNumberValue(InstanceCount);
            if (Optional.IsDefined(DiskConfiguration))
            {
                writer.WritePropertyName("diskConfiguration"u8);
                writer.WriteObjectValue(DiskConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static DatabaseConfiguration DeserializeDatabaseConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SapDatabaseType> databaseType = default;
            ResourceIdentifier subnetId = default;
            SapVirtualMachineConfiguration virtualMachineConfiguration = default;
            long instanceCount = default;
            Optional<DiskConfiguration> diskConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseType = new SapDatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    virtualMachineConfiguration = SapVirtualMachineConfiguration.DeserializeSapVirtualMachineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    instanceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskConfiguration = DiskConfiguration.DeserializeDiskConfiguration(property.Value);
                    continue;
                }
            }
            return new DatabaseConfiguration(Optional.ToNullable(databaseType), subnetId, virtualMachineConfiguration, instanceCount, diskConfiguration.Value);
        }
    }
}
