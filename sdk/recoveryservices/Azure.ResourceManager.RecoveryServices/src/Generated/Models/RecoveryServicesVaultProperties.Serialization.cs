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

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RecoveryServicesVaultProperties : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryServicesVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryServicesVaultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryServicesVaultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UpgradeDetails))
            {
                writer.WritePropertyName("upgradeDetails"u8);
                writer.WriteObjectValue(UpgradeDetails);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(MoveDetails))
            {
                writer.WritePropertyName("moveDetails"u8);
                writer.WriteObjectValue(MoveDetails);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(MonitoringSettings))
            {
                writer.WritePropertyName("monitoringSettings"u8);
                writer.WriteObjectValue(MonitoringSettings);
            }
            if (Optional.IsDefined(RedundancySettings))
            {
                writer.WritePropertyName("redundancySettings"u8);
                writer.WriteObjectValue(RedundancySettings);
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings);
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

        internal static RecoveryServicesVaultProperties DeserializeRecoveryServicesVaultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningState = default;
            Optional<VaultUpgradeDetails> upgradeDetails = default;
            Optional<IReadOnlyList<RecoveryServicesPrivateEndpointConnectionVaultProperties>> privateEndpointConnections = default;
            Optional<VaultPrivateEndpointState> privateEndpointStateForBackup = default;
            Optional<VaultPrivateEndpointState> privateEndpointStateForSiteRecovery = default;
            Optional<VaultPropertiesEncryption> encryption = default;
            Optional<VaultPropertiesMoveDetails> moveDetails = default;
            Optional<ResourceMoveState> moveState = default;
            Optional<BackupStorageVersion> backupStorageVersion = default;
            Optional<VaultPublicNetworkAccess> publicNetworkAccess = default;
            Optional<VaultMonitoringSettings> monitoringSettings = default;
            Optional<VaultPropertiesRedundancySettings> redundancySettings = default;
            Optional<SecuritySettings> securitySettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeDetails = VaultUpgradeDetails.DeserializeVaultUpgradeDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryServicesPrivateEndpointConnectionVaultProperties> array = new List<RecoveryServicesPrivateEndpointConnectionVaultProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryServicesPrivateEndpointConnectionVaultProperties.DeserializeRecoveryServicesPrivateEndpointConnectionVaultProperties(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointStateForBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpointStateForBackup = new VaultPrivateEndpointState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointStateForSiteRecovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpointStateForSiteRecovery = new VaultPrivateEndpointState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = VaultPropertiesEncryption.DeserializeVaultPropertiesEncryption(property.Value);
                    continue;
                }
                if (property.NameEquals("moveDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveDetails = VaultPropertiesMoveDetails.DeserializeVaultPropertiesMoveDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("moveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveState = new ResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupStorageVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStorageVersion = new BackupStorageVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new VaultPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoringSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSettings = VaultMonitoringSettings.DeserializeVaultMonitoringSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("redundancySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redundancySettings = VaultPropertiesRedundancySettings.DeserializeVaultPropertiesRedundancySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySettings = SecuritySettings.DeserializeSecuritySettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecoveryServicesVaultProperties(provisioningState.Value, upgradeDetails.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(privateEndpointStateForBackup), Optional.ToNullable(privateEndpointStateForSiteRecovery), encryption.Value, moveDetails.Value, Optional.ToNullable(moveState), Optional.ToNullable(backupStorageVersion), Optional.ToNullable(publicNetworkAccess), monitoringSettings.Value, redundancySettings.Value, securitySettings.Value, rawData);
        }

        RecoveryServicesVaultProperties IModelJsonSerializable<RecoveryServicesVaultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServicesVaultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryServicesVaultProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryServicesVaultProperties IModelSerializable<RecoveryServicesVaultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryServicesVaultProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RecoveryServicesVaultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RecoveryServicesVaultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryServicesVaultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
