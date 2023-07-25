// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Consumption.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption
{
    public partial class ConsumptionBudgetData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (Optional.IsDefined(TimeGrain))
            {
                writer.WritePropertyName("timeGrain"u8);
                writer.WriteStringValue(TimeGrain.Value.ToString());
            }
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                writer.WriteObjectValue(TimePeriod);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications"u8);
                writer.WriteStartObject();
                foreach (var item in Notifications)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConsumptionBudgetData DeserializeConsumptionBudgetData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<BudgetCategory> category = default;
            Optional<decimal> amount = default;
            Optional<BudgetTimeGrainType> timeGrain = default;
            Optional<BudgetTimePeriod> timePeriod = default;
            Optional<ConsumptionBudgetFilter> filter = default;
            Optional<BudgetCurrentSpend> currentSpend = default;
            Optional<IDictionary<string, BudgetAssociatedNotification>> notifications = default;
            Optional<BudgetForecastSpend> forecastSpend = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = new BudgetCategory(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("amount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("timeGrain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGrain = new BudgetTimeGrainType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timePeriod = BudgetTimePeriod.DeserializeBudgetTimePeriod(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filter = ConsumptionBudgetFilter.DeserializeConsumptionBudgetFilter(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("currentSpend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentSpend = BudgetCurrentSpend.DeserializeBudgetCurrentSpend(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BudgetAssociatedNotification> dictionary = new Dictionary<string, BudgetAssociatedNotification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BudgetAssociatedNotification.DeserializeBudgetAssociatedNotification(property1.Value));
                            }
                            notifications = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("forecastSpend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forecastSpend = BudgetForecastSpend.DeserializeBudgetForecastSpend(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionBudgetData(id, name, type, systemData.Value, Optional.ToNullable(category), Optional.ToNullable(amount), Optional.ToNullable(timeGrain), timePeriod.Value, filter.Value, currentSpend.Value, Optional.ToDictionary(notifications), forecastSpend.Value, Optional.ToNullable(eTag));
        }
    }
}
