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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtEnableMigrationContent : IUtf8JsonSerializable, IModelJsonSerializable<VMwareCbtEnableMigrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VMwareCbtEnableMigrationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VMwareCbtEnableMigrationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtEnableMigrationContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("vmwareMachineId"u8);
            writer.WriteStringValue(VMwareMachineId);
            writer.WritePropertyName("disksToInclude"u8);
            writer.WriteStartArray();
            foreach (var item in DisksToInclude)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (Optional.IsDefined(PerformSqlBulkRegistration))
            {
                writer.WritePropertyName("performSqlBulkRegistration"u8);
                writer.WriteStringValue(PerformSqlBulkRegistration);
            }
            writer.WritePropertyName("dataMoverRunAsAccountId"u8);
            writer.WriteStringValue(DataMoverRunAsAccountId);
            writer.WritePropertyName("snapshotRunAsAccountId"u8);
            writer.WriteStringValue(SnapshotRunAsAccountId);
            if (Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            writer.WritePropertyName("targetResourceGroupId"u8);
            writer.WriteStringValue(TargetResourceGroupId);
            writer.WritePropertyName("targetNetworkId"u8);
            writer.WriteStringValue(TargetNetworkId);
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsDefined(TargetSubnetName))
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (Optional.IsDefined(TestSubnetName))
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(ConfidentialVmKeyVaultId))
            {
                writer.WritePropertyName("confidentialVmKeyVaultId"u8);
                writer.WriteStringValue(ConfidentialVmKeyVaultId);
            }
            if (Optional.IsDefined(TargetVmSecurityProfile))
            {
                writer.WritePropertyName("targetVmSecurityProfile"u8);
                writer.WriteObjectValue(TargetVmSecurityProfile);
            }
            if (Optional.IsDefined(TargetBootDiagnosticsStorageAccountId))
            {
                writer.WritePropertyName("targetBootDiagnosticsStorageAccountId"u8);
                writer.WriteStringValue(TargetBootDiagnosticsStorageAccountId);
            }
            if (Optional.IsDefined(PerformAutoResync))
            {
                writer.WritePropertyName("performAutoResync"u8);
                writer.WriteStringValue(PerformAutoResync);
            }
            if (Optional.IsCollectionDefined(TargetVmTags))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SeedDiskTags))
            {
                writer.WritePropertyName("seedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetDiskTags))
            {
                writer.WritePropertyName("targetDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetNicTags))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static VMwareCbtEnableMigrationContent DeserializeVMwareCbtEnableMigrationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareMachineId = default;
            IList<VMwareCbtDiskContent> disksToInclude = default;
            Optional<SiteRecoveryLicenseType> licenseType = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            Optional<string> performSqlBulkRegistration = default;
            ResourceIdentifier dataMoverRunAsAccountId = default;
            ResourceIdentifier snapshotRunAsAccountId = default;
            Optional<string> targetVmName = default;
            Optional<string> targetVmSize = default;
            ResourceIdentifier targetResourceGroupId = default;
            ResourceIdentifier targetNetworkId = default;
            Optional<ResourceIdentifier> testNetworkId = default;
            Optional<string> targetSubnetName = default;
            Optional<string> testSubnetName = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<ResourceIdentifier> confidentialVmKeyVaultId = default;
            Optional<VMwareCbtSecurityProfileProperties> targetVmSecurityProfile = default;
            Optional<ResourceIdentifier> targetBootDiagnosticsStorageAccountId = default;
            Optional<string> performAutoResync = default;
            Optional<IDictionary<string, string>> targetVmTags = default;
            Optional<IDictionary<string, string>> seedDiskTags = default;
            Optional<IDictionary<string, string>> targetDiskTags = default;
            Optional<IDictionary<string, string>> targetNicTags = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareMachineId"u8))
                {
                    vmwareMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    List<VMwareCbtDiskContent> array = new List<VMwareCbtDiskContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtDiskContent.DeserializeVMwareCbtDiskContent(item));
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performSqlBulkRegistration"u8))
                {
                    performSqlBulkRegistration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataMoverRunAsAccountId"u8))
                {
                    dataMoverRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("snapshotRunAsAccountId"u8))
                {
                    snapshotRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("confidentialVmKeyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidentialVmKeyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSecurityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVmSecurityProfile = VMwareCbtSecurityProfileProperties.DeserializeVMwareCbtSecurityProfileProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("targetBootDiagnosticsStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBootDiagnosticsStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performAutoResync"u8))
                {
                    performAutoResync = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
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
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("seedDiskTags"u8))
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
                    seedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetDiskTags"u8))
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
                    targetDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
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
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VMwareCbtEnableMigrationContent(instanceType, vmwareMachineId, disksToInclude, Optional.ToNullable(licenseType), Optional.ToNullable(sqlServerLicenseType), performSqlBulkRegistration.Value, dataMoverRunAsAccountId, snapshotRunAsAccountId, targetVmName.Value, targetVmSize.Value, targetResourceGroupId, targetNetworkId, testNetworkId.Value, targetSubnetName.Value, testSubnetName.Value, targetAvailabilitySetId.Value, targetAvailabilityZone.Value, targetProximityPlacementGroupId.Value, confidentialVmKeyVaultId.Value, targetVmSecurityProfile.Value, targetBootDiagnosticsStorageAccountId.Value, performAutoResync.Value, Optional.ToDictionary(targetVmTags), Optional.ToDictionary(seedDiskTags), Optional.ToDictionary(targetDiskTags), Optional.ToDictionary(targetNicTags), rawData);
        }

        VMwareCbtEnableMigrationContent IModelJsonSerializable<VMwareCbtEnableMigrationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtEnableMigrationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtEnableMigrationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VMwareCbtEnableMigrationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtEnableMigrationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VMwareCbtEnableMigrationContent IModelSerializable<VMwareCbtEnableMigrationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtEnableMigrationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVMwareCbtEnableMigrationContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VMwareCbtEnableMigrationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VMwareCbtEnableMigrationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVMwareCbtEnableMigrationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
