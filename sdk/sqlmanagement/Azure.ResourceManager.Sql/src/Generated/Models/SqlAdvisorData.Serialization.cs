// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlAdvisorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoExecuteStatus))
            {
                writer.WritePropertyName("autoExecuteStatus"u8);
                writer.WriteStringValue(AutoExecuteStatus.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlAdvisorData DeserializeSqlAdvisorData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SqlAdvisorStatus> advisorStatus = default;
            Optional<AutoExecuteStatus> autoExecuteStatus = default;
            Optional<AutoExecuteStatusInheritedFrom> autoExecuteStatusInheritedFrom = default;
            Optional<string> recommendationsStatus = default;
            Optional<DateTimeOffset> lastChecked = default;
            Optional<IReadOnlyList<RecommendedActionData>> recommendedActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("advisorStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            advisorStatus = property0.Value.GetString().ToSqlAdvisorStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoExecuteStatus = property0.Value.GetString().ToAutoExecuteStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatusInheritedFrom"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoExecuteStatusInheritedFrom = property0.Value.GetString().ToAutoExecuteStatusInheritedFrom();
                            continue;
                        }
                        if (property0.NameEquals("recommendationsStatus"u8))
                        {
                            recommendationsStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastChecked"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastChecked = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recommendedActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendedActionData> array = new List<RecommendedActionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionData.DeserializeRecommendedActionData(item));
                            }
                            recommendedActions = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlAdvisorData(id, name, type, systemData.Value, kind.Value, Optional.ToNullable(location), Optional.ToNullable(advisorStatus), Optional.ToNullable(autoExecuteStatus), Optional.ToNullable(autoExecuteStatusInheritedFrom), recommendationsStatus.Value, Optional.ToNullable(lastChecked), Optional.ToList(recommendedActions));
        }
    }
}
