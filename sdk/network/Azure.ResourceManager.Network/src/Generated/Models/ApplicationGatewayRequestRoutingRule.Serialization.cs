// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRequestRoutingRule : IUtf8JsonSerializable
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
            if (Optional.IsDefined(RuleType))
            {
                writer.WritePropertyName("ruleType");
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool");
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings");
                writer.WriteObjectValue(BackendHttpSettings);
            }
            if (Optional.IsDefined(HttpListener))
            {
                writer.WritePropertyName("httpListener");
                writer.WriteObjectValue(HttpListener);
            }
            if (Optional.IsDefined(UrlPathMap))
            {
                writer.WritePropertyName("urlPathMap");
                writer.WriteObjectValue(UrlPathMap);
            }
            if (Optional.IsDefined(RewriteRuleSet))
            {
                writer.WritePropertyName("rewriteRuleSet");
                writer.WriteObjectValue(RewriteRuleSet);
            }
            if (Optional.IsDefined(RedirectConfiguration))
            {
                writer.WritePropertyName("redirectConfiguration");
                writer.WriteObjectValue(RedirectConfiguration);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayRequestRoutingRule DeserializeApplicationGatewayRequestRoutingRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<ApplicationGatewayRequestRoutingRuleType> ruleType = default;
            Optional<int> priority = default;
            Optional<SubResource> backendAddressPool = default;
            Optional<SubResource> backendHttpSettings = default;
            Optional<SubResource> httpListener = default;
            Optional<SubResource> urlPathMap = default;
            Optional<SubResource> rewriteRuleSet = default;
            Optional<SubResource> redirectConfiguration = default;
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
                        if (property0.NameEquals("ruleType"))
                        {
                            ruleType = new ApplicationGatewayRequestRoutingRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"))
                        {
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPool"))
                        {
                            backendAddressPool = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backendHttpSettings"))
                        {
                            backendHttpSettings = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpListener"))
                        {
                            httpListener = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("urlPathMap"))
                        {
                            urlPathMap = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rewriteRuleSet"))
                        {
                            rewriteRuleSet = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("redirectConfiguration"))
                        {
                            redirectConfiguration = DeserializeSubResource(property0.Value);
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
            return new ApplicationGatewayRequestRoutingRule(id.Value, name.Value, etag.Value, type.Value, Optional.ToNullable(ruleType), Optional.ToNullable(priority), backendAddressPool.Value, backendHttpSettings.Value, httpListener.Value, urlPathMap.Value, rewriteRuleSet.Value, redirectConfiguration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
