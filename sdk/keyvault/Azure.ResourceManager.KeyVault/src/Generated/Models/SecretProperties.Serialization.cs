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

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class SecretProperties : IUtf8JsonSerializable, IJsonModel<SecretProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecretProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SecretProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecretProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecretProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(Attributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteObjectValue(Attributes);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SecretUri))
                {
                    writer.WritePropertyName("secretUri"u8);
                    writer.WriteStringValue(SecretUri.AbsoluteUri);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SecretUriWithVersion))
                {
                    writer.WritePropertyName("secretUriWithVersion"u8);
                    writer.WriteStringValue(SecretUriWithVersion);
                }
            }
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

        SecretProperties IJsonModel<SecretProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecretProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecretProperties(document.RootElement, options);
        }

        internal static SecretProperties DeserializeSecretProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> value = default;
            Optional<string> contentType = default;
            Optional<SecretAttributes> attributes = default;
            Optional<Uri> secretUri = default;
            Optional<string> secretUriWithVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = SecretAttributes.DeserializeSecretAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("secretUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secretUriWithVersion"u8))
                {
                    secretUriWithVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecretProperties(value.Value, contentType.Value, attributes.Value, secretUri.Value, secretUriWithVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecretProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecretProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecretProperties IPersistableModel<SecretProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecretProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecretProperties(document.RootElement, options);
        }

        string IPersistableModel<SecretProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
