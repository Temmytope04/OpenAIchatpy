// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AdaptiveApplicationControlIssueSummary
    {
        internal static AdaptiveApplicationControlIssueSummary DeserializeAdaptiveApplicationControlIssueSummary(JsonElement element)
        {
            Optional<AdaptiveApplicationControlIssue> issue = default;
            Optional<float> numberOfVms = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    issue = new AdaptiveApplicationControlIssue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("numberOfVms"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numberOfVms = property.Value.GetSingle();
                    continue;
                }
            }
            return new AdaptiveApplicationControlIssueSummary(Optional.ToNullable(issue), Optional.ToNullable(numberOfVms));
        }
    }
}
