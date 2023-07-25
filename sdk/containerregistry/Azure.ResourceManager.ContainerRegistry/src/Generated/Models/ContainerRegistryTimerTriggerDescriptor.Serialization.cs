// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTimerTriggerDescriptor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TimerTriggerName))
            {
                writer.WritePropertyName("timerTriggerName"u8);
                writer.WriteStringValue(TimerTriggerName);
            }
            if (Optional.IsDefined(ScheduleOccurrence))
            {
                writer.WritePropertyName("scheduleOccurrence"u8);
                writer.WriteStringValue(ScheduleOccurrence);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryTimerTriggerDescriptor DeserializeContainerRegistryTimerTriggerDescriptor(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timerTriggerName = default;
            Optional<string> scheduleOccurrence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timerTriggerName"u8))
                {
                    timerTriggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduleOccurrence"u8))
                {
                    scheduleOccurrence = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryTimerTriggerDescriptor(timerTriggerName.Value, scheduleOccurrence.Value);
        }
    }
}
