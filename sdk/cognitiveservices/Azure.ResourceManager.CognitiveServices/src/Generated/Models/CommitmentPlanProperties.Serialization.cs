// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentPlanProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CommitmentPlanGuid))
            {
                writer.WritePropertyName("commitmentPlanGuid"u8);
                writer.WriteStringValue(CommitmentPlanGuid.Value);
            }
            if (Optional.IsDefined(HostingModel))
            {
                writer.WritePropertyName("hostingModel"u8);
                writer.WriteStringValue(HostingModel.Value.ToString());
            }
            if (Optional.IsDefined(PlanType))
            {
                writer.WritePropertyName("planType"u8);
                writer.WriteStringValue(PlanType);
            }
            if (Optional.IsDefined(Current))
            {
                writer.WritePropertyName("current"u8);
                writer.WriteObjectValue(Current);
            }
            if (Optional.IsDefined(AutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteBooleanValue(AutoRenew.Value);
            }
            if (Optional.IsDefined(Next))
            {
                writer.WritePropertyName("next"u8);
                writer.WriteObjectValue(Next);
            }
            writer.WriteEndObject();
        }

        internal static CommitmentPlanProperties DeserializeCommitmentPlanProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CommitmentPlanProvisioningState> provisioningState = default;
            Optional<Guid> commitmentPlanGuid = default;
            Optional<ServiceAccountHostingModel> hostingModel = default;
            Optional<string> planType = default;
            Optional<CommitmentPeriod> current = default;
            Optional<bool> autoRenew = default;
            Optional<CommitmentPeriod> next = default;
            Optional<CommitmentPeriod> last = default;
            Optional<IReadOnlyList<string>> provisioningIssues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new CommitmentPlanProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commitmentPlanGuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentPlanGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("hostingModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostingModel = new ServiceAccountHostingModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("planType"u8))
                {
                    planType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("current"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    current = CommitmentPeriod.DeserializeCommitmentPeriod(property.Value);
                    continue;
                }
                if (property.NameEquals("autoRenew"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoRenew = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("next"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    next = CommitmentPeriod.DeserializeCommitmentPeriod(property.Value);
                    continue;
                }
                if (property.NameEquals("last"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    last = CommitmentPeriod.DeserializeCommitmentPeriod(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningIssues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    provisioningIssues = array;
                    continue;
                }
            }
            return new CommitmentPlanProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(commitmentPlanGuid), Optional.ToNullable(hostingModel), planType.Value, current.Value, Optional.ToNullable(autoRenew), next.Value, last.Value, Optional.ToList(provisioningIssues));
        }
    }
}
