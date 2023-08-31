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
    public partial class HyperVReplicaPolicyDetails : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplicaPolicyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplicaPolicyDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplicaPolicyDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplicaPolicyDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPoints))
            {
                writer.WritePropertyName("recoveryPoints"u8);
                writer.WriteNumberValue(RecoveryPoints.Value);
            }
            if (Optional.IsDefined(ApplicationConsistentSnapshotFrequencyInHours))
            {
                writer.WritePropertyName("applicationConsistentSnapshotFrequencyInHours"u8);
                writer.WriteNumberValue(ApplicationConsistentSnapshotFrequencyInHours.Value);
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteStringValue(Compression);
            }
            if (Optional.IsDefined(InitialReplicationMethod))
            {
                writer.WritePropertyName("initialReplicationMethod"u8);
                writer.WriteStringValue(InitialReplicationMethod);
            }
            if (Optional.IsDefined(OnlineReplicationStartTime))
            {
                writer.WritePropertyName("onlineReplicationStartTime"u8);
                writer.WriteStringValue(OnlineReplicationStartTime);
            }
            if (Optional.IsDefined(OfflineReplicationImportPath))
            {
                writer.WritePropertyName("offlineReplicationImportPath"u8);
                writer.WriteStringValue(OfflineReplicationImportPath);
            }
            if (Optional.IsDefined(OfflineReplicationExportPath))
            {
                writer.WritePropertyName("offlineReplicationExportPath"u8);
                writer.WriteStringValue(OfflineReplicationExportPath);
            }
            if (Optional.IsDefined(ReplicationPort))
            {
                writer.WritePropertyName("replicationPort"u8);
                writer.WriteNumberValue(ReplicationPort.Value);
            }
            if (Optional.IsDefined(AllowedAuthenticationType))
            {
                writer.WritePropertyName("allowedAuthenticationType"u8);
                writer.WriteNumberValue(AllowedAuthenticationType.Value);
            }
            if (Optional.IsDefined(ReplicaDeletionOption))
            {
                writer.WritePropertyName("replicaDeletionOption"u8);
                writer.WriteStringValue(ReplicaDeletionOption);
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

        internal static HyperVReplicaPolicyDetails DeserializeHyperVReplicaPolicyDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> recoveryPoints = default;
            Optional<int> applicationConsistentSnapshotFrequencyInHours = default;
            Optional<string> compression = default;
            Optional<string> initialReplicationMethod = default;
            Optional<string> onlineReplicationStartTime = default;
            Optional<string> offlineReplicationImportPath = default;
            Optional<string> offlineReplicationExportPath = default;
            Optional<int> replicationPort = default;
            Optional<int> allowedAuthenticationType = default;
            Optional<string> replicaDeletionOption = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPoints = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("applicationConsistentSnapshotFrequencyInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationConsistentSnapshotFrequencyInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    compression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationMethod"u8))
                {
                    initialReplicationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onlineReplicationStartTime"u8))
                {
                    onlineReplicationStartTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationImportPath"u8))
                {
                    offlineReplicationImportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationExportPath"u8))
                {
                    offlineReplicationExportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedAuthenticationType = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicaDeletionOption"u8))
                {
                    replicaDeletionOption = property.Value.GetString();
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
            return new HyperVReplicaPolicyDetails(instanceType, Optional.ToNullable(recoveryPoints), Optional.ToNullable(applicationConsistentSnapshotFrequencyInHours), compression.Value, initialReplicationMethod.Value, onlineReplicationStartTime.Value, offlineReplicationImportPath.Value, offlineReplicationExportPath.Value, Optional.ToNullable(replicationPort), Optional.ToNullable(allowedAuthenticationType), replicaDeletionOption.Value, rawData);
        }

        HyperVReplicaPolicyDetails IModelJsonSerializable<HyperVReplicaPolicyDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplicaPolicyDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaPolicyDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplicaPolicyDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplicaPolicyDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplicaPolicyDetails IModelSerializable<HyperVReplicaPolicyDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplicaPolicyDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaPolicyDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HyperVReplicaPolicyDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HyperVReplicaPolicyDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplicaPolicyDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
