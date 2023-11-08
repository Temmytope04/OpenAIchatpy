// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    public partial class MetricAnomalyFeedback : IUtf8JsonSerializable, IJsonModel<MetricAnomalyFeedback>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricAnomalyFeedback>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MetricAnomalyFeedback>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartsOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndsOn, "O");
            writer.WritePropertyName("value"u8);
            writer.WriteObjectValue(ValueInternal);
            if (Optional.IsDefined(DetectionConfigurationId))
            {
                if (DetectionConfigurationId != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationId"u8);
                    writer.WriteStringValue(DetectionConfigurationId);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationId");
                }
            }
            if (Optional.IsDefined(DetectionConfigurationSnapshot))
            {
                if (DetectionConfigurationSnapshot != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationSnapshot"u8);
                    writer.WriteObjectValue(DetectionConfigurationSnapshot);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationSnapshot");
                }
            }
            writer.WritePropertyName("feedbackType"u8);
            writer.WriteStringValue(FeedbackKind.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Id))
                {
                    writer.WritePropertyName("feedbackId"u8);
                    writer.WriteStringValue(Id);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    writer.WritePropertyName("createdTime"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(UserPrincipal))
                {
                    writer.WritePropertyName("userPrincipal"u8);
                    writer.WriteStringValue(UserPrincipal);
                }
            }
            writer.WritePropertyName("metricId"u8);
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter"u8);
            writer.WriteObjectValue(DimensionFilter);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MetricAnomalyFeedback IJsonModel<MetricAnomalyFeedback>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricAnomalyFeedback)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricAnomalyFeedback(document.RootElement, options);
        }

        internal static MetricAnomalyFeedback DeserializeMetricAnomalyFeedback(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            AnomalyFeedbackValue value = default;
            Optional<string> anomalyDetectionConfigurationId = default;
            Optional<AnomalyDetectionConfiguration> anomalyDetectionConfigurationSnapshot = default;
            MetricFeedbackKind feedbackType = default;
            Optional<string> feedbackId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackFilter dimensionFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = AnomalyFeedbackValue.DeserializeAnomalyFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationId = null;
                        continue;
                    }
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationSnapshot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationSnapshot = null;
                        continue;
                    }
                    anomalyDetectionConfigurationSnapshot = AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("feedbackType"u8))
                {
                    feedbackType = new MetricFeedbackKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("feedbackId"u8))
                {
                    feedbackId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userPrincipal"u8))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"u8))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"u8))
                {
                    dimensionFilter = FeedbackFilter.DeserializeFeedbackFilter(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricAnomalyFeedback(feedbackType, feedbackId.Value, Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, serializedAdditionalRawData, startTime, endTime, value, anomalyDetectionConfigurationId.Value, anomalyDetectionConfigurationSnapshot.Value);
        }

        BinaryData IModel<MetricAnomalyFeedback>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricAnomalyFeedback)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MetricAnomalyFeedback IModel<MetricAnomalyFeedback>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricAnomalyFeedback)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMetricAnomalyFeedback(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MetricAnomalyFeedback>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
