// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    public partial class FluxConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope.Value.ToString());
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace");
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(SourceKind))
            {
                writer.WritePropertyName("sourceKind");
                writer.WriteStringValue(SourceKind.Value.ToString());
            }
            if (Optional.IsDefined(Suspend))
            {
                writer.WritePropertyName("suspend");
                writer.WriteBooleanValue(Suspend.Value);
            }
            if (Optional.IsDefined(GitRepository))
            {
                if (GitRepository != null)
                {
                    writer.WritePropertyName("gitRepository");
                    writer.WriteObjectValue(GitRepository);
                }
                else
                {
                    writer.WriteNull("gitRepository");
                }
            }
            if (Optional.IsDefined(Bucket))
            {
                if (Bucket != null)
                {
                    writer.WritePropertyName("bucket");
                    writer.WriteObjectValue(Bucket);
                }
                else
                {
                    writer.WriteNull("bucket");
                }
            }
            if (Optional.IsDefined(AzureBlob))
            {
                if (AzureBlob != null)
                {
                    writer.WritePropertyName("azureBlob");
                    writer.WriteObjectValue(AzureBlob);
                }
                else
                {
                    writer.WriteNull("azureBlob");
                }
            }
            if (Optional.IsCollectionDefined(Kustomizations))
            {
                if (Kustomizations != null)
                {
                    writer.WritePropertyName("kustomizations");
                    writer.WriteStartObject();
                    foreach (var item in Kustomizations)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("kustomizations");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                if (ConfigurationProtectedSettings != null)
                {
                    writer.WritePropertyName("configurationProtectedSettings");
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationProtectedSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationProtectedSettings");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FluxConfigurationData DeserializeFluxConfigurationData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ScopeType> scope = default;
            Optional<string> @namespace = default;
            Optional<SourceKindType> sourceKind = default;
            Optional<bool> suspend = default;
            Optional<GitRepositoryDefinition> gitRepository = default;
            Optional<BucketDefinition> bucket = default;
            Optional<AzureBlobDefinition> azureBlob = default;
            Optional<IDictionary<string, KustomizationDefinition>> kustomizations = default;
            Optional<IDictionary<string, string>> configurationProtectedSettings = default;
            Optional<IReadOnlyList<ObjectStatusDefinition>> statuses = default;
            Optional<string> repositoryPublicKey = default;
            Optional<string> sourceSyncedCommitId = default;
            Optional<DateTimeOffset?> sourceUpdatedAt = default;
            Optional<DateTimeOffset?> statusUpdatedAt = default;
            Optional<FluxComplianceState> complianceState = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> errorMessage = default;
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
                        if (property0.NameEquals("scope"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scope = new ScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("namespace"))
                        {
                            @namespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceKind"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceKind = new SourceKindType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("suspend"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            suspend = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gitRepository"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gitRepository = null;
                                continue;
                            }
                            gitRepository = GitRepositoryDefinition.DeserializeGitRepositoryDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bucket"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                bucket = null;
                                continue;
                            }
                            bucket = BucketDefinition.DeserializeBucketDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureBlob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                azureBlob = null;
                                continue;
                            }
                            azureBlob = AzureBlobDefinition.DeserializeAzureBlobDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kustomizations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kustomizations = null;
                                continue;
                            }
                            Dictionary<string, KustomizationDefinition> dictionary = new Dictionary<string, KustomizationDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, KustomizationDefinition.DeserializeKustomizationDefinition(property1.Value));
                                }
                            }
                            kustomizations = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("configurationProtectedSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                configurationProtectedSettings = null;
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            configurationProtectedSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("statuses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                statuses = null;
                                continue;
                            }
                            List<ObjectStatusDefinition> array = new List<ObjectStatusDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ObjectStatusDefinition.DeserializeObjectStatusDefinition(item));
                                }
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("repositoryPublicKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                repositoryPublicKey = null;
                                continue;
                            }
                            repositoryPublicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceSyncedCommitId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceSyncedCommitId = null;
                                continue;
                            }
                            sourceSyncedCommitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceUpdatedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceUpdatedAt = null;
                                continue;
                            }
                            sourceUpdatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("statusUpdatedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                statusUpdatedAt = null;
                                continue;
                            }
                            statusUpdatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("complianceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            complianceState = new FluxComplianceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                errorMessage = null;
                                continue;
                            }
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FluxConfigurationData(id, name, type, systemData.Value, Optional.ToNullable(scope), @namespace.Value, Optional.ToNullable(sourceKind), Optional.ToNullable(suspend), gitRepository.Value, bucket.Value, azureBlob.Value, Optional.ToDictionary(kustomizations), Optional.ToDictionary(configurationProtectedSettings), Optional.ToList(statuses), repositoryPublicKey.Value, sourceSyncedCommitId.Value, Optional.ToNullable(sourceUpdatedAt), Optional.ToNullable(statusUpdatedAt), Optional.ToNullable(complianceState), Optional.ToNullable(provisioningState), errorMessage.Value);
        }
    }
}
