// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class DatabaseAccountData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IpRules))
            {
                writer.WritePropertyName("ipRules");
                writer.WriteStartArray();
                foreach (var item in IpRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsVirtualNetworkFilterEnabled))
            {
                writer.WritePropertyName("isVirtualNetworkFilterEnabled");
                writer.WriteBooleanValue(IsVirtualNetworkFilterEnabled.Value);
            }
            if (Optional.IsDefined(EnableAutomaticFailover))
            {
                writer.WritePropertyName("enableAutomaticFailover");
                writer.WriteBooleanValue(EnableAutomaticFailover.Value);
            }
            if (Optional.IsDefined(ConsistencyPolicy))
            {
                writer.WritePropertyName("consistencyPolicy");
                writer.WriteObjectValue(ConsistencyPolicy);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities");
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableMultipleWriteLocations))
            {
                writer.WritePropertyName("enableMultipleWriteLocations");
                writer.WriteBooleanValue(EnableMultipleWriteLocations.Value);
            }
            if (Optional.IsDefined(EnableCassandraConnector))
            {
                writer.WritePropertyName("enableCassandraConnector");
                writer.WriteBooleanValue(EnableCassandraConnector.Value);
            }
            if (Optional.IsDefined(ConnectorOffer))
            {
                writer.WritePropertyName("connectorOffer");
                writer.WriteStringValue(ConnectorOffer.Value.ToString());
            }
            if (Optional.IsDefined(DisableKeyBasedMetadataWriteAccess))
            {
                writer.WritePropertyName("disableKeyBasedMetadataWriteAccess");
                writer.WriteBooleanValue(DisableKeyBasedMetadataWriteAccess.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri");
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DefaultIdentity))
            {
                writer.WritePropertyName("defaultIdentity");
                writer.WriteStringValue(DefaultIdentity);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(EnableFreeTier))
            {
                writer.WritePropertyName("enableFreeTier");
                writer.WriteBooleanValue(EnableFreeTier.Value);
            }
            if (Optional.IsDefined(ApiProperties))
            {
                writer.WritePropertyName("apiProperties");
                writer.WriteObjectValue(ApiProperties);
            }
            if (Optional.IsDefined(EnableAnalyticalStorage))
            {
                writer.WritePropertyName("enableAnalyticalStorage");
                writer.WriteBooleanValue(EnableAnalyticalStorage.Value);
            }
            if (Optional.IsDefined(AnalyticalStorageConfiguration))
            {
                writer.WritePropertyName("analyticalStorageConfiguration");
                writer.WriteObjectValue(AnalyticalStorageConfiguration);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters");
                writer.WriteObjectValue(RestoreParameters);
            }
            if (Optional.IsDefined(BackupPolicy))
            {
                writer.WritePropertyName("backupPolicy");
                writer.WriteObjectValue(BackupPolicy);
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WritePropertyName("cors");
                writer.WriteStartArray();
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkAclBypass))
            {
                writer.WritePropertyName("networkAclBypass");
                writer.WriteStringValue(NetworkAclBypass.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(NetworkAclBypassResourceIds))
            {
                writer.WritePropertyName("networkAclBypassResourceIds");
                writer.WriteStartArray();
                foreach (var item in NetworkAclBypassResourceIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity");
                writer.WriteObjectValue(Capacity);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DatabaseAccountData DeserializeDatabaseAccountData(JsonElement element)
        {
            Optional<DatabaseAccountKind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> provisioningState = default;
            Optional<string> documentEndpoint = default;
            Optional<string> databaseAccountOfferType = default;
            Optional<IList<IpAddressOrRange>> ipRules = default;
            Optional<bool> isVirtualNetworkFilterEnabled = default;
            Optional<bool> enableAutomaticFailover = default;
            Optional<ConsistencyPolicy> consistencyPolicy = default;
            Optional<IList<DatabaseAccountCapability>> capabilities = default;
            Optional<IReadOnlyList<DatabaseAccountLocation>> writeLocations = default;
            Optional<IReadOnlyList<DatabaseAccountLocation>> readLocations = default;
            Optional<IReadOnlyList<DatabaseAccountLocation>> locations = default;
            Optional<IReadOnlyList<FailoverPolicy>> failoverPolicies = default;
            Optional<IList<VirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IReadOnlyList<PrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<bool> enableMultipleWriteLocations = default;
            Optional<bool> enableCassandraConnector = default;
            Optional<ConnectorOffer> connectorOffer = default;
            Optional<bool> disableKeyBasedMetadataWriteAccess = default;
            Optional<Uri> keyVaultKeyUri = default;
            Optional<string> defaultIdentity = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<bool> enableFreeTier = default;
            Optional<ApiProperties> apiProperties = default;
            Optional<bool> enableAnalyticalStorage = default;
            Optional<AnalyticalStorageConfiguration> analyticalStorageConfiguration = default;
            Optional<string> instanceId = default;
            Optional<CreateMode> createMode = default;
            Optional<RestoreParameters> restoreParameters = default;
            Optional<BackupPolicy> backupPolicy = default;
            Optional<IList<CorsPolicy>> cors = default;
            Optional<NetworkAclBypass> networkAclBypass = default;
            Optional<IList<string>> networkAclBypassResourceIds = default;
            Optional<bool> disableLocalAuth = default;
            Optional<Capacity> capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new DatabaseAccountKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
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
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentEndpoint"))
                        {
                            documentEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseAccountOfferType"))
                        {
                            databaseAccountOfferType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IpAddressOrRange> array = new List<IpAddressOrRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpAddressOrRange.DeserializeIpAddressOrRange(item));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("isVirtualNetworkFilterEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isVirtualNetworkFilterEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAutomaticFailover"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAutomaticFailover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("consistencyPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            consistencyPolicy = ConsistencyPolicy.DeserializeConsistencyPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("capabilities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseAccountCapability> array = new List<DatabaseAccountCapability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseAccountCapability.DeserializeDatabaseAccountCapability(item));
                            }
                            capabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("writeLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseAccountLocation> array = new List<DatabaseAccountLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseAccountLocation.DeserializeDatabaseAccountLocation(item));
                            }
                            writeLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("readLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseAccountLocation> array = new List<DatabaseAccountLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseAccountLocation.DeserializeDatabaseAccountLocation(item));
                            }
                            readLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("locations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseAccountLocation> array = new List<DatabaseAccountLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseAccountLocation.DeserializeDatabaseAccountLocation(item));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("failoverPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FailoverPolicy> array = new List<FailoverPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FailoverPolicy.DeserializeFailoverPolicy(item));
                            }
                            failoverPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualNetworkRule> array = new List<VirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkRule.DeserializeVirtualNetworkRule(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PrivateEndpointConnectionData> array = new List<PrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("enableMultipleWriteLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableMultipleWriteLocations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableCassandraConnector"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableCassandraConnector = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("connectorOffer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectorOffer = new ConnectorOffer(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableKeyBasedMetadataWriteAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableKeyBasedMetadataWriteAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultKeyUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultKeyUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultIdentity"))
                        {
                            defaultIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableFreeTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableFreeTier = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            apiProperties = ApiProperties.DeserializeApiProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableAnalyticalStorage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAnalyticalStorage = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("analyticalStorageConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            analyticalStorageConfiguration = AnalyticalStorageConfiguration.DeserializeAnalyticalStorageConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("instanceId"))
                        {
                            instanceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createMode = new CreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restoreParameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restoreParameters = RestoreParameters.DeserializeRestoreParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backupPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backupPolicy = BackupPolicy.DeserializeBackupPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CorsPolicy> array = new List<CorsPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CorsPolicy.DeserializeCorsPolicy(item));
                            }
                            cors = array;
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypass"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkAclBypass = property0.Value.GetString().ToNetworkAclBypass();
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypassResourceIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkAclBypassResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capacity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            capacity = Capacity.DeserializeCapacity(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DatabaseAccountData(id, name, type, systemData, tags, location, Optional.ToNullable(kind), identity, provisioningState.Value, documentEndpoint.Value, databaseAccountOfferType.Value, Optional.ToList(ipRules), Optional.ToNullable(isVirtualNetworkFilterEnabled), Optional.ToNullable(enableAutomaticFailover), consistencyPolicy.Value, Optional.ToList(capabilities), Optional.ToList(writeLocations), Optional.ToList(readLocations), Optional.ToList(locations), Optional.ToList(failoverPolicies), Optional.ToList(virtualNetworkRules), Optional.ToList(privateEndpointConnections), Optional.ToNullable(enableMultipleWriteLocations), Optional.ToNullable(enableCassandraConnector), Optional.ToNullable(connectorOffer), Optional.ToNullable(disableKeyBasedMetadataWriteAccess), keyVaultKeyUri.Value, defaultIdentity.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(enableFreeTier), apiProperties.Value, Optional.ToNullable(enableAnalyticalStorage), analyticalStorageConfiguration.Value, instanceId.Value, Optional.ToNullable(createMode), restoreParameters.Value, backupPolicy.Value, Optional.ToList(cors), Optional.ToNullable(networkAclBypass), Optional.ToList(networkAclBypassResourceIds), Optional.ToNullable(disableLocalAuth), capacity.Value);
        }
    }
}
