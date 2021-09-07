// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal partial class AuthorizationRuleListResult
    {
        internal static AuthorizationRuleListResult DeserializeAuthorizationRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AuthorizationRuleData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizationRuleData> array = new List<AuthorizationRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationRuleData.DeserializeAuthorizationRuleData(item));
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
            return new AuthorizationRuleListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
