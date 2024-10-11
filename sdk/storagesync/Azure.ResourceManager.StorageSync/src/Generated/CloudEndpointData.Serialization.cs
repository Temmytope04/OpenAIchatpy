// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    public partial class CloudEndpointData : IUtf8JsonSerializable, IJsonModel<CloudEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudEndpointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CloudEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId"u8);
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(AzureFileShareName))
            {
                writer.WritePropertyName("azureFileShareName"u8);
                writer.WriteStringValue(AzureFileShareName);
            }
            if (Optional.IsDefined(StorageAccountTenantId))
            {
                writer.WritePropertyName("storageAccountTenantId"u8);
                writer.WriteStringValue(StorageAccountTenantId.Value);
            }
            if (Optional.IsDefined(PartnershipId))
            {
                writer.WritePropertyName("partnershipId"u8);
                writer.WriteStringValue(PartnershipId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(IsBackupEnabled))
            {
                writer.WritePropertyName("backupEnabled"u8);
                writer.WriteStringValue(IsBackupEnabled);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(LastWorkflowId))
            {
                writer.WritePropertyName("lastWorkflowId"u8);
                writer.WriteStringValue(LastWorkflowId);
            }
            if (Optional.IsDefined(LastOperationName))
            {
                writer.WritePropertyName("lastOperationName"u8);
                writer.WriteStringValue(LastOperationName);
            }
            if (options.Format != "W" && Optional.IsDefined(ChangeEnumerationStatus))
            {
                writer.WritePropertyName("changeEnumerationStatus"u8);
                writer.WriteObjectValue(ChangeEnumerationStatus, options);
            }
            writer.WriteEndObject();
        }

        CloudEndpointData IJsonModel<CloudEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointData(document.RootElement, options);
        }

        internal static CloudEndpointData DeserializeCloudEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier storageAccountResourceId = default;
            string azureFileShareName = default;
            Guid? storageAccountTenantId = default;
            string partnershipId = default;
            string friendlyName = default;
            string backupEnabled = default;
            string provisioningState = default;
            string lastWorkflowId = default;
            string lastOperationName = default;
            CloudEndpointChangeEnumerationStatus changeEnumerationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("storageAccountResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureFileShareName"u8))
                        {
                            azureFileShareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("partnershipId"u8))
                        {
                            partnershipId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupEnabled"u8))
                        {
                            backupEnabled = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastWorkflowId"u8))
                        {
                            lastWorkflowId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastOperationName"u8))
                        {
                            lastOperationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("changeEnumerationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changeEnumerationStatus = CloudEndpointChangeEnumerationStatus.DeserializeCloudEndpointChangeEnumerationStatus(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CloudEndpointData(
                id,
                name,
                type,
                systemData,
                storageAccountResourceId,
                azureFileShareName,
                storageAccountTenantId,
                partnershipId,
                friendlyName,
                backupEnabled,
                provisioningState,
                lastWorkflowId,
                lastOperationName,
                changeEnumerationStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointData)} does not support writing '{options.Format}' format.");
            }
        }

        CloudEndpointData IPersistableModel<CloudEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
