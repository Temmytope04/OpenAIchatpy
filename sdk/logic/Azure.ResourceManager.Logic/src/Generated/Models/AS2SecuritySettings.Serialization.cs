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
    public partial class AS2SecuritySettings : IUtf8JsonSerializable, IJsonModel<AS2SecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2SecuritySettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AS2SecuritySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
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

        AS2SecuritySettings IJsonModel<AS2SecuritySettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2SecuritySettings(document.RootElement, options);
        }

        internal static AS2SecuritySettings DeserializeAS2SecuritySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool overrideGroupSigningCertificate = default;
            Optional<string> signingCertificateName = default;
            Optional<string> encryptionCertificateName = default;
            bool enableNrrForInboundEncodedMessages = default;
            bool enableNrrForInboundDecodedMessages = default;
            bool enableNrrForOutboundMdn = default;
            bool enableNrrForOutboundEncodedMessages = default;
            bool enableNrrForOutboundDecodedMessages = default;
            bool enableNrrForInboundMdn = default;
            Optional<string> sha2AlgorithmFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2SecuritySettings(overrideGroupSigningCertificate, signingCertificateName.Value, encryptionCertificateName.Value, enableNrrForInboundEncodedMessages, enableNrrForInboundDecodedMessages, enableNrrForOutboundMdn, enableNrrForOutboundEncodedMessages, enableNrrForOutboundDecodedMessages, enableNrrForInboundMdn, sha2AlgorithmFormat.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<AS2SecuritySettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AS2SecuritySettings IModel<AS2SecuritySettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2SecuritySettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAS2SecuritySettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AS2SecuritySettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
