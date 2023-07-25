// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicySummary
    {
        internal static PolicySummary DeserializePolicySummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataId = default;
            Optional<string> odataContext = default;
            Optional<PolicySummaryResults> results = default;
            Optional<IReadOnlyList<PolicyAssignmentSummary>> policyAssignments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PolicySummaryResults.DeserializePolicySummaryResults(property.Value);
                    continue;
                }
                if (property.NameEquals("policyAssignments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyAssignmentSummary> array = new List<PolicyAssignmentSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyAssignmentSummary.DeserializePolicyAssignmentSummary(item));
                    }
                    policyAssignments = array;
                    continue;
                }
            }
            return new PolicySummary(odataId.Value, odataContext.Value, results.Value, Optional.ToList(policyAssignments));
        }
    }
}
