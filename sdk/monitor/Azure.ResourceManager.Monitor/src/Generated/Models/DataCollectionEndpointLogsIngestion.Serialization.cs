// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class DataCollectionEndpointLogsIngestion : IUtf8JsonSerializable, IJsonModel<DataCollectionEndpointLogsIngestion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionEndpointLogsIngestion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionEndpointLogsIngestion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointLogsIngestion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointLogsIngestion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Endpoint != null)
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
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

        DataCollectionEndpointLogsIngestion IJsonModel<DataCollectionEndpointLogsIngestion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointLogsIngestion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointLogsIngestion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointLogsIngestion(document.RootElement, options);
        }

        internal static DataCollectionEndpointLogsIngestion DeserializeDataCollectionEndpointLogsIngestion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionEndpointLogsIngestion(endpoint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionEndpointLogsIngestion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointLogsIngestion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointLogsIngestion)} does not support '{options.Format}' format.");
            }
        }

        DataCollectionEndpointLogsIngestion IPersistableModel<DataCollectionEndpointLogsIngestion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointLogsIngestion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionEndpointLogsIngestion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointLogsIngestion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionEndpointLogsIngestion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
