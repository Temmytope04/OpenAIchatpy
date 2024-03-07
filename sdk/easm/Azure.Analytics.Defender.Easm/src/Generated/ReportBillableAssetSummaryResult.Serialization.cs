// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Defender.Easm
{
    public partial class ReportBillableAssetSummaryResult : IUtf8JsonWriteable, IJsonModel<ReportBillableAssetSummaryResult>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportBillableAssetSummaryResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReportBillableAssetSummaryResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportBillableAssetSummaryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportBillableAssetSummaryResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AssetSummaries))
            {
                writer.WritePropertyName("assetSummaries"u8);
                writer.WriteStartArray();
                foreach (var item in AssetSummaries)
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

        ReportBillableAssetSummaryResult IJsonModel<ReportBillableAssetSummaryResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportBillableAssetSummaryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportBillableAssetSummaryResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportBillableAssetSummaryResult(document.RootElement, options);
        }

        internal static ReportBillableAssetSummaryResult DeserializeReportBillableAssetSummaryResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ReportBillableAssetSnapshotResult> assetSummaries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetSummaries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportBillableAssetSnapshotResult> array = new List<ReportBillableAssetSnapshotResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportBillableAssetSnapshotResult.DeserializeReportBillableAssetSnapshotResult(item, options));
                    }
                    assetSummaries = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportBillableAssetSummaryResult(assetSummaries ?? new ChangeTrackingList<ReportBillableAssetSnapshotResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportBillableAssetSummaryResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportBillableAssetSummaryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportBillableAssetSummaryResult)} does not support '{options.Format}' format.");
            }
        }

        ReportBillableAssetSummaryResult IPersistableModel<ReportBillableAssetSummaryResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportBillableAssetSummaryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportBillableAssetSummaryResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportBillableAssetSummaryResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportBillableAssetSummaryResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ReportBillableAssetSummaryResult FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeReportBillableAssetSummaryResult(document.RootElement);
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
