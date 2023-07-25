// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    internal partial class ClassificationPolicyCollection
    {
        internal static ClassificationPolicyCollection DeserializeClassificationPolicyCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ClassificationPolicyItem> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ClassificationPolicyItem> array = new List<ClassificationPolicyItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClassificationPolicyItem.DeserializeClassificationPolicyItem(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ClassificationPolicyCollection(value, nextLink.Value);
        }
    }
}
