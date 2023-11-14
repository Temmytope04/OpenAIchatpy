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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SasCredentialDto : IUtf8JsonSerializable, IJsonModel<SasCredentialDto>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SasCredentialDto>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SasCredentialDto>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SasCredentialDto>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SasCredentialDto>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SasUri))
            {
                if (SasUri != null)
                {
                    writer.WritePropertyName("sasUri"u8);
                    writer.WriteStringValue(SasUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("sasUri");
                }
            }
            writer.WritePropertyName("credentialType"u8);
            writer.WriteStringValue(CredentialType.ToString());
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SasCredentialDto IJsonModel<SasCredentialDto>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasCredentialDto)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSasCredentialDto(document.RootElement, options);
        }

        internal static SasCredentialDto DeserializeSasCredentialDto(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> sasUri = default;
            PendingUploadCredentialType credentialType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasUri = null;
                        continue;
                    }
                    sasUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new PendingUploadCredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SasCredentialDto(credentialType, serializedAdditionalRawData, sasUri.Value);
        }

        BinaryData IPersistableModel<SasCredentialDto>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasCredentialDto)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SasCredentialDto IPersistableModel<SasCredentialDto>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasCredentialDto)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSasCredentialDto(document.RootElement, options);
        }

        string IPersistableModel<SasCredentialDto>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
