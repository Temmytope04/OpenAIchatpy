// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPointProperties
    {
        internal static RecoveryPointProperties DeserializeRecoveryPointProperties(JsonElement element)
        {
            Optional<DateTimeOffset> recoveryPointTime = default;
            Optional<string> recoveryPointType = default;
            Optional<ProviderSpecificRecoveryPointDetails> providerSpecificDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointType"))
                {
                    recoveryPointType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    providerSpecificDetails = ProviderSpecificRecoveryPointDetails.DeserializeProviderSpecificRecoveryPointDetails(property.Value);
                    continue;
                }
            }
            return new RecoveryPointProperties(Optional.ToNullable(recoveryPointTime), recoveryPointType.Value, providerSpecificDetails.Value);
        }
    }
}
