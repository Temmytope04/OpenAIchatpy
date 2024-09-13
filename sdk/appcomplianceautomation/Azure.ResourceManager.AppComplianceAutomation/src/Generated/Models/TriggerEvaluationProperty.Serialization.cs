// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class TriggerEvaluationProperty : IUtf8JsonSerializable, IJsonModel<TriggerEvaluationProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TriggerEvaluationProperty>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TriggerEvaluationProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerEvaluationProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TriggerEvaluationProperty)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(TriggerOn))
            {
                writer.WritePropertyName("triggerTime"u8);
                writer.WriteStringValue(TriggerOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EvaluationEndOn))
            {
                writer.WritePropertyName("evaluationEndTime"u8);
                writer.WriteStringValue(EvaluationEndOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(ResourceIds))
            {
                writer.WritePropertyName("resourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(QuickAssessments))
            {
                writer.WritePropertyName("quickAssessments"u8);
                writer.WriteStartArray();
                foreach (var item in QuickAssessments)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        TriggerEvaluationProperty IJsonModel<TriggerEvaluationProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerEvaluationProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TriggerEvaluationProperty)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerEvaluationProperty(document.RootElement, options);
        }

        internal static TriggerEvaluationProperty DeserializeTriggerEvaluationProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? triggerTime = default;
            DateTimeOffset? evaluationEndTime = default;
            IReadOnlyList<string> resourceIds = default;
            IReadOnlyList<QuickAssessment> quickAssessments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("evaluationEndTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceIds = array;
                    continue;
                }
                if (property.NameEquals("quickAssessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QuickAssessment> array = new List<QuickAssessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QuickAssessment.DeserializeQuickAssessment(item, options));
                    }
                    quickAssessments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TriggerEvaluationProperty(triggerTime, evaluationEndTime, resourceIds ?? new ChangeTrackingList<string>(), quickAssessments ?? new ChangeTrackingList<QuickAssessment>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TriggerEvaluationProperty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerEvaluationProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TriggerEvaluationProperty)} does not support writing '{options.Format}' format.");
            }
        }

        TriggerEvaluationProperty IPersistableModel<TriggerEvaluationProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerEvaluationProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTriggerEvaluationProperty(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TriggerEvaluationProperty)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TriggerEvaluationProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
