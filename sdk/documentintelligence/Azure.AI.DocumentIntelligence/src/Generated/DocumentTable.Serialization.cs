// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentTable : IUtf8JsonWriteable, IJsonModel<DocumentTable>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentTable>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentTable>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentTable)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rowCount"u8);
            writer.WriteNumberValue(RowCount);
            writer.WritePropertyName("columnCount"u8);
            writer.WriteNumberValue(ColumnCount);
            writer.WritePropertyName("cells"u8);
            writer.WriteStartArray();
            foreach (var item in Cells)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(BoundingRegions))
            {
                writer.WritePropertyName("boundingRegions"u8);
                writer.WriteStartArray();
                foreach (var item in BoundingRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("spans"u8);
            writer.WriteStartArray();
            foreach (var item in Spans)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Caption))
            {
                writer.WritePropertyName("caption"u8);
                writer.WriteObjectValue(Caption);
            }
            if (Optional.IsCollectionDefined(Footnotes))
            {
                writer.WritePropertyName("footnotes"u8);
                writer.WriteStartArray();
                foreach (var item in Footnotes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DocumentTable IJsonModel<DocumentTable>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentTable)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentTable(document.RootElement, options);
        }

        internal static DocumentTable DeserializeDocumentTable(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rowCount = default;
            int columnCount = default;
            IReadOnlyList<DocumentTableCell> cells = default;
            IReadOnlyList<BoundingRegion> boundingRegions = default;
            IReadOnlyList<DocumentSpan> spans = default;
            DocumentCaption caption = default;
            IReadOnlyList<DocumentFootnote> footnotes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rowCount"u8))
                {
                    rowCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnCount"u8))
                {
                    columnCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"u8))
                {
                    List<DocumentTableCell> array = new List<DocumentTableCell>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentTableCell.DeserializeDocumentTableCell(item, options));
                    }
                    cells = array;
                    continue;
                }
                if (property.NameEquals("boundingRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BoundingRegion> array = new List<BoundingRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BoundingRegion.DeserializeBoundingRegion(item, options));
                    }
                    boundingRegions = array;
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item, options));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("caption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caption = DocumentCaption.DeserializeDocumentCaption(property.Value, options);
                    continue;
                }
                if (property.NameEquals("footnotes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentFootnote> array = new List<DocumentFootnote>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentFootnote.DeserializeDocumentFootnote(item, options));
                    }
                    footnotes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentTable(
                rowCount,
                columnCount,
                cells,
                boundingRegions ?? new ChangeTrackingList<BoundingRegion>(),
                spans,
                caption,
                footnotes ?? new ChangeTrackingList<DocumentFootnote>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentTable>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentTable)} does not support '{options.Format}' format.");
            }
        }

        DocumentTable IPersistableModel<DocumentTable>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentTable(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentTable)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentTable>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static DocumentTable FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentTable(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
