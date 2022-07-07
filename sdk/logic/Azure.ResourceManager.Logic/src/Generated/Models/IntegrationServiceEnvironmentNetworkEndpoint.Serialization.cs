// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentNetworkEndpoint
    {
        internal static IntegrationServiceEnvironmentNetworkEndpoint DeserializeIntegrationServiceEnvironmentNetworkEndpoint(JsonElement element)
        {
            Optional<IntegrationServiceEnvironmentNetworkEndPointAccessibilityState> accessibility = default;
            Optional<string> domainName = default;
            Optional<IReadOnlyList<string>> ports = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessibility"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accessibility = new IntegrationServiceEnvironmentNetworkEndPointAccessibilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("domainName"))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ports"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentNetworkEndpoint(Optional.ToNullable(accessibility), domainName.Value, Optional.ToList(ports));
        }
    }
}
