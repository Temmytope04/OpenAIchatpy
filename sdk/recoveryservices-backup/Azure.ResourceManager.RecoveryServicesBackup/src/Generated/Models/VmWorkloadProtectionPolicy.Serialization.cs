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
    public partial class VmWorkloadProtectionPolicy : IUtf8JsonSerializable, IModelJsonSerializable<VmWorkloadProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmWorkloadProtectionPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmWorkloadProtectionPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadProtectionPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkLoadType))
            {
                writer.WritePropertyName("workLoadType"u8);
                writer.WriteStringValue(WorkLoadType.Value.ToString());
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings);
            }
            if (Optional.IsCollectionDefined(SubProtectionPolicy))
            {
                writer.WritePropertyName("subProtectionPolicy"u8);
                writer.WriteStartArray();
                foreach (var item in SubProtectionPolicy)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DoesMakePolicyConsistent))
            {
                writer.WritePropertyName("makePolicyConsistent"u8);
                writer.WriteBooleanValue(DoesMakePolicyConsistent.Value);
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            writer.WritePropertyName("backupManagementType"u8);
            writer.WriteStringValue(BackupManagementType);
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static VmWorkloadProtectionPolicy DeserializeVmWorkloadProtectionPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupWorkloadType> workLoadType = default;
            Optional<BackupCommonSettings> settings = default;
            Optional<IList<SubProtectionPolicy>> subProtectionPolicy = default;
            Optional<bool> makePolicyConsistent = default;
            Optional<int> protectedItemsCount = default;
            string backupManagementType = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workLoadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workLoadType = new BackupWorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = BackupCommonSettings.DeserializeBackupCommonSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("subProtectionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubProtectionPolicy> array = new List<SubProtectionPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.SubProtectionPolicy.DeserializeSubProtectionPolicy(item));
                    }
                    subProtectionPolicy = array;
                    continue;
                }
                if (property.NameEquals("makePolicyConsistent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    makePolicyConsistent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
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
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmWorkloadProtectionPolicy(Optional.ToNullable(protectedItemsCount), backupManagementType, Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(workLoadType), settings.Value, Optional.ToList(subProtectionPolicy), Optional.ToNullable(makePolicyConsistent), rawData);
        }

        VmWorkloadProtectionPolicy IModelJsonSerializable<VmWorkloadProtectionPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadProtectionPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadProtectionPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmWorkloadProtectionPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadProtectionPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmWorkloadProtectionPolicy IModelSerializable<VmWorkloadProtectionPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadProtectionPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmWorkloadProtectionPolicy(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VmWorkloadProtectionPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VmWorkloadProtectionPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmWorkloadProtectionPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
