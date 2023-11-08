// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomMetricThreshold : IUtf8JsonSerializable, IJsonModel<CustomMetricThreshold>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomMetricThreshold>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<CustomMetricThreshold>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metric"u8);
            writer.WriteStringValue(Metric);
            if (Optional.IsDefined(Threshold))
            {
                if (Threshold != null)
                {
                    writer.WritePropertyName("threshold"u8);
                    writer.WriteObjectValue(Threshold);
                }
                else
                {
                    writer.WriteNull("threshold");
                }
            }
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

        CustomMetricThreshold IJsonModel<CustomMetricThreshold>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomMetricThreshold)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomMetricThreshold(document.RootElement, options);
        }

        internal static CustomMetricThreshold DeserializeCustomMetricThreshold(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metric = default;
            Optional<MonitoringThreshold> threshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        threshold = null;
                        continue;
                    }
                    threshold = MonitoringThreshold.DeserializeMonitoringThreshold(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomMetricThreshold(metric, threshold.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<CustomMetricThreshold>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomMetricThreshold)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CustomMetricThreshold IModel<CustomMetricThreshold>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomMetricThreshold)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCustomMetricThreshold(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<CustomMetricThreshold>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
