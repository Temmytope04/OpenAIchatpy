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
    public partial class VmAppContainerProtectableContainer : IUtf8JsonSerializable, IModelJsonSerializable<VmAppContainerProtectableContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmAppContainerProtectableContainer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmAppContainerProtectableContainer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmAppContainerProtectableContainer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            writer.WritePropertyName("protectableContainerType"u8);
            writer.WriteStringValue(ProtectableContainerType.ToSerialString());
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
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

        internal static VmAppContainerProtectableContainer DeserializeVmAppContainerProtectableContainer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            ProtectableContainerType protectableContainerType = default;
            Optional<string> healthStatus = default;
            Optional<string> containerId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectableContainerType"u8))
                {
                    protectableContainerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    containerId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmAppContainerProtectableContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), protectableContainerType, healthStatus.Value, containerId.Value, rawData);
        }

        VmAppContainerProtectableContainer IModelJsonSerializable<VmAppContainerProtectableContainer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmAppContainerProtectableContainer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmAppContainerProtectableContainer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmAppContainerProtectableContainer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmAppContainerProtectableContainer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmAppContainerProtectableContainer IModelSerializable<VmAppContainerProtectableContainer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmAppContainerProtectableContainer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmAppContainerProtectableContainer(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VmAppContainerProtectableContainer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VmAppContainerProtectableContainer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmAppContainerProtectableContainer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
