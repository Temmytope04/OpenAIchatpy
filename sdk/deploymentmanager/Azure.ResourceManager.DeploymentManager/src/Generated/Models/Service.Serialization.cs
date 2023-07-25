// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class Service
    {
        internal static Service DeserializeService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<ServiceUnit>> serviceUnits = default;
            string targetLocation = default;
            string targetSubscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceUnit> array = new List<ServiceUnit>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceUnit.DeserializeServiceUnit(item));
                    }
                    serviceUnits = array;
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetSubscriptionId"u8))
                {
                    targetSubscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new Service(targetLocation, targetSubscriptionId, name.Value, Optional.ToList(serviceUnits));
        }
    }
}
