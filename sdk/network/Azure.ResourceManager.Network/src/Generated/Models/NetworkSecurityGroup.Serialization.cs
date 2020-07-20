// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkSecurityGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SecurityRules))
            {
                writer.WritePropertyName("securityRules");
                writer.WriteStartArray();
                foreach (var item in SecurityRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkSecurityGroup DeserializeNetworkSecurityGroup(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<SecurityRule>> securityRules = default;
            Optional<IList<SecurityRule>> defaultSecurityRules = default;
            Optional<IList<NetworkInterface>> networkInterfaces = default;
            Optional<IList<Subnet>> subnets = default;
            Optional<IList<FlowLog>> flowLogs = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("securityRules"))
                        {
                            List<SecurityRule> array = new List<SecurityRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityRule.DeserializeSecurityRule(item));
                            }
                            securityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultSecurityRules"))
                        {
                            List<SecurityRule> array = new List<SecurityRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityRule.DeserializeSecurityRule(item));
                            }
                            defaultSecurityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"))
                        {
                            List<NetworkInterface> array = new List<NetworkInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterface.DeserializeNetworkInterface(item));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("subnets"))
                        {
                            List<Subnet> array = new List<Subnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Subnet.DeserializeSubnet(item));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("flowLogs"))
                        {
                            List<FlowLog> array = new List<FlowLog>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FlowLog.DeserializeFlowLog(item));
                            }
                            flowLogs = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            resourceGuid = property0.Value.GetString();
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
            return new NetworkSecurityGroup(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, Optional.ToList(securityRules), Optional.ToList(defaultSecurityRules), Optional.ToList(networkInterfaces), Optional.ToList(subnets), Optional.ToList(flowLogs), resourceGuid.Value, Optional.ToNullable(provisioningState));
        }
    }
}
