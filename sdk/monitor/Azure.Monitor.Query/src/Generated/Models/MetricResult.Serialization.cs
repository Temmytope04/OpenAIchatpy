// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricResult
    {
        internal static MetricResult DeserializeMetricResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string type = default;
            LocalizableString name = default;
            string displayDescription = default;
            string errorCode = default;
            string errorMessage = default;
            MetricUnit unit = default;
            IReadOnlyList<MetricTimeSeriesElement> timeseries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = LocalizableString.DeserializeLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("displayDescription"u8))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = new MetricUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeseries"u8))
                {
                    List<MetricTimeSeriesElement> array = new List<MetricTimeSeriesElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricTimeSeriesElement.DeserializeMetricTimeSeriesElement(item));
                    }
                    timeseries = array;
                    continue;
                }
            }
            return new MetricResult(
                id,
                type,
                name,
                displayDescription,
                errorCode,
                errorMessage,
                unit,
                timeseries);
        }
    }
}
