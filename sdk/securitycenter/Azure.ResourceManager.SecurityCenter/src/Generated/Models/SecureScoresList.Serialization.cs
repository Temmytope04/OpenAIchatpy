// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecureScoresList
    {
        internal static SecureScoresList DeserializeSecureScoresList(JsonElement element)
        {
            Optional<IReadOnlyList<SecureScoreItemData>> value = default;
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
                    List<SecureScoreItemData> array = new List<SecureScoreItemData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecureScoreItemData.DeserializeSecureScoreItemData(item));
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
            return new SecureScoresList(Optional.ToList(value), nextLink.Value);
        }
    }
}
