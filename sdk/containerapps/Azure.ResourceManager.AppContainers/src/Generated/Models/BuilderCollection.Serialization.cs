// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class BuilderCollection
    {
        internal static BuilderCollection DeserializeBuilderCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<BuilderResourceData> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<BuilderResourceData> array = new List<BuilderResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BuilderResourceData.DeserializeBuilderResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new BuilderCollection(value, nextLink.Value);
        }
    }
}
