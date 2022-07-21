// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem
    {
        internal static AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem DeserializeAgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem(JsonElement element)
        {
            Optional<bool> @default = default;
            Optional<string> kubernetesVersion = default;
            Optional<bool> isPreview = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @default = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kubernetesVersion"))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPreview"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem(Optional.ToNullable(@default), kubernetesVersion.Value, Optional.ToNullable(isPreview));
        }
    }
}
