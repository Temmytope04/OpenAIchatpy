// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownEnvironmentData : IUtf8JsonSerializable, IJsonModel<SecurityConnectorEnvironment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityConnectorEnvironment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityConnectorEnvironment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("environmentType"u8);
            writer.WriteStringValue(EnvironmentType.ToString());
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

        SecurityConnectorEnvironment IJsonModel<SecurityConnectorEnvironment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityConnectorEnvironment(document.RootElement, options);
        }

        internal static UnknownEnvironmentData DeserializeUnknownEnvironmentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EnvironmentType environmentType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentType"u8))
                {
                    environmentType = new EnvironmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownEnvironmentData(environmentType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityConnectorEnvironment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{options.Format}' format.");
            }
        }

        SecurityConnectorEnvironment IPersistableModel<SecurityConnectorEnvironment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityConnectorEnvironment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityConnectorEnvironment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
