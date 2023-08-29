// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeFrontendConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<NodeTypeFrontendConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NodeTypeFrontendConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NodeTypeFrontendConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerBackendAddressPoolId))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPoolId"u8);
                writer.WriteStringValue(LoadBalancerBackendAddressPoolId);
            }
            if (Optional.IsDefined(LoadBalancerInboundNatPoolId))
            {
                writer.WritePropertyName("loadBalancerInboundNatPoolId"u8);
                writer.WriteStringValue(LoadBalancerInboundNatPoolId);
            }
            if (Optional.IsDefined(ApplicationGatewayBackendAddressPoolId))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPoolId"u8);
                writer.WriteStringValue(ApplicationGatewayBackendAddressPoolId);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static NodeTypeFrontendConfiguration DeserializeNodeTypeFrontendConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NodeTypeFrontendConfigurationIPAddressType> ipAddressType = default;
            Optional<ResourceIdentifier> loadBalancerBackendAddressPoolId = default;
            Optional<ResourceIdentifier> loadBalancerInboundNatPoolId = default;
            Optional<ResourceIdentifier> applicationGatewayBackendAddressPoolId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NodeTypeFrontendConfigurationIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerInboundNatPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerInboundNatPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationGatewayBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    applicationGatewayBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NodeTypeFrontendConfiguration(Optional.ToNullable(ipAddressType), loadBalancerBackendAddressPoolId.Value, loadBalancerInboundNatPoolId.Value, applicationGatewayBackendAddressPoolId.Value, rawData);
        }

        NodeTypeFrontendConfiguration IModelJsonSerializable<NodeTypeFrontendConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeFrontendConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NodeTypeFrontendConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NodeTypeFrontendConfiguration IModelSerializable<NodeTypeFrontendConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNodeTypeFrontendConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NodeTypeFrontendConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NodeTypeFrontendConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNodeTypeFrontendConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
