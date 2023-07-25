// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeGroupVolume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("creationToken"u8);
            writer.WriteStringValue(CreationToken);
            if (Optional.IsDefined(ServiceLevel))
            {
                writer.WritePropertyName("serviceLevel"u8);
                writer.WriteStringValue(ServiceLevel.Value.ToString());
            }
            writer.WritePropertyName("usageThreshold"u8);
            writer.WriteNumberValue(UsageThreshold);
            if (Optional.IsDefined(ExportPolicy))
            {
                writer.WritePropertyName("exportPolicy"u8);
                writer.WriteObjectValue(ExportPolicy);
            }
            if (Optional.IsCollectionDefined(ProtocolTypes))
            {
                writer.WritePropertyName("protocolTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ProtocolTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SnapshotId))
            {
                if (SnapshotId != null)
                {
                    writer.WritePropertyName("snapshotId"u8);
                    writer.WriteStringValue(SnapshotId);
                }
                else
                {
                    writer.WriteNull("snapshotId");
                }
            }
            if (Optional.IsDefined(DeleteBaseSnapshot))
            {
                writer.WritePropertyName("deleteBaseSnapshot"u8);
                writer.WriteBooleanValue(DeleteBaseSnapshot.Value);
            }
            if (Optional.IsDefined(BackupId))
            {
                if (BackupId != null)
                {
                    writer.WritePropertyName("backupId"u8);
                    writer.WriteStringValue(BackupId);
                }
                else
                {
                    writer.WriteNull("backupId");
                }
            }
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            if (Optional.IsDefined(NetworkFeatures))
            {
                writer.WritePropertyName("networkFeatures"u8);
                writer.WriteStringValue(NetworkFeatures.Value.ToString());
            }
            if (Optional.IsDefined(VolumeType))
            {
                writer.WritePropertyName("volumeType"u8);
                writer.WriteStringValue(VolumeType);
            }
            if (Optional.IsDefined(DataProtection))
            {
                writer.WritePropertyName("dataProtection"u8);
                writer.WriteObjectValue(DataProtection);
            }
            if (Optional.IsDefined(IsRestoring))
            {
                writer.WritePropertyName("isRestoring"u8);
                writer.WriteBooleanValue(IsRestoring.Value);
            }
            if (Optional.IsDefined(IsSnapshotDirectoryVisible))
            {
                writer.WritePropertyName("snapshotDirectoryVisible"u8);
                writer.WriteBooleanValue(IsSnapshotDirectoryVisible.Value);
            }
            if (Optional.IsDefined(IsKerberosEnabled))
            {
                writer.WritePropertyName("kerberosEnabled"u8);
                writer.WriteBooleanValue(IsKerberosEnabled.Value);
            }
            if (Optional.IsDefined(SecurityStyle))
            {
                writer.WritePropertyName("securityStyle"u8);
                writer.WriteStringValue(SecurityStyle.Value.ToString());
            }
            if (Optional.IsDefined(IsSmbEncryptionEnabled))
            {
                writer.WritePropertyName("smbEncryption"u8);
                writer.WriteBooleanValue(IsSmbEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(SmbAccessBasedEnumeration))
            {
                writer.WritePropertyName("smbAccessBasedEnumeration"u8);
                writer.WriteStringValue(SmbAccessBasedEnumeration.Value.ToString());
            }
            if (Optional.IsDefined(SmbNonBrowsable))
            {
                writer.WritePropertyName("smbNonBrowsable"u8);
                writer.WriteStringValue(SmbNonBrowsable.Value.ToString());
            }
            if (Optional.IsDefined(IsSmbContinuouslyAvailable))
            {
                writer.WritePropertyName("smbContinuouslyAvailable"u8);
                writer.WriteBooleanValue(IsSmbContinuouslyAvailable.Value);
            }
            if (Optional.IsDefined(ThroughputMibps))
            {
                if (ThroughputMibps != null)
                {
                    writer.WritePropertyName("throughputMibps"u8);
                    writer.WriteNumberValue(ThroughputMibps.Value);
                }
                else
                {
                    writer.WriteNull("throughputMibps");
                }
            }
            if (Optional.IsDefined(EncryptionKeySource))
            {
                writer.WritePropertyName("encryptionKeySource"u8);
                writer.WriteStringValue(EncryptionKeySource.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultPrivateEndpointResourceId))
            {
                writer.WritePropertyName("keyVaultPrivateEndpointResourceId"u8);
                writer.WriteStringValue(KeyVaultPrivateEndpointResourceId);
            }
            if (Optional.IsDefined(IsLdapEnabled))
            {
                writer.WritePropertyName("ldapEnabled"u8);
                writer.WriteBooleanValue(IsLdapEnabled.Value);
            }
            if (Optional.IsDefined(IsCoolAccessEnabled))
            {
                writer.WritePropertyName("coolAccess"u8);
                writer.WriteBooleanValue(IsCoolAccessEnabled.Value);
            }
            if (Optional.IsDefined(CoolnessPeriod))
            {
                writer.WritePropertyName("coolnessPeriod"u8);
                writer.WriteNumberValue(CoolnessPeriod.Value);
            }
            if (Optional.IsDefined(UnixPermissions))
            {
                if (UnixPermissions != null)
                {
                    writer.WritePropertyName("unixPermissions"u8);
                    writer.WriteStringValue(UnixPermissions);
                }
                else
                {
                    writer.WriteNull("unixPermissions");
                }
            }
            if (Optional.IsDefined(AvsDataStore))
            {
                writer.WritePropertyName("avsDataStore"u8);
                writer.WriteStringValue(AvsDataStore.Value.ToString());
            }
            if (Optional.IsDefined(IsDefaultQuotaEnabled))
            {
                writer.WritePropertyName("isDefaultQuotaEnabled"u8);
                writer.WriteBooleanValue(IsDefaultQuotaEnabled.Value);
            }
            if (Optional.IsDefined(DefaultUserQuotaInKiBs))
            {
                writer.WritePropertyName("defaultUserQuotaInKiBs"u8);
                writer.WriteNumberValue(DefaultUserQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(DefaultGroupQuotaInKiBs))
            {
                writer.WritePropertyName("defaultGroupQuotaInKiBs"u8);
                writer.WriteNumberValue(DefaultGroupQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(CapacityPoolResourceId))
            {
                writer.WritePropertyName("capacityPoolResourceId"u8);
                writer.WriteStringValue(CapacityPoolResourceId);
            }
            if (Optional.IsDefined(ProximityPlacementGroupId))
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                writer.WriteStringValue(ProximityPlacementGroupId);
            }
            if (Optional.IsDefined(VolumeSpecName))
            {
                writer.WritePropertyName("volumeSpecName"u8);
                writer.WriteStringValue(VolumeSpecName);
            }
            if (Optional.IsCollectionDefined(PlacementRules))
            {
                writer.WritePropertyName("placementRules"u8);
                writer.WriteStartArray();
                foreach (var item in PlacementRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableSubvolumes))
            {
                writer.WritePropertyName("enableSubvolumes"u8);
                writer.WriteStringValue(EnableSubvolumes.Value.ToString());
            }
            if (Optional.IsDefined(IsLargeVolume))
            {
                writer.WritePropertyName("isLargeVolume"u8);
                writer.WriteBooleanValue(IsLargeVolume.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetAppVolumeGroupVolume DeserializeNetAppVolumeGroupVolume(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<Guid> fileSystemId = default;
            string creationToken = default;
            Optional<NetAppFileServiceLevel> serviceLevel = default;
            long usageThreshold = default;
            Optional<VolumePropertiesExportPolicy> exportPolicy = default;
            Optional<IList<string>> protocolTypes = default;
            Optional<string> provisioningState = default;
            Optional<string> snapshotId = default;
            Optional<bool> deleteBaseSnapshot = default;
            Optional<string> backupId = default;
            Optional<string> baremetalTenantId = default;
            ResourceIdentifier subnetId = default;
            Optional<NetAppNetworkFeature> networkFeatures = default;
            Optional<Guid> networkSiblingSetId = default;
            Optional<NetAppVolumeStorageToNetworkProximity> storageToNetworkProximity = default;
            Optional<IReadOnlyList<NetAppVolumeMountTarget>> mountTargets = default;
            Optional<string> volumeType = default;
            Optional<NetAppVolumeDataProtection> dataProtection = default;
            Optional<bool> isRestoring = default;
            Optional<bool> snapshotDirectoryVisible = default;
            Optional<bool> kerberosEnabled = default;
            Optional<NetAppVolumeSecurityStyle> securityStyle = default;
            Optional<bool> smbEncryption = default;
            Optional<SmbAccessBasedEnumeration> smbAccessBasedEnumeration = default;
            Optional<SmbNonBrowsable> smbNonBrowsable = default;
            Optional<bool> smbContinuouslyAvailable = default;
            Optional<float?> throughputMibps = default;
            Optional<NetAppEncryptionKeySource> encryptionKeySource = default;
            Optional<ResourceIdentifier> keyVaultPrivateEndpointResourceId = default;
            Optional<bool> ldapEnabled = default;
            Optional<bool> coolAccess = default;
            Optional<int> coolnessPeriod = default;
            Optional<string> unixPermissions = default;
            Optional<int?> cloneProgress = default;
            Optional<NetAppFileAccessLog> fileAccessLogs = default;
            Optional<NetAppAvsDataStore> avsDataStore = default;
            Optional<IReadOnlyList<ResourceIdentifier>> dataStoreResourceId = default;
            Optional<bool> isDefaultQuotaEnabled = default;
            Optional<long> defaultUserQuotaInKiBs = default;
            Optional<long> defaultGroupQuotaInKiBs = default;
            Optional<long> maximumNumberOfFiles = default;
            Optional<string> volumeGroupName = default;
            Optional<ResourceIdentifier> capacityPoolResourceId = default;
            Optional<ResourceIdentifier> proximityPlacementGroup = default;
            Optional<string> t2Network = default;
            Optional<string> volumeSpecName = default;
            Optional<bool> encrypted = default;
            Optional<IList<NetAppVolumePlacementRule>> placementRules = default;
            Optional<EnableNetAppSubvolume> enableSubvolumes = default;
            Optional<string> provisionedAvailabilityZone = default;
            Optional<bool> isLargeVolume = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
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
                        if (property0.NameEquals("fileSystemId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            fileSystemId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationToken"u8))
                        {
                            creationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceLevel = new NetAppFileServiceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usageThreshold"u8))
                        {
                            usageThreshold = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("exportPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportPolicy = VolumePropertiesExportPolicy.DeserializeVolumePropertiesExportPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocolTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            protocolTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("snapshotId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                snapshotId = null;
                                continue;
                            }
                            snapshotId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleteBaseSnapshot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteBaseSnapshot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("backupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                backupId = null;
                                continue;
                            }
                            backupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baremetalTenantId"u8))
                        {
                            baremetalTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetId"u8))
                        {
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkFeatures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkFeatures = new NetAppNetworkFeature(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkSiblingSetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSiblingSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageToNetworkProximity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageToNetworkProximity = new NetAppVolumeStorageToNetworkProximity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mountTargets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetAppVolumeMountTarget> array = new List<NetAppVolumeMountTarget>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppVolumeMountTarget.DeserializeNetAppVolumeMountTarget(item));
                            }
                            mountTargets = array;
                            continue;
                        }
                        if (property0.NameEquals("volumeType"u8))
                        {
                            volumeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataProtection = NetAppVolumeDataProtection.DeserializeNetAppVolumeDataProtection(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isRestoring"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isRestoring = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("snapshotDirectoryVisible"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            snapshotDirectoryVisible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("kerberosEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kerberosEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("securityStyle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityStyle = new NetAppVolumeSecurityStyle(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smbEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("smbAccessBasedEnumeration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smbAccessBasedEnumeration = new SmbAccessBasedEnumeration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbNonBrowsable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smbNonBrowsable = new SmbNonBrowsable(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbContinuouslyAvailable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smbContinuouslyAvailable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("throughputMibps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                throughputMibps = null;
                                continue;
                            }
                            throughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKeySource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionKeySource = new NetAppEncryptionKeySource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyVaultPrivateEndpointResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultPrivateEndpointResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ldapEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ldapEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolnessPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolnessPeriod = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unixPermissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                unixPermissions = null;
                                continue;
                            }
                            unixPermissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloneProgress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cloneProgress = null;
                                continue;
                            }
                            cloneProgress = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("fileAccessLogs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            fileAccessLogs = new NetAppFileAccessLog(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("avsDataStore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            avsDataStore = new NetAppAvsDataStore(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataStoreResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            dataStoreResourceId = array;
                            continue;
                        }
                        if (property0.NameEquals("isDefaultQuotaEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDefaultQuotaEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultUserQuotaInKiBs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultUserQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("defaultGroupQuotaInKiBs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultGroupQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfFiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfFiles = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("volumeGroupName"u8))
                        {
                            volumeGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("capacityPoolResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacityPoolResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proximityPlacementGroup = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("t2Network"u8))
                        {
                            t2Network = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("volumeSpecName"u8))
                        {
                            volumeSpecName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encrypted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encrypted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("placementRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetAppVolumePlacementRule> array = new List<NetAppVolumePlacementRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppVolumePlacementRule.DeserializeNetAppVolumePlacementRule(item));
                            }
                            placementRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableSubvolumes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableSubvolumes = new EnableNetAppSubvolume(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisionedAvailabilityZone"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                provisionedAvailabilityZone = null;
                                continue;
                            }
                            provisionedAvailabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isLargeVolume"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLargeVolume = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppVolumeGroupVolume(id.Value, name.Value, Optional.ToNullable(type), Optional.ToDictionary(tags), Optional.ToNullable(fileSystemId), creationToken, Optional.ToNullable(serviceLevel), usageThreshold, exportPolicy.Value, Optional.ToList(protocolTypes), provisioningState.Value, snapshotId.Value, Optional.ToNullable(deleteBaseSnapshot), backupId.Value, baremetalTenantId.Value, subnetId, Optional.ToNullable(networkFeatures), Optional.ToNullable(networkSiblingSetId), Optional.ToNullable(storageToNetworkProximity), Optional.ToList(mountTargets), volumeType.Value, dataProtection.Value, Optional.ToNullable(isRestoring), Optional.ToNullable(snapshotDirectoryVisible), Optional.ToNullable(kerberosEnabled), Optional.ToNullable(securityStyle), Optional.ToNullable(smbEncryption), Optional.ToNullable(smbAccessBasedEnumeration), Optional.ToNullable(smbNonBrowsable), Optional.ToNullable(smbContinuouslyAvailable), Optional.ToNullable(throughputMibps), Optional.ToNullable(encryptionKeySource), keyVaultPrivateEndpointResourceId.Value, Optional.ToNullable(ldapEnabled), Optional.ToNullable(coolAccess), Optional.ToNullable(coolnessPeriod), unixPermissions.Value, Optional.ToNullable(cloneProgress), Optional.ToNullable(fileAccessLogs), Optional.ToNullable(avsDataStore), Optional.ToList(dataStoreResourceId), Optional.ToNullable(isDefaultQuotaEnabled), Optional.ToNullable(defaultUserQuotaInKiBs), Optional.ToNullable(defaultGroupQuotaInKiBs), Optional.ToNullable(maximumNumberOfFiles), volumeGroupName.Value, capacityPoolResourceId.Value, proximityPlacementGroup.Value, t2Network.Value, volumeSpecName.Value, Optional.ToNullable(encrypted), Optional.ToList(placementRules), Optional.ToNullable(enableSubvolumes), provisionedAvailabilityZone.Value, Optional.ToNullable(isLargeVolume));
        }
    }
}
