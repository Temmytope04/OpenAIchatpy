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
    public partial class MachineLearningEndpointAuthKeys : IUtf8JsonSerializable, IJsonModel<MachineLearningEndpointAuthKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEndpointAuthKeys>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningEndpointAuthKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningEndpointAuthKeys>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningEndpointAuthKeys>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKey))
            {
                if (PrimaryKey != null)
                {
                    writer.WritePropertyName("primaryKey"u8);
                    writer.WriteStringValue(PrimaryKey);
                }
                else
                {
                    writer.WriteNull("primaryKey");
                }
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                if (SecondaryKey != null)
                {
                    writer.WritePropertyName("secondaryKey"u8);
                    writer.WriteStringValue(SecondaryKey);
                }
                else
                {
                    writer.WriteNull("secondaryKey");
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

        MachineLearningEndpointAuthKeys IJsonModel<MachineLearningEndpointAuthKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointAuthKeys)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEndpointAuthKeys(document.RootElement, options);
        }

        internal static MachineLearningEndpointAuthKeys DeserializeMachineLearningEndpointAuthKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryKey = null;
                        continue;
                    }
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secondaryKey = null;
                        continue;
                    }
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningEndpointAuthKeys(primaryKey.Value, secondaryKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningEndpointAuthKeys>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointAuthKeys)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningEndpointAuthKeys IPersistableModel<MachineLearningEndpointAuthKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointAuthKeys)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningEndpointAuthKeys(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningEndpointAuthKeys>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
