// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    internal partial class ApplicationInsightsComponentAPIKeyListResult
    {
        internal static ApplicationInsightsComponentAPIKeyListResult DeserializeApplicationInsightsComponentAPIKeyListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ApplicationInsightsComponentAPIKey> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ApplicationInsightsComponentAPIKey> array = new List<ApplicationInsightsComponentAPIKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationInsightsComponentAPIKey.DeserializeApplicationInsightsComponentAPIKey(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ApplicationInsightsComponentAPIKeyListResult(value);
        }
    }
}
