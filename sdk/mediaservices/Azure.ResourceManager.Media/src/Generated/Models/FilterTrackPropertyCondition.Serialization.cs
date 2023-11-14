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

namespace Azure.ResourceManager.Media.Models
{
    public partial class FilterTrackPropertyCondition : IUtf8JsonSerializable, IJsonModel<FilterTrackPropertyCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FilterTrackPropertyCondition>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FilterTrackPropertyCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FilterTrackPropertyCondition>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FilterTrackPropertyCondition>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("property"u8);
            writer.WriteStringValue(Property.ToString());
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation.ToString());
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

        FilterTrackPropertyCondition IJsonModel<FilterTrackPropertyCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FilterTrackPropertyCondition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFilterTrackPropertyCondition(document.RootElement, options);
        }

        internal static FilterTrackPropertyCondition DeserializeFilterTrackPropertyCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FilterTrackPropertyType property = default;
            string value = default;
            FilterTrackPropertyCompareOperation operation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"u8))
                {
                    property = new FilterTrackPropertyType(property0.Value.GetString());
                    continue;
                }
                if (property0.NameEquals("value"u8))
                {
                    value = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("operation"u8))
                {
                    operation = new FilterTrackPropertyCompareOperation(property0.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FilterTrackPropertyCondition(property, value, operation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FilterTrackPropertyCondition>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FilterTrackPropertyCondition)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FilterTrackPropertyCondition IPersistableModel<FilterTrackPropertyCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FilterTrackPropertyCondition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFilterTrackPropertyCondition(document.RootElement, options);
        }

        string IPersistableModel<FilterTrackPropertyCondition>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
