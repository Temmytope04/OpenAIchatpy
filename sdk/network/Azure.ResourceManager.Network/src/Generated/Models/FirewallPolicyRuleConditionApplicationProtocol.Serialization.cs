// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyRuleConditionApplicationProtocol : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ProtocolType != null)
            {
                writer.WritePropertyName("protocolType");
                writer.WriteStringValue(ProtocolType.Value.ToString());
            }
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyRuleConditionApplicationProtocol DeserializeFirewallPolicyRuleConditionApplicationProtocol(JsonElement element)
        {
            FirewallPolicyRuleConditionApplicationProtocolType? protocolType = default;
            int? port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocolType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocolType = new FirewallPolicyRuleConditionApplicationProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new FirewallPolicyRuleConditionApplicationProtocol(protocolType, port);
        }
    }
}
