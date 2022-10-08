// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    public partial class PolicyAttestationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("policyAssignmentId");
            writer.WriteStringValue(PolicyAssignmentId);
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId");
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState");
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiresOn");
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner");
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments");
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsCollectionDefined(Evidence))
            {
                writer.WritePropertyName("evidence");
                writer.WriteStartArray();
                foreach (var item in Evidence)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PolicyAttestationData DeserializePolicyAttestationData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier policyAssignmentId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<PolicyComplianceState> complianceState = default;
            Optional<DateTimeOffset> expiresOn = default;
            Optional<string> owner = default;
            Optional<string> comments = default;
            Optional<IList<AttestationEvidence>> evidence = default;
            Optional<string> provisioningState = default;
            Optional<DateTimeOffset> lastComplianceStateChangeAt = default;
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
                        if (property0.NameEquals("policyAssignmentId"))
                        {
                            policyAssignmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionReferenceId"))
                        {
                            policyDefinitionReferenceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("complianceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            complianceState = new PolicyComplianceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expiresOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expiresOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("owner"))
                        {
                            owner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("comments"))
                        {
                            comments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("evidence"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AttestationEvidence> array = new List<AttestationEvidence>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AttestationEvidence.DeserializeAttestationEvidence(item));
                            }
                            evidence = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastComplianceStateChangeAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastComplianceStateChangeAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PolicyAttestationData(id, name, type, systemData.Value, policyAssignmentId, policyDefinitionReferenceId.Value, Optional.ToNullable(complianceState), Optional.ToNullable(expiresOn), owner.Value, comments.Value, Optional.ToList(evidence), provisioningState.Value, Optional.ToNullable(lastComplianceStateChangeAt));
        }
    }
}
