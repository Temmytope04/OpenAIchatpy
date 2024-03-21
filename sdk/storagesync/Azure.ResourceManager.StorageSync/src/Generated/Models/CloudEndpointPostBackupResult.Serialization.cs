// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudEndpointPostBackupResult : IUtf8JsonSerializable, IJsonModel<CloudEndpointPostBackupResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudEndpointPostBackupResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudEndpointPostBackupResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointPostBackupResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointPostBackupResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("backupMetadata"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CloudEndpointName))
            {
                writer.WritePropertyName("cloudEndpointName"u8);
                writer.WriteStringValue(CloudEndpointName);
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

        CloudEndpointPostBackupResult IJsonModel<CloudEndpointPostBackupResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointPostBackupResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointPostBackupResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointPostBackupResult(document.RootElement, options);
        }

        internal static CloudEndpointPostBackupResult DeserializeCloudEndpointPostBackupResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cloudEndpointName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cloudEndpointName"u8))
                        {
                            cloudEndpointName = property0.Value.GetString();
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
            return new CloudEndpointPostBackupResult(cloudEndpointName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudEndpointPostBackupResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointPostBackupResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointPostBackupResult)} does not support '{options.Format}' format.");
            }
        }

        CloudEndpointPostBackupResult IPersistableModel<CloudEndpointPostBackupResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointPostBackupResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudEndpointPostBackupResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointPostBackupResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudEndpointPostBackupResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
