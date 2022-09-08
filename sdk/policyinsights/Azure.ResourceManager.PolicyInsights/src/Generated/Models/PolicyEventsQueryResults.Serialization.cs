// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    internal partial class PolicyEventsQueryResults
    {
        internal static PolicyEventsQueryResults DeserializePolicyEventsQueryResults(JsonElement element)
        {
            Optional<string> odataContext = default;
            Optional<int> odataCount = default;
            Optional<string> odataNextLink = default;
            Optional<IReadOnlyList<PolicyEvent>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicyEvent> array = new List<PolicyEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyEvent.DeserializePolicyEvent(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PolicyEventsQueryResults(odataContext.Value, Optional.ToNullable(odataCount), odataNextLink.Value, Optional.ToList(value));
        }
    }
}
