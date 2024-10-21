// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class TrackPropertyCondition : IUtf8JsonSerializable, IJsonModel<TrackPropertyCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrackPropertyCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrackPropertyCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackPropertyCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrackPropertyCondition)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("property"u8);
            writer.WriteStringValue(Property.ToString());
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation.ToString());
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        TrackPropertyCondition IJsonModel<TrackPropertyCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackPropertyCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrackPropertyCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrackPropertyCondition(document.RootElement, options);
        }

        internal static TrackPropertyCondition DeserializeTrackPropertyCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrackPropertyType property = default;
            TrackPropertyCompareOperation operation = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"u8))
                {
                    property = new TrackPropertyType(property0.Value.GetString());
                    continue;
                }
                if (property0.NameEquals("operation"u8))
                {
                    operation = new TrackPropertyCompareOperation(property0.Value.GetString());
                    continue;
                }
                if (property0.NameEquals("value"u8))
                {
                    value = property0.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TrackPropertyCondition(property, operation, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrackPropertyCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackPropertyCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrackPropertyCondition)} does not support writing '{options.Format}' format.");
            }
        }

        TrackPropertyCondition IPersistableModel<TrackPropertyCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackPropertyCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrackPropertyCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrackPropertyCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrackPropertyCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
