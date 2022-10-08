// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeMetricConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceId");
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(MdmAccount))
            {
                writer.WritePropertyName("mdmAccount");
                writer.WriteStringValue(MdmAccount);
            }
            if (Optional.IsDefined(MetricNameSpace))
            {
                writer.WritePropertyName("metricNameSpace");
                writer.WriteStringValue(MetricNameSpace);
            }
            writer.WritePropertyName("counterSets");
            writer.WriteStartArray();
            foreach (var item in CounterSets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeMetricConfiguration DeserializeDataBoxEdgeMetricConfiguration(JsonElement element)
        {
            ResourceIdentifier resourceId = default;
            Optional<string> mdmAccount = default;
            Optional<string> metricNameSpace = default;
            IList<DataBoxEdgeMetricCounterSet> counterSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mdmAccount"))
                {
                    mdmAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNameSpace"))
                {
                    metricNameSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("counterSets"))
                {
                    List<DataBoxEdgeMetricCounterSet> array = new List<DataBoxEdgeMetricCounterSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeMetricCounterSet.DeserializeDataBoxEdgeMetricCounterSet(item));
                    }
                    counterSets = array;
                    continue;
                }
            }
            return new DataBoxEdgeMetricConfiguration(resourceId, mdmAccount.Value, metricNameSpace.Value, counterSets);
        }
    }
}
