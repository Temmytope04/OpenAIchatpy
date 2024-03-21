// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasGlossaryHeader : IUtf8JsonSerializable, IJsonModel<AtlasGlossaryHeader>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasGlossaryHeader>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AtlasGlossaryHeader>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryHeader>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasGlossaryHeader)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayText))
            {
                writer.WritePropertyName("displayText"u8);
                writer.WriteStringValue(DisplayText);
            }
            if (Optional.IsDefined(GlossaryGuid))
            {
                writer.WritePropertyName("glossaryGuid"u8);
                writer.WriteStringValue(GlossaryGuid);
            }
            if (Optional.IsDefined(RelationGuid))
            {
                writer.WritePropertyName("relationGuid"u8);
                writer.WriteStringValue(RelationGuid);
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

        AtlasGlossaryHeader IJsonModel<AtlasGlossaryHeader>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryHeader>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasGlossaryHeader)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasGlossaryHeader(document.RootElement, options);
        }

        internal static AtlasGlossaryHeader DeserializeAtlasGlossaryHeader(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayText = default;
            string glossaryGuid = default;
            string relationGuid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("glossaryGuid"u8))
                {
                    glossaryGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relationGuid"u8))
                {
                    relationGuid = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AtlasGlossaryHeader(displayText, glossaryGuid, relationGuid, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasGlossaryHeader>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryHeader>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasGlossaryHeader)} does not support '{options.Format}' format.");
            }
        }

        AtlasGlossaryHeader IPersistableModel<AtlasGlossaryHeader>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryHeader>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasGlossaryHeader(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasGlossaryHeader)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasGlossaryHeader>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasGlossaryHeader FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasGlossaryHeader(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
