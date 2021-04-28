// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class HierarchyHit
    {
        internal static HierarchyHit DeserializeHierarchyHit(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> cumulativeInstanceCount = default;
            Optional<SearchHierarchyNodesResponse> hierarchyNodes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cumulativeInstanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cumulativeInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hierarchyNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hierarchyNodes = SearchHierarchyNodesResponse.DeserializeSearchHierarchyNodesResponse(property.Value);
                    continue;
                }
            }
            return new HierarchyHit(name.Value, Optional.ToNullable(cumulativeInstanceCount), hierarchyNodes.Value);
        }
    }
}
