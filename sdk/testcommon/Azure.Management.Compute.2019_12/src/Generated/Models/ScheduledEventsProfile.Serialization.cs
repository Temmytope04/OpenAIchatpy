// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ScheduledEventsProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TerminateNotificationProfile))
            {
                writer.WritePropertyName("terminateNotificationProfile");
                writer.WriteObjectValue(TerminateNotificationProfile);
            }
            writer.WriteEndObject();
        }

        internal static ScheduledEventsProfile DeserializeScheduledEventsProfile(JsonElement element)
        {
            Optional<TerminateNotificationProfile> terminateNotificationProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("terminateNotificationProfile"))
                {
                    terminateNotificationProfile = TerminateNotificationProfile.DeserializeTerminateNotificationProfile(property.Value);
                    continue;
                }
            }
            return new ScheduledEventsProfile(terminateNotificationProfile.Value);
        }
    }
}
