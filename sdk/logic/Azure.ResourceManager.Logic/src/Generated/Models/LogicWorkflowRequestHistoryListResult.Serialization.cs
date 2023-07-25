// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class LogicWorkflowRequestHistoryListResult
    {
        internal static LogicWorkflowRequestHistoryListResult DeserializeLogicWorkflowRequestHistoryListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<LogicWorkflowRequestHistoryData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicWorkflowRequestHistoryData> array = new List<LogicWorkflowRequestHistoryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogicWorkflowRequestHistoryData.DeserializeLogicWorkflowRequestHistoryData(item));
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
            return new LogicWorkflowRequestHistoryListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
