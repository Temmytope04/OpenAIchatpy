// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureIaasVmProtectionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InstantRPDetails))
            {
                writer.WritePropertyName("instantRPDetails");
                writer.WriteObjectValue(InstantRPDetails);
            }
            if (Optional.IsDefined(SchedulePolicy))
            {
                writer.WritePropertyName("schedulePolicy");
                writer.WriteObjectValue(SchedulePolicy);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy");
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsCollectionDefined(TieringPolicy))
            {
                writer.WritePropertyName("tieringPolicy");
                writer.WriteStartObject();
                foreach (var item in TieringPolicy)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(InstantRpRetentionRangeInDays))
            {
                writer.WritePropertyName("instantRpRetentionRangeInDays");
                writer.WriteNumberValue(InstantRpRetentionRangeInDays.Value);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone");
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("policyType");
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount");
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            writer.WritePropertyName("backupManagementType");
            writer.WriteStringValue(BackupManagementType);
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests");
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AzureIaasVmProtectionPolicy DeserializeAzureIaasVmProtectionPolicy(JsonElement element)
        {
            Optional<InstantRPAdditionalDetails> instantRPDetails = default;
            Optional<SchedulePolicy> schedulePolicy = default;
            Optional<RetentionPolicy> retentionPolicy = default;
            Optional<IDictionary<string, TieringPolicy>> tieringPolicy = default;
            Optional<int> instantRpRetentionRangeInDays = default;
            Optional<string> timeZone = default;
            Optional<IaasVmPolicyType> policyType = default;
            Optional<int> protectedItemsCount = default;
            string backupManagementType = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instantRPDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instantRPDetails = InstantRPAdditionalDetails.DeserializeInstantRPAdditionalDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("schedulePolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedulePolicy = SchedulePolicy.DeserializeSchedulePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionPolicy = RetentionPolicy.DeserializeRetentionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("tieringPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, TieringPolicy> dictionary = new Dictionary<string, TieringPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.TieringPolicy.DeserializeTieringPolicy(property0.Value));
                    }
                    tieringPolicy = dictionary;
                    continue;
                }
                if (property.NameEquals("instantRpRetentionRangeInDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instantRpRetentionRangeInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeZone"))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyType = new IaasVmPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
            }
            return new AzureIaasVmProtectionPolicy(Optional.ToNullable(protectedItemsCount), backupManagementType, Optional.ToList(resourceGuardOperationRequests), instantRPDetails.Value, schedulePolicy.Value, retentionPolicy.Value, Optional.ToDictionary(tieringPolicy), Optional.ToNullable(instantRpRetentionRangeInDays), timeZone.Value, Optional.ToNullable(policyType));
        }
    }
}
