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

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class WebPubSubNetworkAcls : IUtf8JsonSerializable, IModelJsonSerializable<WebPubSubNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebPubSubNetworkAcls>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebPubSubNetworkAcls>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetwork))
            {
                writer.WritePropertyName("publicNetwork"u8);
                writer.WriteObjectValue(PublicNetwork);
            }
            if (Optional.IsCollectionDefined(PrivateEndpoints))
            {
                writer.WritePropertyName("privateEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpoints)
                {
                    writer.WriteObjectValue(item);
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

        internal static WebPubSubNetworkAcls DeserializeWebPubSubNetworkAcls(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AclAction> defaultAction = default;
            Optional<PublicNetworkAcls> publicNetwork = default;
            Optional<IList<PrivateEndpointAcl>> privateEndpoints = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new AclAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetwork = PublicNetworkAcls.DeserializePublicNetworkAcls(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateEndpointAcl> array = new List<PrivateEndpointAcl>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointAcl.DeserializePrivateEndpointAcl(item));
                    }
                    privateEndpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebPubSubNetworkAcls(Optional.ToNullable(defaultAction), publicNetwork.Value, Optional.ToList(privateEndpoints), rawData);
        }

        WebPubSubNetworkAcls IModelJsonSerializable<WebPubSubNetworkAcls>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebPubSubNetworkAcls(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebPubSubNetworkAcls>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebPubSubNetworkAcls IModelSerializable<WebPubSubNetworkAcls>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebPubSubNetworkAcls(doc.RootElement, options);
        }

        public static implicit operator RequestContent(WebPubSubNetworkAcls model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator WebPubSubNetworkAcls(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebPubSubNetworkAcls(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
