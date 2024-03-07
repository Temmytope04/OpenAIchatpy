// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.DocumentIntelligence
{
    public partial class AnalyzeResult : IUtf8JsonWriteable, IJsonModel<AnalyzeResult>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalyzeResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("apiVersion"u8);
            writer.WriteStringValue(ApiVersion);
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            writer.WritePropertyName("stringIndexType"u8);
            writer.WriteStringValue(StringIndexType.ToString());
            if (Optional.IsDefined(ContentFormat))
            {
                writer.WritePropertyName("contentFormat"u8);
                writer.WriteStringValue(ContentFormat.Value.ToString());
            }
            writer.WritePropertyName("content"u8);
            writer.WriteStringValue(Content);
            writer.WritePropertyName("pages"u8);
            writer.WriteStartArray();
            foreach (var item in Pages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Paragraphs))
            {
                writer.WritePropertyName("paragraphs"u8);
                writer.WriteStartArray();
                foreach (var item in Paragraphs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tables))
            {
                writer.WritePropertyName("tables"u8);
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Figures))
            {
                writer.WritePropertyName("figures"u8);
                writer.WriteStartArray();
                foreach (var item in Figures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Lists))
            {
                writer.WritePropertyName("lists"u8);
                writer.WriteStartArray();
                foreach (var item in Lists)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Sections))
            {
                writer.WritePropertyName("sections"u8);
                writer.WriteStartArray();
                foreach (var item in Sections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KeyValuePairs))
            {
                writer.WritePropertyName("keyValuePairs"u8);
                writer.WriteStartArray();
                foreach (var item in KeyValuePairs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Styles))
            {
                writer.WritePropertyName("styles"u8);
                writer.WriteStartArray();
                foreach (var item in Styles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Languages))
            {
                writer.WritePropertyName("languages"u8);
                writer.WriteStartArray();
                foreach (var item in Languages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Documents))
            {
                writer.WritePropertyName("documents"u8);
                writer.WriteStartArray();
                foreach (var item in Documents)
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

        AnalyzeResult IJsonModel<AnalyzeResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeResult(document.RootElement, options);
        }

        internal static AnalyzeResult DeserializeAnalyzeResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string apiVersion = default;
            string modelId = default;
            StringIndexType stringIndexType = default;
            ContentFormat? contentFormat = default;
            string content = default;
            IReadOnlyList<DocumentPage> pages = default;
            IReadOnlyList<DocumentParagraph> paragraphs = default;
            IReadOnlyList<DocumentTable> tables = default;
            IReadOnlyList<DocumentFigure> figures = default;
            IReadOnlyList<DocumentList> lists = default;
            IReadOnlyList<DocumentSection> sections = default;
            IReadOnlyList<DocumentKeyValuePair> keyValuePairs = default;
            IReadOnlyList<DocumentStyle> styles = default;
            IReadOnlyList<DocumentLanguage> languages = default;
            IReadOnlyList<AnalyzedDocument> documents = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFormat = new ContentFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"u8))
                {
                    List<DocumentPage> array = new List<DocumentPage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentPage.DeserializeDocumentPage(item, options));
                    }
                    pages = array;
                    continue;
                }
                if (property.NameEquals("paragraphs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentParagraph> array = new List<DocumentParagraph>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentParagraph.DeserializeDocumentParagraph(item, options));
                    }
                    paragraphs = array;
                    continue;
                }
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentTable> array = new List<DocumentTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentTable.DeserializeDocumentTable(item, options));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("figures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentFigure> array = new List<DocumentFigure>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentFigure.DeserializeDocumentFigure(item, options));
                    }
                    figures = array;
                    continue;
                }
                if (property.NameEquals("lists"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentList> array = new List<DocumentList>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentList.DeserializeDocumentList(item, options));
                    }
                    lists = array;
                    continue;
                }
                if (property.NameEquals("sections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentSection> array = new List<DocumentSection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSection.DeserializeDocumentSection(item, options));
                    }
                    sections = array;
                    continue;
                }
                if (property.NameEquals("keyValuePairs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentKeyValuePair> array = new List<DocumentKeyValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentKeyValuePair.DeserializeDocumentKeyValuePair(item, options));
                    }
                    keyValuePairs = array;
                    continue;
                }
                if (property.NameEquals("styles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentStyle> array = new List<DocumentStyle>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentStyle.DeserializeDocumentStyle(item, options));
                    }
                    styles = array;
                    continue;
                }
                if (property.NameEquals("languages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentLanguage> array = new List<DocumentLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentLanguage.DeserializeDocumentLanguage(item, options));
                    }
                    languages = array;
                    continue;
                }
                if (property.NameEquals("documents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnalyzedDocument> array = new List<AnalyzedDocument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzedDocument.DeserializeAnalyzedDocument(item, options));
                    }
                    documents = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalyzeResult(
                apiVersion,
                modelId,
                stringIndexType,
                contentFormat,
                content,
                pages,
                paragraphs ?? new ChangeTrackingList<DocumentParagraph>(),
                tables ?? new ChangeTrackingList<DocumentTable>(),
                figures ?? new ChangeTrackingList<DocumentFigure>(),
                lists ?? new ChangeTrackingList<DocumentList>(),
                sections ?? new ChangeTrackingList<DocumentSection>(),
                keyValuePairs ?? new ChangeTrackingList<DocumentKeyValuePair>(),
                styles ?? new ChangeTrackingList<DocumentStyle>(),
                languages ?? new ChangeTrackingList<DocumentLanguage>(),
                documents ?? new ChangeTrackingList<AnalyzedDocument>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeResult)} does not support '{options.Format}' format.");
            }
        }

        AnalyzeResult IPersistableModel<AnalyzeResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static AnalyzeResult FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeResult(document.RootElement);
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
