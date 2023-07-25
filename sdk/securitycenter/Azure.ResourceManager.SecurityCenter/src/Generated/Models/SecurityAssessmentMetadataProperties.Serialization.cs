// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentMetadataProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationDescription))
            {
                writer.WritePropertyName("remediationDescription"u8);
                writer.WriteStringValue(RemediationDescription);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("severity"u8);
            writer.WriteStringValue(Severity.ToString());
            if (Optional.IsDefined(UserImpact))
            {
                writer.WritePropertyName("userImpact"u8);
                writer.WriteStringValue(UserImpact.Value.ToString());
            }
            if (Optional.IsDefined(ImplementationEffort))
            {
                writer.WritePropertyName("implementationEffort"u8);
                writer.WriteStringValue(ImplementationEffort.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Threats))
            {
                writer.WritePropertyName("threats"u8);
                writer.WriteStartArray();
                foreach (var item in Threats)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("preview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            writer.WritePropertyName("assessmentType"u8);
            writer.WriteStringValue(AssessmentType.ToString());
            if (Optional.IsDefined(PartnerData))
            {
                writer.WritePropertyName("partnerData"u8);
                writer.WriteObjectValue(PartnerData);
            }
            writer.WriteEndObject();
        }

        internal static SecurityAssessmentMetadataProperties DeserializeSecurityAssessmentMetadataProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            Optional<ResourceIdentifier> policyDefinitionId = default;
            Optional<string> description = default;
            Optional<string> remediationDescription = default;
            Optional<IList<SecurityAssessmentResourceCategory>> categories = default;
            SecurityAssessmentSeverity severity = default;
            Optional<SecurityAssessmentUserImpact> userImpact = default;
            Optional<ImplementationEffort> implementationEffort = default;
            Optional<IList<SecurityThreat>> threats = default;
            Optional<bool> preview = default;
            SecurityAssessmentType assessmentType = default;
            Optional<SecurityAssessmentMetadataPartner> partnerData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediationDescription"u8))
                {
                    remediationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityAssessmentResourceCategory> array = new List<SecurityAssessmentResourceCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityAssessmentResourceCategory(item.GetString()));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = new SecurityAssessmentSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userImpact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userImpact = new SecurityAssessmentUserImpact(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("implementationEffort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    implementationEffort = new ImplementationEffort(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threats"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityThreat> array = new List<SecurityThreat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityThreat(item.GetString()));
                    }
                    threats = array;
                    continue;
                }
                if (property.NameEquals("preview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("assessmentType"u8))
                {
                    assessmentType = new SecurityAssessmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partnerData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerData = SecurityAssessmentMetadataPartner.DeserializeSecurityAssessmentMetadataPartner(property.Value);
                    continue;
                }
            }
            return new SecurityAssessmentMetadataProperties(displayName, policyDefinitionId.Value, description.Value, remediationDescription.Value, Optional.ToList(categories), severity, Optional.ToNullable(userImpact), Optional.ToNullable(implementationEffort), Optional.ToList(threats), Optional.ToNullable(preview), assessmentType, partnerData.Value);
        }
    }
}
