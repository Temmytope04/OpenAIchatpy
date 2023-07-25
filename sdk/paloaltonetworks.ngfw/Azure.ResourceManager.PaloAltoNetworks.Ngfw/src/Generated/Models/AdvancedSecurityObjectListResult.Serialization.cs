// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class AdvancedSecurityObjectListResult
    {
        internal static AdvancedSecurityObjectListResult DeserializeAdvancedSecurityObjectListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdvancedSecurityObject value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = AdvancedSecurityObject.DeserializeAdvancedSecurityObject(property.Value);
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AdvancedSecurityObjectListResult(value, nextLink.Value);
        }
    }
}
