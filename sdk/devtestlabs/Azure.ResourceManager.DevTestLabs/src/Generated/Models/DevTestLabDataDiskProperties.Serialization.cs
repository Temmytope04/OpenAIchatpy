// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabDataDiskProperties : IUtf8JsonSerializable, IJsonModel<DevTestLabDataDiskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabDataDiskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabDataDiskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabDataDiskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AttachNewDataDiskOptions))
            {
                writer.WritePropertyName("attachNewDataDiskOptions"u8);
                writer.WriteObjectValue(AttachNewDataDiskOptions);
            }
            if (Optional.IsDefined(ExistingLabDiskId))
            {
                writer.WritePropertyName("existingLabDiskId"u8);
                writer.WriteStringValue(ExistingLabDiskId);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching"u8);
                writer.WriteStringValue(HostCaching.Value.ToString());
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

        DevTestLabDataDiskProperties IJsonModel<DevTestLabDataDiskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabDataDiskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabDataDiskProperties(document.RootElement, options);
        }

        internal static DevTestLabDataDiskProperties DeserializeDevTestLabDataDiskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AttachNewDataDiskDetails attachNewDataDiskOptions = default;
            ResourceIdentifier existingLabDiskId = default;
            DevTestLabHostCachingOption? hostCaching = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attachNewDataDiskOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachNewDataDiskOptions = AttachNewDataDiskDetails.DeserializeAttachNewDataDiskDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("existingLabDiskId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    existingLabDiskId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostCaching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostCaching = new DevTestLabHostCachingOption(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabDataDiskProperties(attachNewDataDiskOptions, existingLabDiskId, hostCaching, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabDataDiskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabDataDiskProperties)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabDataDiskProperties IPersistableModel<DevTestLabDataDiskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabDataDiskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabDataDiskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabDataDiskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabDataDiskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
