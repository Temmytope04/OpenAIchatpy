// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class JobCredentialListResult
    {
        internal static JobCredentialListResult DeserializeJobCredentialListResult(JsonElement element)
        {
            Optional<IReadOnlyList<JobCredentialData>> value = default;
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
                    List<JobCredentialData> array = new List<JobCredentialData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobCredentialData.DeserializeJobCredentialData(item));
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
            return new JobCredentialListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
