// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class WindowsFirewallLogsDataSource : IUtf8JsonSerializable, IJsonModel<WindowsFirewallLogsDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsFirewallLogsDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WindowsFirewallLogsDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsFirewallLogsDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WindowsFirewallLogsDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("streams"u8);
            writer.WriteStartArray();
            foreach (var item in Streams)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        WindowsFirewallLogsDataSource IJsonModel<WindowsFirewallLogsDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsFirewallLogsDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WindowsFirewallLogsDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsFirewallLogsDataSource(document.RootElement, options);
        }

        internal static WindowsFirewallLogsDataSource DeserializeWindowsFirewallLogsDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> streams = default;
            Optional<string> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsFirewallLogsDataSource(streams, name.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsFirewallLogsDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsFirewallLogsDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(WindowsFirewallLogsDataSource)} does not support '{options.Format}' format.");
            }
        }

        WindowsFirewallLogsDataSource IPersistableModel<WindowsFirewallLogsDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsFirewallLogsDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsFirewallLogsDataSource(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(WindowsFirewallLogsDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsFirewallLogsDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
