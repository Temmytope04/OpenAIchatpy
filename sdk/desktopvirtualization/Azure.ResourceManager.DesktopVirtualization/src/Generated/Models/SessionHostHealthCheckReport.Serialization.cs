// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHostHealthCheckReport
    {
        internal static SessionHostHealthCheckReport DeserializeSessionHostHealthCheckReport(JsonElement element)
        {
            Optional<SessionHostHealthCheckName> healthCheckName = default;
            Optional<SessionHostHealthCheckResult> healthCheckResult = default;
            Optional<SessionHostHealthCheckFailureDetails> additionalFailureDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthCheckName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    healthCheckName = new SessionHostHealthCheckName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthCheckResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    healthCheckResult = new SessionHostHealthCheckResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("additionalFailureDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalFailureDetails = SessionHostHealthCheckFailureDetails.DeserializeSessionHostHealthCheckFailureDetails(property.Value);
                    continue;
                }
            }
            return new SessionHostHealthCheckReport(Optional.ToNullable(healthCheckName), Optional.ToNullable(healthCheckResult), additionalFailureDetails.Value);
        }
    }
}
