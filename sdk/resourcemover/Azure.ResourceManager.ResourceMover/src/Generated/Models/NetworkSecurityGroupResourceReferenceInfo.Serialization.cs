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

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class NetworkSecurityGroupResourceReferenceInfo : IUtf8JsonSerializable, IModelJsonSerializable<NetworkSecurityGroupResourceReferenceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkSecurityGroupResourceReferenceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkSecurityGroupResourceReferenceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkSecurityGroupResourceReferenceInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceArmResourceId"u8);
            writer.WriteStringValue(SourceArmResourceId);
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

        internal static NetworkSecurityGroupResourceReferenceInfo DeserializeNetworkSecurityGroupResourceReferenceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sourceArmResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceArmResourceId"u8))
                {
                    sourceArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkSecurityGroupResourceReferenceInfo(sourceArmResourceId, rawData);
        }

        NetworkSecurityGroupResourceReferenceInfo IModelJsonSerializable<NetworkSecurityGroupResourceReferenceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkSecurityGroupResourceReferenceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityGroupResourceReferenceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkSecurityGroupResourceReferenceInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkSecurityGroupResourceReferenceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkSecurityGroupResourceReferenceInfo IModelSerializable<NetworkSecurityGroupResourceReferenceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkSecurityGroupResourceReferenceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkSecurityGroupResourceReferenceInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkSecurityGroupResourceReferenceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkSecurityGroupResourceReferenceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkSecurityGroupResourceReferenceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
