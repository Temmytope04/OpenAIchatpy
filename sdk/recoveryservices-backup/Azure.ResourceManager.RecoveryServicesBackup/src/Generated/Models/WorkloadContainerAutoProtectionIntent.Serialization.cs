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
    public partial class WorkloadContainerAutoProtectionIntent : IUtf8JsonSerializable, IModelJsonSerializable<WorkloadContainerAutoProtectionIntent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WorkloadContainerAutoProtectionIntent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WorkloadContainerAutoProtectionIntent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadContainerAutoProtectionIntent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("protectionIntentItemType"u8);
            writer.WriteStringValue(ProtectionIntentItemType.ToString());
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(ItemId))
            {
                writer.WritePropertyName("itemId"u8);
                writer.WriteStringValue(ItemId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        internal static WorkloadContainerAutoProtectionIntent DeserializeWorkloadContainerAutoProtectionIntent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProtectionIntentItemType protectionIntentItemType = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<ResourceIdentifier> itemId = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<BackupProtectionStatus> protectionState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionIntentItemType"u8))
                {
                    protectionIntentItemType = new ProtectionIntentItemType(property.Value.GetString());
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
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("itemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WorkloadContainerAutoProtectionIntent(protectionIntentItemType, Optional.ToNullable(backupManagementType), sourceResourceId.Value, itemId.Value, policyId.Value, Optional.ToNullable(protectionState), rawData);
        }

        WorkloadContainerAutoProtectionIntent IModelJsonSerializable<WorkloadContainerAutoProtectionIntent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadContainerAutoProtectionIntent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadContainerAutoProtectionIntent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WorkloadContainerAutoProtectionIntent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadContainerAutoProtectionIntent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WorkloadContainerAutoProtectionIntent IModelSerializable<WorkloadContainerAutoProtectionIntent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadContainerAutoProtectionIntent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWorkloadContainerAutoProtectionIntent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(WorkloadContainerAutoProtectionIntent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator WorkloadContainerAutoProtectionIntent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWorkloadContainerAutoProtectionIntent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
