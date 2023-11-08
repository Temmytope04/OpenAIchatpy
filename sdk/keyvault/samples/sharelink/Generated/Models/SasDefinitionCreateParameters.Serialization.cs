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

namespace Azure.Security.KeyVault.Storage.Models
{
    internal partial class SasDefinitionCreateParameters : IUtf8JsonSerializable, IJsonModel<SasDefinitionCreateParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SasDefinitionCreateParameters>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SasDefinitionCreateParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("templateUri"u8);
            writer.WriteStringValue(TemplateUri);
            writer.WritePropertyName("sasType"u8);
            writer.WriteStringValue(SasType.ToString());
            writer.WritePropertyName("validityPeriod"u8);
            writer.WriteStringValue(ValidityPeriod);
            if (Optional.IsDefined(SasDefinitionAttributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteObjectValue(SasDefinitionAttributes);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        SasDefinitionCreateParameters IJsonModel<SasDefinitionCreateParameters>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasDefinitionCreateParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSasDefinitionCreateParameters(document.RootElement, options);
        }

        internal static SasDefinitionCreateParameters DeserializeSasDefinitionCreateParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string templateUri = default;
            SasTokenType sasType = default;
            string validityPeriod = default;
            Optional<SasDefinitionAttributes> attributes = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateUri"u8))
                {
                    templateUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasType"u8))
                {
                    sasType = new SasTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validityPeriod"u8))
                {
                    validityPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = SasDefinitionAttributes.DeserializeSasDefinitionAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SasDefinitionCreateParameters(templateUri, sasType, validityPeriod, attributes.Value, Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IModel<SasDefinitionCreateParameters>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasDefinitionCreateParameters)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SasDefinitionCreateParameters IModel<SasDefinitionCreateParameters>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasDefinitionCreateParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSasDefinitionCreateParameters(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SasDefinitionCreateParameters>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
