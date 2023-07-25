// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class OnlineDeploymentTrackedResourceArmPaginatedResult
    {
        internal static OnlineDeploymentTrackedResourceArmPaginatedResult DeserializeOnlineDeploymentTrackedResourceArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningOnlineDeploymentData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningOnlineDeploymentData> array = new List<MachineLearningOnlineDeploymentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningOnlineDeploymentData.DeserializeMachineLearningOnlineDeploymentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new OnlineDeploymentTrackedResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
