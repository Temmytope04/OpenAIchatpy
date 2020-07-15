// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class NetworkRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Bypass))
            {
                writer.WritePropertyName("bypass");
                writer.WriteStringValue(Bypass.Value.ToString());
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction");
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
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
            writer.WriteEndObject();
        }

        internal static NetworkRuleSet DeserializeNetworkRuleSet(JsonElement element)
        {
            Optional<NetworkRuleBypassOptions> bypass = default;
            Optional<NetworkRuleAction> defaultAction = default;
            Optional<IList<IPRule>> ipRules = default;
            Optional<IList<VirtualNetworkRule>> virtualNetworkRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bypass"))
                {
                    bypass = new NetworkRuleBypassOptions(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultAction"))
                {
                    defaultAction = new NetworkRuleAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipRules"))
                {
                    List<IPRule> array = new List<IPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPRule.DeserializeIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("virtualNetworkRules"))
                {
                    List<VirtualNetworkRule> array = new List<VirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworkRule.DeserializeVirtualNetworkRule(item));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
            }
            return new NetworkRuleSet(Optional.ToNullable(bypass), Optional.ToNullable(defaultAction), Optional.ToList(ipRules), Optional.ToList(virtualNetworkRules));
        }
    }
}
