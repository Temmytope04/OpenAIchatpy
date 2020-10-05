// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DataFlowListResponse
    {
        internal static DataFlowListResponse DeserializeDataFlowListResponse(JsonElement element)
        {
            IReadOnlyList<DataFlowResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DataFlowResource> array = new List<DataFlowResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowResource.DeserializeDataFlowResource(item));
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
            return new DataFlowListResponse(value, nextLink.Value);
        }
    }
}
