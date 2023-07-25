// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class ExternalSecuritySolutionList
    {
        internal static ExternalSecuritySolutionList DeserializeExternalSecuritySolutionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ExternalSecuritySolution>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExternalSecuritySolution> array = new List<ExternalSecuritySolution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExternalSecuritySolution.DeserializeExternalSecuritySolution(item));
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
            return new ExternalSecuritySolutionList(Optional.ToList(value), nextLink.Value);
        }
    }
}
