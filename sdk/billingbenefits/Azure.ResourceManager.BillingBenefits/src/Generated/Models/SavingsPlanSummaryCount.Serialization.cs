// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class SavingsPlanSummaryCount
    {
        internal static SavingsPlanSummaryCount DeserializeSavingsPlanSummaryCount(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> succeededCount = default;
            Optional<float> failedCount = default;
            Optional<float> expiringCount = default;
            Optional<float> expiredCount = default;
            Optional<float> pendingCount = default;
            Optional<float> cancelledCount = default;
            Optional<float> processingCount = default;
            Optional<float> noBenefitCount = default;
            Optional<float> warningCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeededCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    succeededCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("failedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiringCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiringCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiredCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiredCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("pendingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("cancelledCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancelledCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("processingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("noBenefitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noBenefitCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warningCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCount = property.Value.GetSingle();
                    continue;
                }
            }
            return new SavingsPlanSummaryCount(Optional.ToNullable(succeededCount), Optional.ToNullable(failedCount), Optional.ToNullable(expiringCount), Optional.ToNullable(expiredCount), Optional.ToNullable(pendingCount), Optional.ToNullable(cancelledCount), Optional.ToNullable(processingCount), Optional.ToNullable(noBenefitCount), Optional.ToNullable(warningCount));
        }
    }
}
