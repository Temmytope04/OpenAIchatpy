// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewaySslProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TrustedClientCertificates))
            {
                writer.WritePropertyName("trustedClientCertificates");
                writer.WriteStartArray();
                foreach (var item in TrustedClientCertificates)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SslPolicy))
            {
                writer.WritePropertyName("sslPolicy");
                writer.WriteObjectValue(SslPolicy);
            }
            if (Optional.IsDefined(ClientAuthConfiguration))
            {
                writer.WritePropertyName("clientAuthConfiguration");
                writer.WriteObjectValue(ClientAuthConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewaySslProfile DeserializeApplicationGatewaySslProfile(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<IList<WritableSubResource>> trustedClientCertificates = default;
            Optional<ApplicationGatewaySslPolicy> sslPolicy = default;
            Optional<ApplicationGatewayClientAuthConfiguration> clientAuthConfiguration = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("trustedClientCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            trustedClientCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("sslPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sslPolicy = ApplicationGatewaySslPolicy.DeserializeApplicationGatewaySslPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientAuthConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientAuthConfiguration = ApplicationGatewayClientAuthConfiguration.DeserializeApplicationGatewayClientAuthConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewaySslProfile(id.Value, name.Value, Optional.ToNullable(type), etag.Value, Optional.ToList(trustedClientCertificates), sslPolicy.Value, clientAuthConfiguration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
