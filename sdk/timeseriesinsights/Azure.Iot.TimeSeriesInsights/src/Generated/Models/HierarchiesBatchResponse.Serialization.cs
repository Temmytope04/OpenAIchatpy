// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class HierarchiesBatchResponse
    {
        internal static HierarchiesBatchResponse DeserializeHierarchiesBatchResponse(JsonElement element)
        {
            Optional<IReadOnlyList<TimeSeriesHierarchyOrError>> @get = default;
            Optional<IReadOnlyList<TimeSeriesHierarchyOrError>> put = default;
            Optional<IReadOnlyList<TsiErrorBody>> delete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("get"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TimeSeriesHierarchyOrError> array = new List<TimeSeriesHierarchyOrError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesHierarchyOrError.DeserializeTimeSeriesHierarchyOrError(item));
                    }
                    @get = array;
                    continue;
                }
                if (property.NameEquals("put"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TimeSeriesHierarchyOrError> array = new List<TimeSeriesHierarchyOrError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesHierarchyOrError.DeserializeTimeSeriesHierarchyOrError(item));
                    }
                    put = array;
                    continue;
                }
                if (property.NameEquals("delete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TsiErrorBody> array = new List<TsiErrorBody>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TsiErrorBody.DeserializeTsiErrorBody(item));
                    }
                    delete = array;
                    continue;
                }
            }
            return new HierarchiesBatchResponse(Optional.ToList(@get), Optional.ToList(put), Optional.ToList(delete));
        }
    }
}
