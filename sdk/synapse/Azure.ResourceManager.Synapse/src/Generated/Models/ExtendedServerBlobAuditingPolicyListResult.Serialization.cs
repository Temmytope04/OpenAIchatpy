// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class ExtendedServerBlobAuditingPolicyListResult
    {
        internal static ExtendedServerBlobAuditingPolicyListResult DeserializeExtendedServerBlobAuditingPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExtendedServerBlobAuditingPolicyData>> value = default;
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
                    List<ExtendedServerBlobAuditingPolicyData> array = new List<ExtendedServerBlobAuditingPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtendedServerBlobAuditingPolicyData.DeserializeExtendedServerBlobAuditingPolicyData(item));
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
            return new ExtendedServerBlobAuditingPolicyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
