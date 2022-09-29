// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    public partial class SupportTicketCommunicationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Sender))
            {
                writer.WritePropertyName("sender");
                writer.WriteStringValue(Sender);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject");
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body");
                writer.WriteStringValue(Body);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SupportTicketCommunicationData DeserializeSupportTicketCommunicationData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SupportTicketCommunicationType> communicationType = default;
            Optional<SupportTicketCommunicationDirection> communicationDirection = default;
            Optional<string> sender = default;
            Optional<string> subject = default;
            Optional<string> body = default;
            Optional<DateTimeOffset> createdDate = default;
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
                        if (property0.NameEquals("communicationType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            communicationType = new SupportTicketCommunicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("communicationDirection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            communicationDirection = new SupportTicketCommunicationDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sender"))
                        {
                            sender = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subject"))
                        {
                            subject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("body"))
                        {
                            body = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SupportTicketCommunicationData(id, name, type, systemData.Value, Optional.ToNullable(communicationType), Optional.ToNullable(communicationDirection), sender.Value, subject.Value, body.Value, Optional.ToNullable(createdDate));
        }
    }
}
