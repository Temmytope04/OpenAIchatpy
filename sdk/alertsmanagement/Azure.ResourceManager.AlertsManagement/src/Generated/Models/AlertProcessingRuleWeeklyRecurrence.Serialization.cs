// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleWeeklyRecurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("daysOfWeek"u8);
            writer.WriteStartArray();
            foreach (var item in DaysOfWeek)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("recurrenceType"u8);
            writer.WriteStringValue(RecurrenceType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "T");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "T");
            }
            writer.WriteEndObject();
        }

        internal static AlertProcessingRuleWeeklyRecurrence DeserializeAlertProcessingRuleWeeklyRecurrence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AlertsManagementDayOfWeek> daysOfWeek = default;
            RecurrenceType recurrenceType = default;
            Optional<TimeSpan> startTime = default;
            Optional<TimeSpan> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfWeek"u8))
                {
                    List<AlertsManagementDayOfWeek> array = new List<AlertsManagementDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AlertsManagementDayOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("recurrenceType"u8))
                {
                    recurrenceType = new RecurrenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetTimeSpan("T");
                    continue;
                }
            }
            return new AlertProcessingRuleWeeklyRecurrence(recurrenceType, Optional.ToNullable(startTime), Optional.ToNullable(endTime), daysOfWeek);
        }
    }
}
