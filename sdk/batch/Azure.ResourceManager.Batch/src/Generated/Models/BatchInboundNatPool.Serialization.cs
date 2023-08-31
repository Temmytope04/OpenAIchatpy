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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchInboundNatPool : IUtf8JsonSerializable, IModelJsonSerializable<BatchInboundNatPool>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchInboundNatPool>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchInboundNatPool>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToSerialString());
            writer.WritePropertyName("backendPort"u8);
            writer.WriteNumberValue(BackendPort);
            writer.WritePropertyName("frontendPortRangeStart"u8);
            writer.WriteNumberValue(FrontendPortRangeStart);
            writer.WritePropertyName("frontendPortRangeEnd"u8);
            writer.WriteNumberValue(FrontendPortRangeEnd);
            if (Optional.IsCollectionDefined(NetworkSecurityGroupRules))
            {
                writer.WritePropertyName("networkSecurityGroupRules"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityGroupRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchNetworkSecurityGroupRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static BatchInboundNatPool DeserializeBatchInboundNatPool(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            BatchInboundEndpointProtocol protocol = default;
            int backendPort = default;
            int frontendPortRangeStart = default;
            int frontendPortRangeEnd = default;
            Optional<IList<BatchNetworkSecurityGroupRule>> networkSecurityGroupRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = property.Value.GetString().ToBatchInboundEndpointProtocol();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    backendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frontendPortRangeStart"u8))
                {
                    frontendPortRangeStart = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frontendPortRangeEnd"u8))
                {
                    frontendPortRangeEnd = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchNetworkSecurityGroupRule> array = new List<BatchNetworkSecurityGroupRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchNetworkSecurityGroupRule.DeserializeBatchNetworkSecurityGroupRule(item));
                    }
                    networkSecurityGroupRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchInboundNatPool(name, protocol, backendPort, frontendPortRangeStart, frontendPortRangeEnd, Optional.ToList(networkSecurityGroupRules), rawData);
        }

        BatchInboundNatPool IModelJsonSerializable<BatchInboundNatPool>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchInboundNatPool(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchInboundNatPool>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchInboundNatPool IModelSerializable<BatchInboundNatPool>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchInboundNatPool(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchInboundNatPool"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchInboundNatPool"/> to convert. </param>
        public static implicit operator RequestContent(BatchInboundNatPool model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchInboundNatPool"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchInboundNatPool(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchInboundNatPool(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
