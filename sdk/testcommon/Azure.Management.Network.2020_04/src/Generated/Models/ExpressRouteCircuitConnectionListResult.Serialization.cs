// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCircuitConnectionListResult
    {
        internal static ExpressRouteCircuitConnectionListResult DeserializeExpressRouteCircuitConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRouteCircuitConnection>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ExpressRouteCircuitConnection> array = new List<ExpressRouteCircuitConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteCircuitConnection.DeserializeExpressRouteCircuitConnection(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressRouteCircuitConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
