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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapsePrivateEndpointConnectionProperties : IUtf8JsonSerializable, IModelJsonSerializable<SynapsePrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapsePrivateEndpointConnectionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapsePrivateEndpointConnectionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                if (ConnectionState is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SynapsePrivateLinkServiceConnectionState>)ConnectionState).Serialize(writer, options);
                }
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

        internal static SynapsePrivateEndpointConnectionProperties DeserializeSynapsePrivateEndpointConnectionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SubResource> privateEndpoint = default;
            Optional<SynapsePrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            Optional<string> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = SynapsePrivateLinkServiceConnectionState.DeserializeSynapsePrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapsePrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState.Value, provisioningState.Value, rawData);
        }

        SynapsePrivateEndpointConnectionProperties IModelJsonSerializable<SynapsePrivateEndpointConnectionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapsePrivateEndpointConnectionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapsePrivateEndpointConnectionProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapsePrivateEndpointConnectionProperties IModelSerializable<SynapsePrivateEndpointConnectionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapsePrivateEndpointConnectionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapsePrivateEndpointConnectionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapsePrivateEndpointConnectionProperties"/> to convert. </param>
        public static implicit operator RequestContent(SynapsePrivateEndpointConnectionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapsePrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapsePrivateEndpointConnectionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapsePrivateEndpointConnectionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
