// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2SecuritySettings : IUtf8JsonSerializable, IJsonModel<AS2SecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2SecuritySettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AS2SecuritySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2SecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("overrideGroupSigningCertificate"u8);
            writer.WriteBooleanValue(OverrideGroupSigningCertificate);
            if (Optional.IsDefined(SigningCertificateName))
            {
                writer.WritePropertyName("signingCertificateName"u8);
                writer.WriteStringValue(SigningCertificateName);
            }
            if (Optional.IsDefined(EncryptionCertificateName))
            {
                writer.WritePropertyName("encryptionCertificateName"u8);
                writer.WriteStringValue(EncryptionCertificateName);
            }
            writer.WritePropertyName("enableNRRForInboundEncodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForInboundEncodedMessages);
            writer.WritePropertyName("enableNRRForInboundDecodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForInboundDecodedMessages);
            writer.WritePropertyName("enableNRRForOutboundMDN"u8);
            writer.WriteBooleanValue(EnableNrrForOutboundMdn);
            writer.WritePropertyName("enableNRRForOutboundEncodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForOutboundEncodedMessages);
            writer.WritePropertyName("enableNRRForOutboundDecodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForOutboundDecodedMessages);
            writer.WritePropertyName("enableNRRForInboundMDN"u8);
            writer.WriteBooleanValue(EnableNrrForInboundMdn);
            if (Optional.IsDefined(Sha2AlgorithmFormat))
            {
                writer.WritePropertyName("sha2AlgorithmFormat"u8);
                writer.WriteStringValue(Sha2AlgorithmFormat);
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
        }

        AS2SecuritySettings IJsonModel<AS2SecuritySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2SecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2SecuritySettings(document.RootElement, options);
        }

        internal static AS2SecuritySettings DeserializeAS2SecuritySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool overrideGroupSigningCertificate = default;
            string signingCertificateName = default;
            string encryptionCertificateName = default;
            bool enableNrrForInboundEncodedMessages = default;
            bool enableNrrForInboundDecodedMessages = default;
            bool enableNrrForOutboundMdn = default;
            bool enableNrrForOutboundEncodedMessages = default;
            bool enableNrrForOutboundDecodedMessages = default;
            bool enableNrrForInboundMdn = default;
            string sha2AlgorithmFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overrideGroupSigningCertificate"u8))
                {
                    overrideGroupSigningCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signingCertificateName"u8))
                {
                    signingCertificateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionCertificateName"u8))
                {
                    encryptionCertificateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableNRRForInboundEncodedMessages"u8))
                {
                    enableNrrForInboundEncodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForInboundDecodedMessages"u8))
                {
                    enableNrrForInboundDecodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForOutboundMDN"u8))
                {
                    enableNrrForOutboundMdn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForOutboundEncodedMessages"u8))
                {
                    enableNrrForOutboundEncodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForOutboundDecodedMessages"u8))
                {
                    enableNrrForOutboundDecodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForInboundMDN"u8))
                {
                    enableNrrForInboundMdn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sha2AlgorithmFormat"u8))
                {
                    sha2AlgorithmFormat = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AS2SecuritySettings(
                overrideGroupSigningCertificate,
                signingCertificateName,
                encryptionCertificateName,
                enableNrrForInboundEncodedMessages,
                enableNrrForInboundDecodedMessages,
                enableNrrForOutboundMdn,
                enableNrrForOutboundEncodedMessages,
                enableNrrForOutboundDecodedMessages,
                enableNrrForInboundMdn,
                sha2AlgorithmFormat,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2SecuritySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2SecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support writing '{options.Format}' format.");
            }
        }

        AS2SecuritySettings IPersistableModel<AS2SecuritySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2SecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAS2SecuritySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AS2SecuritySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
