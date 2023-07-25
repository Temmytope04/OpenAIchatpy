// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ArmApplicationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                JsonSerializer.Serialize(writer, Plan);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedResourceGroupId))
            {
                writer.WritePropertyName("managedResourceGroupId"u8);
                writer.WriteStringValue(ManagedResourceGroupId);
            }
            if (Optional.IsDefined(ApplicationDefinitionId))
            {
                writer.WritePropertyName("applicationDefinitionId"u8);
                writer.WriteStringValue(ApplicationDefinitionId);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Parameters.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(JitAccessPolicy))
            {
                writer.WritePropertyName("jitAccessPolicy"u8);
                writer.WriteObjectValue(JitAccessPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArmApplicationData DeserializeArmApplicationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmPlan> plan = default;
            string kind = default;
            Optional<ArmApplicationManagedIdentity> identity = default;
            Optional<string> managedBy = default;
            Optional<ArmApplicationSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> managedResourceGroupId = default;
            Optional<ResourceIdentifier> applicationDefinitionId = default;
            Optional<BinaryData> parameters = default;
            Optional<BinaryData> outputs = default;
            Optional<ResourcesProvisioningState> provisioningState = default;
            Optional<ArmApplicationBillingDetails> billingDetails = default;
            Optional<ArmApplicationJitAccessPolicy> jitAccessPolicy = default;
            Optional<Guid> publisherTenantId = default;
            Optional<IReadOnlyList<ArmApplicationAuthorization>> authorizations = default;
            Optional<ArmApplicationManagementMode> managementMode = default;
            Optional<ArmApplicationPackageContact> customerSupport = default;
            Optional<ArmApplicationPackageSupportUris> supportUris = default;
            Optional<IReadOnlyList<ArmApplicationArtifact>> artifacts = default;
            Optional<ArmApplicationDetails> createdBy = default;
            Optional<ArmApplicationDetails> updatedBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = JsonSerializer.Deserialize<ArmPlan>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ArmApplicationManagedIdentity.DeserializeArmApplicationManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ArmApplicationSku.DeserializeArmApplicationSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("managedResourceGroupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parameters = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputs = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourcesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingDetails = ArmApplicationBillingDetails.DeserializeArmApplicationBillingDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("jitAccessPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jitAccessPolicy = ArmApplicationJitAccessPolicy.DeserializeArmApplicationJitAccessPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publisherTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publisherTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationAuthorization> array = new List<ArmApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationAuthorization.DeserializeArmApplicationAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("managementMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementMode = new ArmApplicationManagementMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerSupport"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerSupport = ArmApplicationPackageContact.DeserializeArmApplicationPackageContact(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportUris = ArmApplicationPackageSupportUris.DeserializeArmApplicationPackageSupportUris(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationArtifact> array = new List<ArmApplicationArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationArtifact.DeserializeArmApplicationArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = ArmApplicationDetails.DeserializeArmApplicationDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedBy = ArmApplicationDetails.DeserializeArmApplicationDetails(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArmApplicationData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, managedBy.Value, sku.Value, plan, kind, identity.Value, managedResourceGroupId.Value, applicationDefinitionId.Value, parameters.Value, outputs.Value, Optional.ToNullable(provisioningState), billingDetails.Value, jitAccessPolicy.Value, Optional.ToNullable(publisherTenantId), Optional.ToList(authorizations), Optional.ToNullable(managementMode), customerSupport.Value, supportUris.Value, Optional.ToList(artifacts), createdBy.Value, updatedBy.Value);
        }
    }
}
