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
    public partial class VMwareCbtMigrationDetails : IUtf8JsonSerializable, IModelJsonSerializable<VMwareCbtMigrationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VMwareCbtMigrationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VMwareCbtMigrationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtMigrationDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType);
            }
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
            if (Optional.IsDefined(TargetResourceGroupId))
            {
                writer.WritePropertyName("targetResourceGroupId"u8);
                writer.WriteStringValue(TargetResourceGroupId);
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
            if (Optional.IsCollectionDefined(ProtectedDisks))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetNetworkId))
            {
                writer.WritePropertyName("targetNetworkId"u8);
                writer.WriteStringValue(TargetNetworkId);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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
            if (Optional.IsDefined(PerformAutoResync))
            {
                writer.WritePropertyName("performAutoResync"u8);
                writer.WriteStringValue(PerformAutoResync);
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
            if (Optional.IsCollectionDefined(SupportedOSVersions))
            {
                writer.WritePropertyName("supportedOSVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedOSVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static VMwareCbtMigrationDetails DeserializeVMwareCbtMigrationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> vmwareMachineId = default;
            Optional<string> osType = default;
            Optional<string> osName = default;
            Optional<string> firmwareType = default;
            Optional<string> targetGeneration = default;
            Optional<string> licenseType = default;
            Optional<string> sqlServerLicenseType = default;
            Optional<ResourceIdentifier> dataMoverRunAsAccountId = default;
            Optional<ResourceIdentifier> snapshotRunAsAccountId = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<string> targetVmName = default;
            Optional<string> targetVmSize = default;
            Optional<string> targetLocation = default;
            Optional<ResourceIdentifier> targetResourceGroupId = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<ResourceIdentifier> confidentialVmKeyVaultId = default;
            Optional<VMwareCbtSecurityProfileProperties> targetVmSecurityProfile = default;
            Optional<ResourceIdentifier> targetBootDiagnosticsStorageAccountId = default;
            Optional<IReadOnlyDictionary<string, string>> targetVmTags = default;
            Optional<IReadOnlyList<VMwareCbtProtectedDiskDetails>> protectedDisks = default;
            Optional<ResourceIdentifier> targetNetworkId = default;
            Optional<ResourceIdentifier> testNetworkId = default;
            Optional<IReadOnlyList<VMwareCbtNicDetails>> vmNics = default;
            Optional<IReadOnlyDictionary<string, string>> targetNicTags = default;
            Optional<ResourceIdentifier> migrationRecoveryPointId = default;
            Optional<DateTimeOffset> lastRecoveryPointReceived = default;
            Optional<ResourceIdentifier> lastRecoveryPointId = default;
            Optional<int> initialSeedingProgressPercentage = default;
            Optional<int> migrationProgressPercentage = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<int> resumeProgressPercentage = default;
            Optional<long> initialSeedingRetryCount = default;
            Optional<long> resyncRetryCount = default;
            Optional<long> resumeRetryCount = default;
            Optional<string> resyncRequired = default;
            Optional<SiteRecoveryResyncState> resyncState = default;
            Optional<string> performAutoResync = default;
            Optional<IReadOnlyDictionary<string, string>> seedDiskTags = default;
            Optional<IReadOnlyDictionary<string, string>> targetDiskTags = default;
            Optional<IReadOnlyList<string>> supportedOSVersions = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareType"u8))
                {
                    firmwareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetGeneration"u8))
                {
                    targetGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    sqlServerLicenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataMoverRunAsAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataMoverRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("snapshotRunAsAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareCbtProtectedDiskDetails> array = new List<VMwareCbtProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtProtectedDiskDetails.DeserializeVMwareCbtProtectedDiskDetails(item));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareCbtNicDetails> array = new List<VMwareCbtNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtNicDetails.DeserializeVMwareCbtNicDetails(item));
                    }
                    vmNics = array;
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
                if (property.NameEquals("migrationRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialSeedingProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSeedingProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("migrationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resumeProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resumeProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialSeedingRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSeedingRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resumeRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resumeRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncState = new SiteRecoveryResyncState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performAutoResync"u8))
                {
                    performAutoResync = property.Value.GetString();
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
                if (property.NameEquals("supportedOSVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedOSVersions = array;
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
            return new VMwareCbtMigrationDetails(instanceType, vmwareMachineId.Value, osType.Value, osName.Value, firmwareType.Value, targetGeneration.Value, licenseType.Value, sqlServerLicenseType.Value, dataMoverRunAsAccountId.Value, snapshotRunAsAccountId.Value, storageAccountId.Value, targetVmName.Value, targetVmSize.Value, targetLocation.Value, targetResourceGroupId.Value, targetAvailabilitySetId.Value, targetAvailabilityZone.Value, targetProximityPlacementGroupId.Value, confidentialVmKeyVaultId.Value, targetVmSecurityProfile.Value, targetBootDiagnosticsStorageAccountId.Value, Optional.ToDictionary(targetVmTags), Optional.ToList(protectedDisks), targetNetworkId.Value, testNetworkId.Value, Optional.ToList(vmNics), Optional.ToDictionary(targetNicTags), migrationRecoveryPointId.Value, Optional.ToNullable(lastRecoveryPointReceived), lastRecoveryPointId.Value, Optional.ToNullable(initialSeedingProgressPercentage), Optional.ToNullable(migrationProgressPercentage), Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resumeProgressPercentage), Optional.ToNullable(initialSeedingRetryCount), Optional.ToNullable(resyncRetryCount), Optional.ToNullable(resumeRetryCount), resyncRequired.Value, Optional.ToNullable(resyncState), performAutoResync.Value, Optional.ToDictionary(seedDiskTags), Optional.ToDictionary(targetDiskTags), Optional.ToList(supportedOSVersions), rawData);
        }

        VMwareCbtMigrationDetails IModelJsonSerializable<VMwareCbtMigrationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtMigrationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtMigrationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VMwareCbtMigrationDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtMigrationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VMwareCbtMigrationDetails IModelSerializable<VMwareCbtMigrationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtMigrationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVMwareCbtMigrationDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VMwareCbtMigrationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VMwareCbtMigrationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVMwareCbtMigrationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
