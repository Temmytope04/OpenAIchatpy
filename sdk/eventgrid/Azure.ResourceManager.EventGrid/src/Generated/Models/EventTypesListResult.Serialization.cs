// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class EventTypesListResult
    {
        internal static EventTypesListResult DeserializeEventTypesListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EventTypeUnderTopic>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventTypeUnderTopic> array = new List<EventTypeUnderTopic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventTypeUnderTopic.DeserializeEventTypeUnderTopic(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EventTypesListResult(Optional.ToList(value));
        }
    }
}
