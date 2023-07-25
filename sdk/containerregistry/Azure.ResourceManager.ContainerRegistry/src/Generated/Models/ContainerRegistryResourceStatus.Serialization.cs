// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryResourceStatus
    {
        internal static ContainerRegistryResourceStatus DeserializeContainerRegistryResourceStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayStatus = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> timestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayStatus"u8))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ContainerRegistryResourceStatus(displayStatus.Value, message.Value, Optional.ToNullable(timestamp));
        }
    }
}
