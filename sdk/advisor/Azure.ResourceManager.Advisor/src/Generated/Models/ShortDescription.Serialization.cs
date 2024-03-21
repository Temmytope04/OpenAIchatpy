// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class ShortDescription : IUtf8JsonSerializable, IJsonModel<ShortDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShortDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShortDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShortDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShortDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Problem))
            {
                writer.WritePropertyName("problem"u8);
                writer.WriteStringValue(Problem);
            }
            if (Optional.IsDefined(Solution))
            {
                writer.WritePropertyName("solution"u8);
                writer.WriteStringValue(Solution);
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

        ShortDescription IJsonModel<ShortDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShortDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShortDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShortDescription(document.RootElement, options);
        }

        internal static ShortDescription DeserializeShortDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string problem = default;
            string solution = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("problem"u8))
                {
                    problem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("solution"u8))
                {
                    solution = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ShortDescription(problem, solution, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShortDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShortDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ShortDescription)} does not support '{options.Format}' format.");
            }
        }

        ShortDescription IPersistableModel<ShortDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShortDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShortDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ShortDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShortDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
