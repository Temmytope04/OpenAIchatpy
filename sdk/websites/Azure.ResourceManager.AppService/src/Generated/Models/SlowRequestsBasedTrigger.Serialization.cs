// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SlowRequestsBasedTrigger : IUtf8JsonSerializable, IJsonModel<SlowRequestsBasedTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SlowRequestsBasedTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SlowRequestsBasedTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlowRequestsBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SlowRequestsBasedTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeTaken))
            {
                writer.WritePropertyName("timeTaken"u8);
                writer.WriteStringValue(TimeTaken);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(TimeInterval))
            {
                writer.WritePropertyName("timeInterval"u8);
                writer.WriteStringValue(TimeInterval);
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

        SlowRequestsBasedTrigger IJsonModel<SlowRequestsBasedTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlowRequestsBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SlowRequestsBasedTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSlowRequestsBasedTrigger(document.RootElement, options);
        }

        internal static SlowRequestsBasedTrigger DeserializeSlowRequestsBasedTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string timeTaken = default;
            string path = default;
            int? count = default;
            string timeInterval = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeTaken"u8))
                {
                    timeTaken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeInterval"u8))
                {
                    timeInterval = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SlowRequestsBasedTrigger(timeTaken, path, count, timeInterval, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SlowRequestsBasedTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlowRequestsBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SlowRequestsBasedTrigger)} does not support '{options.Format}' format.");
            }
        }

        SlowRequestsBasedTrigger IPersistableModel<SlowRequestsBasedTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SlowRequestsBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSlowRequestsBasedTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SlowRequestsBasedTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SlowRequestsBasedTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
