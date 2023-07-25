// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Models
{
    internal partial class ArtifactList
    {
        internal static ArtifactList DeserializeArtifactList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ArtifactData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ArtifactData> array = new List<ArtifactData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArtifactData.DeserializeArtifactData(item));
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
            return new ArtifactList(Optional.ToList(value), nextLink.Value);
        }
    }
}
