// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class JobMatchingMode : IUtf8JsonSerializable
    {
        internal static JobMatchingMode DeserializeJobMatchingMode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobMatchModeType> modeType = default;
            Optional<object> queueAndMatchMode = default;
            Optional<ScheduleAndSuspendMode> scheduleAndSuspendMode = default;
            Optional<object> suspendMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modeType = new JobMatchModeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queueAndMatchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queueAndMatchMode = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("scheduleAndSuspendMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAndSuspendMode = JobRouter.ScheduleAndSuspendMode.DeserializeScheduleAndSuspendMode(property.Value);
                    continue;
                }
                if (property.NameEquals("suspendMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suspendMode = property.Value.GetObject();
                    continue;
                }
            }
            return new JobMatchingMode(Optional.ToNullable(modeType), queueAndMatchMode.Value, scheduleAndSuspendMode.Value, suspendMode.Value);
        }
    }
}
