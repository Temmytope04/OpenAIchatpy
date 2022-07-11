// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementServiceNameAvailabilityResult
    {
        internal static ApiManagementServiceNameAvailabilityResult DeserializeApiManagementServiceNameAvailabilityResult(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<string> message = default;
            Optional<NameAvailabilityReason> reason = default;
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
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reason = property.Value.GetString().ToNameAvailabilityReason();
                    continue;
                }
            }
            return new ApiManagementServiceNameAvailabilityResult(Optional.ToNullable(nameAvailable), message.Value, Optional.ToNullable(reason));
        }
    }
}
