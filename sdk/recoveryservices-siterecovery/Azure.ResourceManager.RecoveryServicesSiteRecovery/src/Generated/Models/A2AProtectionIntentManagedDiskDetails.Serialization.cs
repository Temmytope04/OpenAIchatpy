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
    public partial class A2AProtectionIntentManagedDiskDetails : IUtf8JsonSerializable, IModelJsonSerializable<A2AProtectionIntentManagedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<A2AProtectionIntentManagedDiskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<A2AProtectionIntentManagedDiskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("diskId"u8);
            writer.WriteStringValue(DiskId);
            if (Optional.IsDefined(PrimaryStagingStorageAccountCustomContent))
            {
                writer.WritePropertyName("primaryStagingStorageAccountCustomInput"u8);
                writer.WriteObjectValue(PrimaryStagingStorageAccountCustomContent);
            }
            if (Optional.IsDefined(RecoveryResourceGroupCustomContent))
            {
                writer.WritePropertyName("recoveryResourceGroupCustomInput"u8);
                writer.WriteObjectValue(RecoveryResourceGroupCustomContent);
            }
            if (Optional.IsDefined(RecoveryReplicaDiskAccountType))
            {
                writer.WritePropertyName("recoveryReplicaDiskAccountType"u8);
                writer.WriteStringValue(RecoveryReplicaDiskAccountType);
            }
            if (Optional.IsDefined(RecoveryTargetDiskAccountType))
            {
                writer.WritePropertyName("recoveryTargetDiskAccountType"u8);
                writer.WriteStringValue(RecoveryTargetDiskAccountType);
            }
            if (Optional.IsDefined(RecoveryDiskEncryptionSetId))
            {
                writer.WritePropertyName("recoveryDiskEncryptionSetId"u8);
                writer.WriteStringValue(RecoveryDiskEncryptionSetId);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
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

        internal static A2AProtectionIntentManagedDiskDetails DeserializeA2AProtectionIntentManagedDiskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            Optional<StorageAccountCustomDetails> primaryStagingStorageAccountCustomContent = default;
            Optional<RecoveryResourceGroupCustomDetails> recoveryResourceGroupCustomContent = default;
            Optional<string> recoveryReplicaDiskAccountType = default;
            Optional<string> recoveryTargetDiskAccountType = default;
            Optional<ResourceIdentifier> recoveryDiskEncryptionSetId = default;
            Optional<SiteRecoveryDiskEncryptionInfo> diskEncryptionInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryStagingStorageAccountCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingStorageAccountCustomContent = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupCustomContent = RecoveryResourceGroupCustomDetails.DeserializeRecoveryResourceGroupCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryReplicaDiskAccountType"u8))
                {
                    recoveryReplicaDiskAccountType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryTargetDiskAccountType"u8))
                {
                    recoveryTargetDiskAccountType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryDiskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryDiskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new A2AProtectionIntentManagedDiskDetails(diskId, primaryStagingStorageAccountCustomContent.Value, recoveryResourceGroupCustomContent.Value, recoveryReplicaDiskAccountType.Value, recoveryTargetDiskAccountType.Value, recoveryDiskEncryptionSetId.Value, diskEncryptionInfo.Value, rawData);
        }

        A2AProtectionIntentManagedDiskDetails IModelJsonSerializable<A2AProtectionIntentManagedDiskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AProtectionIntentManagedDiskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<A2AProtectionIntentManagedDiskDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        A2AProtectionIntentManagedDiskDetails IModelSerializable<A2AProtectionIntentManagedDiskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeA2AProtectionIntentManagedDiskDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(A2AProtectionIntentManagedDiskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator A2AProtectionIntentManagedDiskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeA2AProtectionIntentManagedDiskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
