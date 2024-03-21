// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciDiskInput : IUtf8JsonSerializable, IJsonModel<VMwareToAzStackHciDiskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareToAzStackHciDiskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareToAzStackHciDiskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciDiskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciDiskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("diskId"u8);
            writer.WriteStringValue(DiskId);
            if (Optional.IsDefined(StorageContainerId))
            {
                writer.WritePropertyName("storageContainerId"u8);
                writer.WriteStringValue(StorageContainerId);
            }
            if (Optional.IsDefined(IsDynamic))
            {
                writer.WritePropertyName("isDynamic"u8);
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            writer.WritePropertyName("diskSizeGB"u8);
            writer.WriteNumberValue(DiskSizeGB);
            writer.WritePropertyName("diskFileFormat"u8);
            writer.WriteStringValue(DiskFileFormat);
            writer.WritePropertyName("isOsDisk"u8);
            writer.WriteBooleanValue(IsOSDisk);
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

        VMwareToAzStackHciDiskInput IJsonModel<VMwareToAzStackHciDiskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciDiskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciDiskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareToAzStackHciDiskInput(document.RootElement, options);
        }

        internal static VMwareToAzStackHciDiskInput DeserializeVMwareToAzStackHciDiskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string storageContainerId = default;
            bool? isDynamic = default;
            long diskSizeGB = default;
            string diskFileFormat = default;
            bool isOSDisk = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageContainerId"u8))
                {
                    storageContainerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDynamic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDynamic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    diskSizeGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskFileFormat"u8))
                {
                    diskFileFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOsDisk"u8))
                {
                    isOSDisk = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareToAzStackHciDiskInput(
                diskId,
                storageContainerId,
                isDynamic,
                diskSizeGB,
                diskFileFormat,
                isOSDisk,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareToAzStackHciDiskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciDiskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciDiskInput)} does not support '{options.Format}' format.");
            }
        }

        VMwareToAzStackHciDiskInput IPersistableModel<VMwareToAzStackHciDiskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciDiskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareToAzStackHciDiskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciDiskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareToAzStackHciDiskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
