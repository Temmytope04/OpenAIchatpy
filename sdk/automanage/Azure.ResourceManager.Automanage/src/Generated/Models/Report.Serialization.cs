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

namespace Azure.ResourceManager.Automanage.Models
{
    public partial class Report : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime);
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Report DeserializeReport(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> startTime = default;
            Optional<string> endTime = default;
            Optional<string> lastModifiedTime = default;
            Optional<TimeSpan> duration = default;
            Optional<string> type0 = default;
            Optional<string> status = default;
            Optional<string> configurationProfile = default;
            Optional<IReadOnlyList<ReportResource>> resources = default;
            Optional<ResponseError> error = default;
            Optional<string> reportFormatVersion = default;
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
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            endTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            lastModifiedTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("duration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            duration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationProfile"))
                        {
                            configurationProfile = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ReportResource> array = new List<ReportResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ReportResource.DeserializeReportResource(item));
                            }
                            resources = array;
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("reportFormatVersion"))
                        {
                            reportFormatVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Report(id, name, type, systemData.Value, startTime.Value, endTime.Value, lastModifiedTime.Value, Optional.ToNullable(duration), type0.Value, status.Value, configurationProfile.Value, Optional.ToList(resources), error.Value, reportFormatVersion.Value);
        }
    }
}
