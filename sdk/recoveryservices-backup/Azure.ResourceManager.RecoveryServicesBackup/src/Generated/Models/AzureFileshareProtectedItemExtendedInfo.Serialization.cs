// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureFileshareProtectedItemExtendedInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OldestRecoveryPoint))
            {
                writer.WritePropertyName("oldestRecoveryPoint");
                writer.WriteStringValue(OldestRecoveryPoint.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount");
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            if (Optional.IsDefined(PolicyState))
            {
                writer.WritePropertyName("policyState");
                writer.WriteStringValue(PolicyState);
            }
            writer.WriteEndObject();
        }

        internal static AzureFileshareProtectedItemExtendedInfo DeserializeAzureFileshareProtectedItemExtendedInfo(JsonElement element)
        {
            Optional<DateTimeOffset> oldestRecoveryPoint = default;
            Optional<int> recoveryPointCount = default;
            Optional<string> policyState = default;
            Optional<string> resourceState = default;
            Optional<DateTimeOffset> resourceStateSyncTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldestRecoveryPoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyState"))
                {
                    policyState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceState"))
                {
                    resourceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceStateSyncTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceStateSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AzureFileshareProtectedItemExtendedInfo(Optional.ToNullable(oldestRecoveryPoint), Optional.ToNullable(recoveryPointCount), policyState.Value, resourceState.Value, Optional.ToNullable(resourceStateSyncTime));
        }
    }
}
