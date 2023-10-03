// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownWebhook : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EventType))
            {
                if (EventType != null)
                {
                    writer.WritePropertyName("eventType"u8);
                    writer.WriteStringValue(EventType);
                }
                else
                {
                    writer.WriteNull("eventType");
                }
            }
            writer.WritePropertyName("webhookType"u8);
            writer.WriteStringValue(WebhookType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownWebhook DeserializeUnknownWebhook(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eventType = default;
            MachineLearningWebhookType webhookType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        eventType = null;
                        continue;
                    }
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webhookType"u8))
                {
                    webhookType = new MachineLearningWebhookType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownWebhook(eventType.Value, webhookType);
        }
    }
}
