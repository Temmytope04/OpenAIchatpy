// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class DiagnosticSettingsResourceCollection
    {
        internal static DiagnosticSettingsResourceCollection DeserializeDiagnosticSettingsResourceCollection(JsonElement element)
        {
            Optional<IReadOnlyList<DiagnosticSettingsResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DiagnosticSettingsResource> array = new List<DiagnosticSettingsResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticSettingsResource.DeserializeDiagnosticSettingsResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DiagnosticSettingsResourceCollection(Optional.ToList(value));
        }
    }
}
