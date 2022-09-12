// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    public partial class RouteMatrixResultResponse
    {
        internal static RouteMatrixResultResponse DeserializeRouteMatrixResultResponse(JsonElement element)
        {
            Optional<RouteLegSummary> routeSummary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routeSummary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routeSummary = RouteLegSummary.DeserializeRouteLegSummary(property.Value);
                    continue;
                }
            }
            return new RouteMatrixResultResponse(routeSummary.Value);
        }
    }
}
