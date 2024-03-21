// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    public partial class LargeInstanceStorageProperties : IUtf8JsonSerializable, IJsonModel<LargeInstanceStorageProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LargeInstanceStorageProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LargeInstanceStorageProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceStorageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceStorageProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(OfferingType))
            {
                writer.WritePropertyName("offeringType"u8);
                writer.WriteStringValue(OfferingType);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType);
            }
            if (Optional.IsDefined(Generation))
            {
                writer.WritePropertyName("generation"u8);
                writer.WriteStringValue(Generation);
            }
            if (Optional.IsDefined(HardwareType))
            {
                writer.WritePropertyName("hardwareType"u8);
                writer.WriteStringValue(HardwareType.Value.ToString());
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            if (Optional.IsDefined(StorageBillingProperties))
            {
                writer.WritePropertyName("storageBillingProperties"u8);
                writer.WriteObjectValue(StorageBillingProperties);
            }
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

        LargeInstanceStorageProperties IJsonModel<LargeInstanceStorageProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceStorageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceStorageProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLargeInstanceStorageProperties(document.RootElement, options);
        }

        internal static LargeInstanceStorageProperties DeserializeLargeInstanceStorageProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LargeInstanceProvisioningState? provisioningState = default;
            string offeringType = default;
            string storageType = default;
            string generation = default;
            LargeInstanceHardwareTypeName? hardwareType = default;
            string workloadType = default;
            LargeInstanceStorageBillingProperties storageBillingProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new LargeInstanceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    storageType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generation"u8))
                {
                    generation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hardwareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareType = new LargeInstanceHardwareTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageBillingProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageBillingProperties = LargeInstanceStorageBillingProperties.DeserializeLargeInstanceStorageBillingProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LargeInstanceStorageProperties(
                provisioningState,
                offeringType,
                storageType,
                generation,
                hardwareType,
                workloadType,
                storageBillingProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LargeInstanceStorageProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceStorageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceStorageProperties)} does not support '{options.Format}' format.");
            }
        }

        LargeInstanceStorageProperties IPersistableModel<LargeInstanceStorageProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceStorageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLargeInstanceStorageProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceStorageProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LargeInstanceStorageProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
