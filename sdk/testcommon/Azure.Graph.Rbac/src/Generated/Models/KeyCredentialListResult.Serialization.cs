// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class KeyCredentialListResult
    {
        internal static KeyCredentialListResult DeserializeKeyCredentialListResult(JsonElement element)
        {
            Optional<IReadOnlyList<KeyCredential>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KeyCredential> array = new List<KeyCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyCredential.DeserializeKeyCredential(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new KeyCredentialListResult(Optional.ToList(value));
        }
    }
}
