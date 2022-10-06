// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class NewProtectionProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("policyName");
            writer.WriteStringValue(PolicyName);
            if (Optional.IsDefined(RecoveryPointHistory))
            {
                writer.WritePropertyName("recoveryPointHistory");
                writer.WriteNumberValue(RecoveryPointHistory.Value);
            }
            if (Optional.IsDefined(CrashConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("crashConsistentFrequencyInMinutes");
                writer.WriteNumberValue(CrashConsistentFrequencyInMinutes.Value);
            }
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes");
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
            writer.WritePropertyName("multiVmSyncStatus");
            writer.WriteStringValue(MultiVmSyncStatus.ToString());
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static NewProtectionProfile DeserializeNewProtectionProfile(JsonElement element)
        {
            string policyName = default;
            Optional<int> recoveryPointHistory = default;
            Optional<int> crashConsistentFrequencyInMinutes = default;
            Optional<int> appConsistentFrequencyInMinutes = default;
            SetMultiVmSyncStatus multiVmSyncStatus = default;
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyName"))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointHistory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointHistory = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("crashConsistentFrequencyInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    crashConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiVmSyncStatus"))
                {
                    multiVmSyncStatus = new SetMultiVmSyncStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new NewProtectionProfile(resourceType, policyName, Optional.ToNullable(recoveryPointHistory), Optional.ToNullable(crashConsistentFrequencyInMinutes), Optional.ToNullable(appConsistentFrequencyInMinutes), multiVmSyncStatus);
        }
    }
}
