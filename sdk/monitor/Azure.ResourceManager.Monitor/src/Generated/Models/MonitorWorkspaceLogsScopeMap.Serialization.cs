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
    public partial class MonitorWorkspaceLogsScopeMap : IUtf8JsonSerializable, IJsonModel<MonitorWorkspaceLogsScopeMap>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorWorkspaceLogsScopeMap>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorWorkspaceLogsScopeMap>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsScopeMap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceLogsScopeMap)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("from"u8);
            writer.WriteStringValue(From);
            writer.WritePropertyName("to"u8);
            writer.WriteStringValue(To);
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

        MonitorWorkspaceLogsScopeMap IJsonModel<MonitorWorkspaceLogsScopeMap>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsScopeMap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceLogsScopeMap)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWorkspaceLogsScopeMap(document.RootElement, options);
        }

        internal static MonitorWorkspaceLogsScopeMap DeserializeMonitorWorkspaceLogsScopeMap(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @from = default;
            string to = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitorWorkspaceLogsScopeMap(@from, to, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorWorkspaceLogsScopeMap>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsScopeMap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceLogsScopeMap)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorWorkspaceLogsScopeMap IPersistableModel<MonitorWorkspaceLogsScopeMap>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsScopeMap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorWorkspaceLogsScopeMap(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceLogsScopeMap)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorWorkspaceLogsScopeMap>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
