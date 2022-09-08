// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertSummary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total");
                writer.WriteNumberValue(Total.Value);
            }
            if (Optional.IsDefined(SmartGroupsCount))
            {
                writer.WritePropertyName("smartGroupsCount");
                writer.WriteNumberValue(SmartGroupsCount.Value);
            }
            if (Optional.IsDefined(GroupedBy))
            {
                writer.WritePropertyName("groupedby");
                writer.WriteStringValue(GroupedBy);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values");
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceAlertSummary DeserializeServiceAlertSummary(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<long> total = default;
            Optional<long> smartGroupsCount = default;
            Optional<string> groupedby = default;
            Optional<IList<ServiceAlertSummaryGroupItemInfo>> values = default;
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
                        if (property0.NameEquals("total"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            total = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("smartGroupsCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            smartGroupsCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("groupedby"))
                        {
                            groupedby = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("values"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServiceAlertSummaryGroupItemInfo> array = new List<ServiceAlertSummaryGroupItemInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceAlertSummaryGroupItemInfo.DeserializeServiceAlertSummaryGroupItemInfo(item));
                            }
                            values = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceAlertSummary(id, name, type, systemData.Value, Optional.ToNullable(total), Optional.ToNullable(smartGroupsCount), groupedby.Value, Optional.ToList(values));
        }
    }
}
