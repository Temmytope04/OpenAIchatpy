// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PipelineCreateRunResult
    {
        internal static PipelineCreateRunResult DeserializePipelineCreateRunResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid runId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetGuid();
                    continue;
                }
            }
            return new PipelineCreateRunResult(runId);
        }
    }
}
