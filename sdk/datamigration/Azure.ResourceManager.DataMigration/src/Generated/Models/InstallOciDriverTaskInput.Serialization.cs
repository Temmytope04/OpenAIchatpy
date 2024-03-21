// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class InstallOciDriverTaskInput : IUtf8JsonSerializable, IJsonModel<InstallOciDriverTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstallOciDriverTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InstallOciDriverTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstallOciDriverTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstallOciDriverTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DriverPackageName))
            {
                writer.WritePropertyName("driverPackageName"u8);
                writer.WriteStringValue(DriverPackageName);
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

        InstallOciDriverTaskInput IJsonModel<InstallOciDriverTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstallOciDriverTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstallOciDriverTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstallOciDriverTaskInput(document.RootElement, options);
        }

        internal static InstallOciDriverTaskInput DeserializeInstallOciDriverTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string driverPackageName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("driverPackageName"u8))
                {
                    driverPackageName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InstallOciDriverTaskInput(driverPackageName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InstallOciDriverTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstallOciDriverTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InstallOciDriverTaskInput)} does not support '{options.Format}' format.");
            }
        }

        InstallOciDriverTaskInput IPersistableModel<InstallOciDriverTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstallOciDriverTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInstallOciDriverTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InstallOciDriverTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstallOciDriverTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
