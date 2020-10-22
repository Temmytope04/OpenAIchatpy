// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class NotificationHook : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hookType");
            writer.WriteStringValue(HookType.ToString());
            writer.WritePropertyName("hookName");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ExternalLink))
            {
                writer.WritePropertyName("externalLink");
                writer.WriteStringValue(ExternalLink);
            }
            writer.WriteEndObject();
        }

        internal static NotificationHook DeserializeAlertingHook(JsonElement element)
        {
            if (element.TryGetProperty("hookType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Email": return EmailNotificationHook.DeserializeEmailHook(element);
                    case "Webhook": return WebNotificationHook.DeserializeWebHook(element);
                }
            }
            HookType hookType = default;
            Optional<string> hookId = default;
            string hookName = default;
            Optional<string> description = default;
            Optional<string> externalLink = default;
            Optional<IReadOnlyList<string>> admins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hookType"))
                {
                    hookType = new HookType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hookId"))
                {
                    hookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hookName"))
                {
                    hookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalLink"))
                {
                    externalLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("admins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    admins = array;
                    continue;
                }
            }
            return new NotificationHook(hookType, hookId.Value, hookName, description.Value, externalLink.Value, Optional.ToList(admins));
        }
    }
}
