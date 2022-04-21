// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CheckEndpointNameAvailabilityOutput
    {
        internal static CheckEndpointNameAvailabilityOutput DeserializeCheckEndpointNameAvailabilityOutput(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<string> availableHostname = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availableHostname"))
                {
                    availableHostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new CheckEndpointNameAvailabilityOutput(Optional.ToNullable(nameAvailable), availableHostname.Value, reason.Value, message.Value);
        }
    }
}
