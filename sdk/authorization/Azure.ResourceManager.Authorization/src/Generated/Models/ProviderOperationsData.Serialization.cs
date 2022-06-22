// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class ProviderOperationsData
    {
        internal static ProviderOperationsData DeserializeProviderOperationsData(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<IReadOnlyList<ProviderOperationsResourceType>> resourceTypes = default;
            Optional<IReadOnlyList<ProviderOperation>> operations = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProviderOperationsResourceType> array = new List<ProviderOperationsResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderOperationsResourceType.DeserializeProviderOperationsResourceType(item));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("operations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProviderOperation> array = new List<ProviderOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderOperation.DeserializeProviderOperation(item));
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
            }
            return new ProviderOperationsData(id, name, type, systemData.Value, displayName.Value, Optional.ToList(resourceTypes), Optional.ToList(operations));
        }
    }
}
