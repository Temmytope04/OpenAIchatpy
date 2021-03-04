// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    internal partial class PageableListOfDeploymentDeviceStates
    {
        internal static PageableListOfDeploymentDeviceStates DeserializePageableListOfDeploymentDeviceStates(JsonElement element)
        {
            Optional<IReadOnlyList<DeploymentDeviceState>> value = default;
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
                    List<DeploymentDeviceState> array = new List<DeploymentDeviceState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeploymentDeviceState.DeserializeDeploymentDeviceState(item));
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
            return new PageableListOfDeploymentDeviceStates(Optional.ToList(value), nextLink.Value);
        }
    }
}
