// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ListAmlUserFeatureResult
    {
        internal static ListAmlUserFeatureResult DeserializeListAmlUserFeatureResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MachineLearningUserFeature>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningUserFeature> array = new List<MachineLearningUserFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningUserFeature.DeserializeMachineLearningUserFeature(item));
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
            return new ListAmlUserFeatureResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
