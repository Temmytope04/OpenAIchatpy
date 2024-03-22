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
    internal partial class IotSecurityAggregatedAlertList : IUtf8JsonSerializable, IJsonModel<IotSecurityAggregatedAlertList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecurityAggregatedAlertList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotSecurityAggregatedAlertList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedAlertList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedAlertList)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue<IotSecurityAggregatedAlertData>(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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
            writer.WriteEndObject();
        }

        IotSecurityAggregatedAlertList IJsonModel<IotSecurityAggregatedAlertList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedAlertList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedAlertList)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedAlertList(document.RootElement, options);
        }

        internal static IotSecurityAggregatedAlertList DeserializeIotSecurityAggregatedAlertList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IotSecurityAggregatedAlertData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IotSecurityAggregatedAlertData> array = new List<IotSecurityAggregatedAlertData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotSecurityAggregatedAlertData.DeserializeIotSecurityAggregatedAlertData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotSecurityAggregatedAlertList(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSecurityAggregatedAlertList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedAlertList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSecurityAggregatedAlertList)} does not support writing '{options.Format}' format.");
            }
        }

        IotSecurityAggregatedAlertList IPersistableModel<IotSecurityAggregatedAlertList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedAlertList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotSecurityAggregatedAlertList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSecurityAggregatedAlertList)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSecurityAggregatedAlertList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
