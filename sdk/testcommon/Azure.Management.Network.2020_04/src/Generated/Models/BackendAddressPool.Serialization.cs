// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BackendAddressPool : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BackendIPConfigurations))
            {
                writer.WritePropertyName("backendIPConfigurations");
                writer.WriteStartArray();
                foreach (var item in BackendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerBackendAddresses))
            {
                writer.WritePropertyName("loadBalancerBackendAddresses");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancingRules))
            {
                writer.WritePropertyName("loadBalancingRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OutboundRule))
            {
                writer.WritePropertyName("outboundRule");
                writer.WriteObjectValue(OutboundRule);
            }
            if (Optional.IsCollectionDefined(OutboundRules))
            {
                writer.WritePropertyName("outboundRules");
                writer.WriteStartArray();
                foreach (var item in OutboundRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BackendAddressPool DeserializeBackendAddressPool(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<IList<NetworkInterfaceIPConfiguration>> backendIPConfigurations = default;
            Optional<IList<LoadBalancerBackendAddress>> loadBalancerBackendAddresses = default;
            Optional<IList<SubResource>> loadBalancingRules = default;
            Optional<SubResource> outboundRule = default;
            Optional<IList<SubResource>> outboundRules = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("backendIPConfigurations"))
                        {
                            List<NetworkInterfaceIPConfiguration> array = new List<NetworkInterfaceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(item));
                            }
                            backendIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddresses"))
                        {
                            List<LoadBalancerBackendAddress> array = new List<LoadBalancerBackendAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LoadBalancerBackendAddress.DeserializeLoadBalancerBackendAddress(item));
                            }
                            loadBalancerBackendAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("outboundRule"))
                        {
                            outboundRule = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outboundRules"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            outboundRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BackendAddressPool(id.Value, name.Value, etag.Value, type.Value, Optional.ToList(backendIPConfigurations), Optional.ToList(loadBalancerBackendAddresses), Optional.ToList(loadBalancingRules), outboundRule.Value, Optional.ToList(outboundRules), Optional.ToNullable(provisioningState));
        }
    }
}
