// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ProcessThreadInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href");
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(Process))
            {
                writer.WritePropertyName("process");
                writer.WriteStringValue(Process);
            }
            if (Optional.IsDefined(StartAddress))
            {
                writer.WritePropertyName("start_address");
                writer.WriteStringValue(StartAddress);
            }
            if (Optional.IsDefined(CurrentPriority))
            {
                writer.WritePropertyName("current_priority");
                writer.WriteNumberValue(CurrentPriority.Value);
            }
            if (Optional.IsDefined(PriorityLevel))
            {
                writer.WritePropertyName("priority_level");
                writer.WriteStringValue(PriorityLevel);
            }
            if (Optional.IsDefined(BasePriority))
            {
                writer.WritePropertyName("base_priority");
                writer.WriteNumberValue(BasePriority.Value);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(TotalProcessorTime))
            {
                writer.WritePropertyName("total_processor_time");
                writer.WriteStringValue(TotalProcessorTime);
            }
            if (Optional.IsDefined(UserProcessorTime))
            {
                writer.WritePropertyName("user_processor_time");
                writer.WriteStringValue(UserProcessorTime);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(WaitReason))
            {
                writer.WritePropertyName("wait_reason");
                writer.WriteStringValue(WaitReason);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProcessThreadInfo DeserializeProcessThreadInfo(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> identifier = default;
            Optional<string> href = default;
            Optional<string> process = default;
            Optional<string> startAddress = default;
            Optional<int> currentPriority = default;
            Optional<string> priorityLevel = default;
            Optional<int> basePriority = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> totalProcessorTime = default;
            Optional<string> userProcessorTime = default;
            Optional<string> state = default;
            Optional<string> waitReason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("identifier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            identifier = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("href"))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("process"))
                        {
                            process = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("start_address"))
                        {
                            startAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("current_priority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentPriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("priority_level"))
                        {
                            priorityLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("base_priority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            basePriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("start_time"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("total_processor_time"))
                        {
                            totalProcessorTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_processor_time"))
                        {
                            userProcessorTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("wait_reason"))
                        {
                            waitReason = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProcessThreadInfo(id, name, type, systemData.Value, kind.Value, Optional.ToNullable(identifier), href.Value, process.Value, startAddress.Value, Optional.ToNullable(currentPriority), priorityLevel.Value, Optional.ToNullable(basePriority), Optional.ToNullable(startTime), totalProcessorTime.Value, userProcessorTime.Value, state.Value, waitReason.Value);
        }
    }
}
