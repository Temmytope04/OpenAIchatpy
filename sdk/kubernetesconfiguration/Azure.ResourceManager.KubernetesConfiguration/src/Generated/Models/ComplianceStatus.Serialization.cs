// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class ComplianceStatus
    {
        internal static ComplianceStatus DeserializeComplianceStatus(JsonElement element)
        {
            Optional<ComplianceStateType> complianceState = default;
            Optional<DateTimeOffset> lastConfigApplied = default;
            Optional<string> message = default;
            Optional<MessageLevelType> messageLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    complianceState = new ComplianceStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastConfigApplied"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastConfigApplied = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    messageLevel = new MessageLevelType(property.Value.GetString());
                    continue;
                }
            }
            return new ComplianceStatus(Optional.ToNullable(complianceState), Optional.ToNullable(lastConfigApplied), message.Value, Optional.ToNullable(messageLevel));
        }
    }
}
