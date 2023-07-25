// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicPlanDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UsageType))
            {
                writer.WritePropertyName("usageType"u8);
                writer.WriteStringValue(UsageType.Value.ToString());
            }
            if (Optional.IsDefined(BillingCycle))
            {
                writer.WritePropertyName("billingCycle"u8);
                writer.WriteStringValue(BillingCycle.Value.ToString());
            }
            if (Optional.IsDefined(PlanDetails))
            {
                writer.WritePropertyName("planDetails"u8);
                writer.WriteStringValue(PlanDetails);
            }
            if (Optional.IsDefined(EffectiveOn))
            {
                writer.WritePropertyName("effectiveDate"u8);
                writer.WriteStringValue(EffectiveOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static NewRelicPlanDetails DeserializeNewRelicPlanDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NewRelicObservabilityUsageType> usageType = default;
            Optional<NewRelicObservabilityBillingCycle> billingCycle = default;
            Optional<string> planDetails = default;
            Optional<DateTimeOffset> effectiveDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usageType = new NewRelicObservabilityUsageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingCycle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCycle = new NewRelicObservabilityBillingCycle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("planDetails"u8))
                {
                    planDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new NewRelicPlanDetails(Optional.ToNullable(usageType), Optional.ToNullable(billingCycle), planDetails.Value, Optional.ToNullable(effectiveDate));
        }
    }
}
