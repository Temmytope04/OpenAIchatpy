// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class FqdnEndpointDetail
    {
        internal static FqdnEndpointDetail DeserializeFqdnEndpointDetail(JsonElement element)
        {
            Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new FqdnEndpointDetail(Optional.ToNullable(port));
        }
    }
}
