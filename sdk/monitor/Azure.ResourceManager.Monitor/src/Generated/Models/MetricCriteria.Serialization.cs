// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("threshold");
            writer.WriteNumberValue(Threshold);
            writer.WritePropertyName("criterionType");
            writer.WriteStringValue(CriterionType.ToString());
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("metricName");
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace");
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("timeAggregation");
            writer.WriteStringValue(TimeAggregation.ToString());
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions");
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SkipMetricValidation))
            {
                writer.WritePropertyName("skipMetricValidation");
                writer.WriteBooleanValue(SkipMetricValidation.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static MetricCriteria DeserializeMetricCriteria(JsonElement element)
        {
            MonitorOperator @operator = default;
            double threshold = default;
            CriterionType criterionType = default;
            string name = default;
            string metricName = default;
            Optional<string> metricNamespace = default;
            MonitorAggregationType timeAggregation = default;
            Optional<IList<MetricDimension>> dimensions = default;
            Optional<bool> skipMetricValidation = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"))
                {
                    @operator = new MonitorOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("criterionType"))
                {
                    criterionType = new CriterionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricName"))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeAggregation"))
                {
                    timeAggregation = new MonitorAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dimensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetricDimension> array = new List<MetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDimension.DeserializeMetricDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("skipMetricValidation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skipMetricValidation = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MetricCriteria(criterionType, name, metricName, metricNamespace.Value, timeAggregation, Optional.ToList(dimensions), Optional.ToNullable(skipMetricValidation), additionalProperties, @operator, threshold);
        }
    }
}
