// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LogStorageSettings : IUtf8JsonSerializable, IJsonModel<LogStorageSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogStorageSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogStorageSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogStorageSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogStorageSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName);
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                JsonSerializer.Serialize(writer, Path);
            }
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel"u8);
                JsonSerializer.Serialize(writer, LogLevel);
            }
            if (Optional.IsDefined(EnableReliableLogging))
            {
                writer.WritePropertyName("enableReliableLogging"u8);
                JsonSerializer.Serialize(writer, EnableReliableLogging);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        LogStorageSettings IJsonModel<LogStorageSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogStorageSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogStorageSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogStorageSettings(document.RootElement, options);
        }

        internal static LogStorageSettings DeserializeLogStorageSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryLinkedServiceReference linkedServiceName = default;
            DataFactoryElement<string> path = default;
            DataFactoryElement<string> logLevel = default;
            DataFactoryElement<bool> enableReliableLogging = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    path = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("logLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLevel = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enableReliableLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableReliableLogging = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new LogStorageSettings(linkedServiceName, path, logLevel, enableReliableLogging, additionalProperties);
        }

        BinaryData IPersistableModel<LogStorageSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogStorageSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogStorageSettings)} does not support '{options.Format}' format.");
            }
        }

        LogStorageSettings IPersistableModel<LogStorageSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogStorageSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogStorageSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogStorageSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogStorageSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
