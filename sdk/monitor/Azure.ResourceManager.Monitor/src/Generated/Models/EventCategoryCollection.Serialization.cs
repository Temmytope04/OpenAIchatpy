// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class EventCategoryCollection
    {
        internal static EventCategoryCollection DeserializeEventCategoryCollection(JsonElement element)
        {
            IReadOnlyList<MonitorLocalizableString> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<MonitorLocalizableString> array = new List<MonitorLocalizableString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorLocalizableString.DeserializeMonitorLocalizableString(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EventCategoryCollection(value);
        }
    }
}
