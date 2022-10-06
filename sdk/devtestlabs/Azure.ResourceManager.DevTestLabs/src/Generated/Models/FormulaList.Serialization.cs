// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class FormulaList
    {
        internal static FormulaList DeserializeFormulaList(JsonElement element)
        {
            Optional<IReadOnlyList<FormulaData>> value = default;
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
                    List<FormulaData> array = new List<FormulaData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormulaData.DeserializeFormulaData(item));
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
            return new FormulaList(Optional.ToList(value), nextLink.Value);
        }
    }
}
