// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2OneWayAgreement : IUtf8JsonSerializable, IJsonModel<AS2OneWayAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2OneWayAgreement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AS2OneWayAgreement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2OneWayAgreement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("senderBusinessIdentity"u8);
            writer.WriteObjectValue(SenderBusinessIdentity);
            writer.WritePropertyName("receiverBusinessIdentity"u8);
            writer.WriteObjectValue(ReceiverBusinessIdentity);
            writer.WritePropertyName("protocolSettings"u8);
            writer.WriteObjectValue(ProtocolSettings);
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

        AS2OneWayAgreement IJsonModel<AS2OneWayAgreement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2OneWayAgreement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2OneWayAgreement(document.RootElement, options);
        }

        internal static AS2OneWayAgreement DeserializeAS2OneWayAgreement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationAccountBusinessIdentity senderBusinessIdentity = default;
            IntegrationAccountBusinessIdentity receiverBusinessIdentity = default;
            AS2ProtocolSettings protocolSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderBusinessIdentity"u8))
                {
                    senderBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("receiverBusinessIdentity"u8))
                {
                    receiverBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protocolSettings"u8))
                {
                    protocolSettings = AS2ProtocolSettings.DeserializeAS2ProtocolSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2OneWayAgreement(senderBusinessIdentity, receiverBusinessIdentity, protocolSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2OneWayAgreement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AS2OneWayAgreement)} does not support '{options.Format}' format.");
            }
        }

        AS2OneWayAgreement IPersistableModel<AS2OneWayAgreement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAS2OneWayAgreement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AS2OneWayAgreement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AS2OneWayAgreement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
