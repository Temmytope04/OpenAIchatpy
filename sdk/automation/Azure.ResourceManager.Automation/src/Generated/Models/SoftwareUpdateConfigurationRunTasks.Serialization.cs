// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationRunTasks : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationRunTasks>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationRunTasks>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareUpdateConfigurationRunTasks>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTasks>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PreTask))
            {
                writer.WritePropertyName("preTask"u8);
                writer.WriteObjectValue(PreTask);
            }
            if (Optional.IsDefined(PostTask))
            {
                writer.WritePropertyName("postTask"u8);
                writer.WriteObjectValue(PostTask);
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

        SoftwareUpdateConfigurationRunTasks IJsonModel<SoftwareUpdateConfigurationRunTasks>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTasks>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationRunTasks(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationRunTasks DeserializeSoftwareUpdateConfigurationRunTasks(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SoftwareUpdateConfigurationRunTaskProperties preTask = default;
            SoftwareUpdateConfigurationRunTaskProperties postTask = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preTask = SoftwareUpdateConfigurationRunTaskProperties.DeserializeSoftwareUpdateConfigurationRunTaskProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("postTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    postTask = SoftwareUpdateConfigurationRunTaskProperties.DeserializeSoftwareUpdateConfigurationRunTaskProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationRunTasks(preTask, postTask, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareUpdateConfigurationRunTasks>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTasks>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{options.Format}' format.");
            }
        }

        SoftwareUpdateConfigurationRunTasks IPersistableModel<SoftwareUpdateConfigurationRunTasks>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTasks>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSoftwareUpdateConfigurationRunTasks(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SoftwareUpdateConfigurationRunTasks>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
