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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseEventGridDataConnection : IUtf8JsonSerializable, IJsonModel<SynapseEventGridDataConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseEventGridDataConnection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseEventGridDataConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEventGridDataConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseEventGridDataConnection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId"u8);
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(EventHubResourceId))
            {
                writer.WritePropertyName("eventHubResourceId"u8);
                writer.WriteStringValue(EventHubResourceId);
            }
            if (Optional.IsDefined(ConsumerGroup))
            {
                writer.WritePropertyName("consumerGroup"u8);
                writer.WriteStringValue(ConsumerGroup);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(MappingRuleName))
            {
                writer.WritePropertyName("mappingRuleName"u8);
                writer.WriteStringValue(MappingRuleName);
            }
            if (Optional.IsDefined(DataFormat))
            {
                writer.WritePropertyName("dataFormat"u8);
                writer.WriteStringValue(DataFormat.Value.ToString());
            }
            if (Optional.IsDefined(IgnoreFirstRecord))
            {
                writer.WritePropertyName("ignoreFirstRecord"u8);
                writer.WriteBooleanValue(IgnoreFirstRecord.Value);
            }
            if (Optional.IsDefined(BlobStorageEventType))
            {
                writer.WritePropertyName("blobStorageEventType"u8);
                writer.WriteStringValue(BlobStorageEventType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SynapseEventGridDataConnection IJsonModel<SynapseEventGridDataConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEventGridDataConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseEventGridDataConnection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseEventGridDataConnection(document.RootElement, options);
        }

        internal static SynapseEventGridDataConnection DeserializeSynapseEventGridDataConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            SynapseDataConnectionKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier storageAccountResourceId = default;
            ResourceIdentifier eventHubResourceId = default;
            string consumerGroup = default;
            string tableName = default;
            string mappingRuleName = default;
            SynapseEventGridDataFormat? dataFormat = default;
            bool? ignoreFirstRecord = default;
            SynapseBlobStorageEventType? blobStorageEventType = default;
            ResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new SynapseDataConnectionKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("eventHubResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventHubResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("consumerGroup"u8))
                        {
                            consumerGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mappingRuleName"u8))
                        {
                            mappingRuleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataFormat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataFormat = new SynapseEventGridDataFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ignoreFirstRecord"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreFirstRecord = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("blobStorageEventType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blobStorageEventType = new SynapseBlobStorageEventType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseEventGridDataConnection(
                id,
                name,
                type,
                systemData,
                location,
                kind,
                serializedAdditionalRawData,
                storageAccountResourceId,
                eventHubResourceId,
                consumerGroup,
                tableName,
                mappingRuleName,
                dataFormat,
                ignoreFirstRecord,
                blobStorageEventType,
                provisioningState);
        }

        BinaryData IPersistableModel<SynapseEventGridDataConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEventGridDataConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseEventGridDataConnection)} does not support '{options.Format}' format.");
            }
        }

        SynapseEventGridDataConnection IPersistableModel<SynapseEventGridDataConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEventGridDataConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseEventGridDataConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseEventGridDataConnection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseEventGridDataConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
