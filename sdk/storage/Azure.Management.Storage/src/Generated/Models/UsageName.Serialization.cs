// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class UsageName
    {
        internal static UsageName DeserializeUsageName(JsonElement element)
        {
            string value = default;
            string localizedValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localizedValue = property.Value.GetString();
                    continue;
                }
            }
            return new UsageName(value, localizedValue);
        }
    }
}
