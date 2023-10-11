// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    public partial class CloudHsmClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope);
            }
            if (Optional.IsDefined(SecurityDomain))
            {
                writer.WritePropertyName("securityDomain"u8);
                writer.WriteObjectValue(SecurityDomain);
            }
            if (Optional.IsCollectionDefined(Hsms))
            {
                writer.WritePropertyName("hsms"u8);
                writer.WriteStartArray();
                foreach (var item in Hsms)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CloudHsmClusterData DeserializeCloudHsmClusterData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CloudHsmClusterSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> autoGeneratedDomainNameLabelScope = default;
            Optional<CloudHsmClusterSecurityDomainProperties> securityDomain = default;
            Optional<IList<CloudHsmProperties>> hsms = default;
            Optional<string> publicNetworkAccess = default;
            Optional<IList<HardwareSecurityModulesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = CloudHsmClusterSku.DeserializeCloudHsmClusterSku(property.Value);
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                        {
                            autoGeneratedDomainNameLabelScope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("securityDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityDomain = CloudHsmClusterSecurityDomainProperties.DeserializeCloudHsmClusterSecurityDomainProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hsms"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CloudHsmProperties> array = new List<CloudHsmProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CloudHsmProperties.DeserializeCloudHsmProperties(item));
                            }
                            hsms = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HardwareSecurityModulesPrivateEndpointConnectionData> array = new List<HardwareSecurityModulesPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HardwareSecurityModulesPrivateEndpointConnectionData.DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CloudHsmClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), autoGeneratedDomainNameLabelScope.Value, securityDomain.Value, Optional.ToList(hsms), publicNetworkAccess.Value, Optional.ToList(privateEndpointConnections), sku.Value);
        }
    }
}
