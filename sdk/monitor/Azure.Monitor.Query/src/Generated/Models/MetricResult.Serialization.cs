// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricResult
    {
        internal static MetricResult DeserializeMetricResult(JsonElement element)
        {
            string id = default;
            string type = default;
            LocalizableString name = default;
            Optional<string> displayDescription = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            MetricUnit unit = default;
            IReadOnlyList<TimeSeriesElement> timeseries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = LocalizableString.DeserializeLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("displayDescription"))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new MetricUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeseries"))
                {
                    List<TimeSeriesElement> array = new List<TimeSeriesElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesElement.DeserializeTimeSeriesElement(item));
                    }
                    timeseries = array;
                    continue;
                }
            }
            return new MetricResult(id, type, name, displayDescription.Value, errorCode.Value, errorMessage.Value, unit, timeseries);
        }
    }
}
