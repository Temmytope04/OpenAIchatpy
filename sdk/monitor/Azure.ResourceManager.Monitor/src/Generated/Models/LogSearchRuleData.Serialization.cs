// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class LogSearchRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(AutoMitigate))
            {
                writer.WritePropertyName("autoMitigate");
                writer.WriteBooleanValue(AutoMitigate.Value);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteStringValue(Enabled.Value.ToString());
            }
            writer.WritePropertyName("source");
            writer.WriteObjectValue(Source);
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule");
                writer.WriteObjectValue(Schedule);
            }
            writer.WritePropertyName("action");
            writer.WriteObjectValue(Action);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LogSearchRuleData DeserializeLogSearchRuleData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<ETag> eTag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> createdWithApiVersion = default;
            Optional<bool> isLegacyLogAnalyticsRule = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<bool> autoMitigate = default;
            Optional<MonitorEnabled> enabled = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Optional<ProvisioningState> provisioningState = default;
            MonitorSource source = default;
            Optional<MonitorSchedule> schedule = default;
            MonitorAction action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("createdWithApiVersion"))
                        {
                            createdWithApiVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isLegacyLogAnalyticsRule"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isLegacyLogAnalyticsRule = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoMitigate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoMitigate = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = new MonitorEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("source"))
                        {
                            source = MonitorSource.DeserializeMonitorSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("schedule"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            schedule = MonitorSchedule.DeserializeMonitorSchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("action"))
                        {
                            action = MonitorAction.DeserializeMonitorAction(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LogSearchRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, createdWithApiVersion.Value, Optional.ToNullable(isLegacyLogAnalyticsRule), description.Value, displayName.Value, Optional.ToNullable(autoMitigate), Optional.ToNullable(enabled), Optional.ToNullable(lastUpdatedTime), Optional.ToNullable(provisioningState), source, schedule.Value, action, kind.Value, Optional.ToNullable(eTag));
        }
    }
}
