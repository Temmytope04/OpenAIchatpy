// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeliveryRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static DeliveryRuleCondition DeserializeDeliveryRuleCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("name", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ClientPort": return DeliveryRuleClientPortCondition.DeserializeDeliveryRuleClientPortCondition(element);
                    case "Cookies": return DeliveryRuleCookiesCondition.DeserializeDeliveryRuleCookiesCondition(element);
                    case "HostName": return DeliveryRuleHostNameCondition.DeserializeDeliveryRuleHostNameCondition(element);
                    case "HttpVersion": return DeliveryRuleHttpVersionCondition.DeserializeDeliveryRuleHttpVersionCondition(element);
                    case "IsDevice": return DeliveryRuleIsDeviceCondition.DeserializeDeliveryRuleIsDeviceCondition(element);
                    case "PostArgs": return DeliveryRulePostArgsCondition.DeserializeDeliveryRulePostArgsCondition(element);
                    case "QueryString": return DeliveryRuleQueryStringCondition.DeserializeDeliveryRuleQueryStringCondition(element);
                    case "RemoteAddress": return DeliveryRuleRemoteAddressCondition.DeserializeDeliveryRuleRemoteAddressCondition(element);
                    case "RequestBody": return DeliveryRuleRequestBodyCondition.DeserializeDeliveryRuleRequestBodyCondition(element);
                    case "RequestHeader": return DeliveryRuleRequestHeaderCondition.DeserializeDeliveryRuleRequestHeaderCondition(element);
                    case "RequestMethod": return DeliveryRuleRequestMethodCondition.DeserializeDeliveryRuleRequestMethodCondition(element);
                    case "RequestScheme": return DeliveryRuleRequestSchemeCondition.DeserializeDeliveryRuleRequestSchemeCondition(element);
                    case "RequestUri": return DeliveryRuleRequestUriCondition.DeserializeDeliveryRuleRequestUriCondition(element);
                    case "ServerPort": return DeliveryRuleServerPortCondition.DeserializeDeliveryRuleServerPortCondition(element);
                    case "SocketAddr": return DeliveryRuleSocketAddressCondition.DeserializeDeliveryRuleSocketAddressCondition(element);
                    case "SslProtocol": return DeliveryRuleSslProtocolCondition.DeserializeDeliveryRuleSslProtocolCondition(element);
                    case "UrlFileExtension": return DeliveryRuleUriFileExtensionCondition.DeserializeDeliveryRuleUriFileExtensionCondition(element);
                    case "UrlFileName": return DeliveryRuleUriFileNameCondition.DeserializeDeliveryRuleUriFileNameCondition(element);
                    case "UrlPath": return DeliveryRuleUriPathCondition.DeserializeDeliveryRuleUriPathCondition(element);
                }
            }
            return UnknownDeliveryRuleCondition.DeserializeUnknownDeliveryRuleCondition(element);
        }
    }
}
