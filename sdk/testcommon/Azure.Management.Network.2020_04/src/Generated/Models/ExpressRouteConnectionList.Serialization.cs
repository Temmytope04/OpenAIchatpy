// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteConnectionList
    {
        internal static ExpressRouteConnectionList DeserializeExpressRouteConnectionList(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRouteConnection>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ExpressRouteConnection> array = new List<ExpressRouteConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteConnection.DeserializeExpressRouteConnection(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ExpressRouteConnectionList(Optional.ToList(value));
        }
    }
}
