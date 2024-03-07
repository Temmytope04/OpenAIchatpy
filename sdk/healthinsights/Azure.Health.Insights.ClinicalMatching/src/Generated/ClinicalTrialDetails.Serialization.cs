// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class ClinicalTrialDetails : IUtf8JsonWriteable, IJsonModel<ClinicalTrialDetails>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClinicalTrialDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClinicalTrialDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClinicalTrialDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(EligibilityCriteriaText))
            {
                writer.WritePropertyName("eligibilityCriteriaText"u8);
                writer.WriteStringValue(EligibilityCriteriaText);
            }
            if (Optional.IsDefined(Demographics))
            {
                writer.WritePropertyName("demographics"u8);
                writer.WriteObjectValue(Demographics);
            }
            writer.WritePropertyName("metadata"u8);
            writer.WriteObjectValue(Metadata);
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

        ClinicalTrialDetails IJsonModel<ClinicalTrialDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClinicalTrialDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClinicalTrialDetails(document.RootElement, options);
        }

        internal static ClinicalTrialDetails DeserializeClinicalTrialDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string eligibilityCriteriaText = default;
            ClinicalTrialDemographics demographics = default;
            ClinicalTrialMetadata metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eligibilityCriteriaText"u8))
                {
                    eligibilityCriteriaText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("demographics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    demographics = ClinicalTrialDemographics.DeserializeClinicalTrialDemographics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = ClinicalTrialMetadata.DeserializeClinicalTrialMetadata(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClinicalTrialDetails(id, eligibilityCriteriaText, demographics, metadata, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClinicalTrialDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClinicalTrialDetails)} does not support '{options.Format}' format.");
            }
        }

        ClinicalTrialDetails IPersistableModel<ClinicalTrialDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClinicalTrialDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClinicalTrialDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClinicalTrialDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ClinicalTrialDetails FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeClinicalTrialDetails(document.RootElement);
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
