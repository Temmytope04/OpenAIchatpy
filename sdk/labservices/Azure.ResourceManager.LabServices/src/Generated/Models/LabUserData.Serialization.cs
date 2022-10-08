// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabUserData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AdditionalUsageQuota))
            {
                writer.WritePropertyName("additionalUsageQuota");
                writer.WriteStringValue(AdditionalUsageQuota.Value, "P");
            }
            writer.WritePropertyName("email");
            writer.WriteStringValue(Email);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LabUserData DeserializeLabUserData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<TimeSpan> additionalUsageQuota = default;
            Optional<LabServicesProvisioningState> provisioningState = default;
            Optional<string> displayName = default;
            string email = default;
            Optional<LabUserRegistrationState> registrationState = default;
            Optional<LabUserInvitationState> invitationState = default;
            Optional<DateTimeOffset> invitationSent = default;
            Optional<TimeSpan> totalUsage = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalUsageQuota"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            additionalUsageQuota = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("email"))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registrationState = property0.Value.GetString().ToLabUserRegistrationState();
                            continue;
                        }
                        if (property0.NameEquals("invitationState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            invitationState = property0.Value.GetString().ToLabUserInvitationState();
                            continue;
                        }
                        if (property0.NameEquals("invitationSent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            invitationSent = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("totalUsage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalUsage = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LabUserData(id, name, type, systemData.Value, Optional.ToNullable(additionalUsageQuota), Optional.ToNullable(provisioningState), displayName.Value, email, Optional.ToNullable(registrationState), Optional.ToNullable(invitationState), Optional.ToNullable(invitationSent), Optional.ToNullable(totalUsage));
        }
    }
}
