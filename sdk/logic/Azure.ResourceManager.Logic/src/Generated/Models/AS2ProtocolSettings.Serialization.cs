// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2ProtocolSettings : IUtf8JsonSerializable, IJsonModel<AS2ProtocolSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2ProtocolSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AS2ProtocolSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("messageConnectionSettings"u8);
            writer.WriteObjectValue(MessageConnectionSettings);
            writer.WritePropertyName("acknowledgementConnectionSettings"u8);
            writer.WriteObjectValue(AcknowledgementConnectionSettings);
            writer.WritePropertyName("mdnSettings"u8);
            writer.WriteObjectValue(MdnSettings);
            writer.WritePropertyName("securitySettings"u8);
            writer.WriteObjectValue(SecuritySettings);
            writer.WritePropertyName("validationSettings"u8);
            writer.WriteObjectValue(ValidationSettings);
            writer.WritePropertyName("envelopeSettings"u8);
            writer.WriteObjectValue(EnvelopeSettings);
            writer.WritePropertyName("errorSettings"u8);
            writer.WriteObjectValue(ErrorSettings);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        AS2ProtocolSettings IJsonModel<AS2ProtocolSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2ProtocolSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2ProtocolSettings(document.RootElement, options);
        }

        internal static AS2ProtocolSettings DeserializeAS2ProtocolSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AS2MessageConnectionSettings messageConnectionSettings = default;
            AS2AcknowledgementConnectionSettings acknowledgementConnectionSettings = default;
            AS2MdnSettings mdnSettings = default;
            AS2SecuritySettings securitySettings = default;
            AS2ValidationSettings validationSettings = default;
            AS2EnvelopeSettings envelopeSettings = default;
            AS2ErrorSettings errorSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageConnectionSettings"u8))
                {
                    messageConnectionSettings = AS2MessageConnectionSettings.DeserializeAS2MessageConnectionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("acknowledgementConnectionSettings"u8))
                {
                    acknowledgementConnectionSettings = AS2AcknowledgementConnectionSettings.DeserializeAS2AcknowledgementConnectionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("mdnSettings"u8))
                {
                    mdnSettings = AS2MdnSettings.DeserializeAS2MdnSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    securitySettings = AS2SecuritySettings.DeserializeAS2SecuritySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationSettings"u8))
                {
                    validationSettings = AS2ValidationSettings.DeserializeAS2ValidationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("envelopeSettings"u8))
                {
                    envelopeSettings = AS2EnvelopeSettings.DeserializeAS2EnvelopeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("errorSettings"u8))
                {
                    errorSettings = AS2ErrorSettings.DeserializeAS2ErrorSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2ProtocolSettings(messageConnectionSettings, acknowledgementConnectionSettings, mdnSettings, securitySettings, validationSettings, envelopeSettings, errorSettings, serializedAdditionalRawData);
        }

        BinaryData IModel<AS2ProtocolSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2ProtocolSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AS2ProtocolSettings IModel<AS2ProtocolSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2ProtocolSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAS2ProtocolSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AS2ProtocolSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
