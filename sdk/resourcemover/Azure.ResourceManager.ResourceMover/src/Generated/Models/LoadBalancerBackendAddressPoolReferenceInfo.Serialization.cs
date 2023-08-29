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
    public partial class LoadBalancerBackendAddressPoolReferenceInfo : IUtf8JsonSerializable, IModelJsonSerializable<LoadBalancerBackendAddressPoolReferenceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadBalancerBackendAddressPoolReferenceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadBalancerBackendAddressPoolReferenceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LoadBalancerBackendAddressPoolReferenceInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
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

        internal static LoadBalancerBackendAddressPoolReferenceInfo DeserializeLoadBalancerBackendAddressPoolReferenceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            ResourceIdentifier sourceArmResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
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
            return new LoadBalancerBackendAddressPoolReferenceInfo(sourceArmResourceId, name.Value, rawData);
        }

        LoadBalancerBackendAddressPoolReferenceInfo IModelJsonSerializable<LoadBalancerBackendAddressPoolReferenceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LoadBalancerBackendAddressPoolReferenceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerBackendAddressPoolReferenceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadBalancerBackendAddressPoolReferenceInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LoadBalancerBackendAddressPoolReferenceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadBalancerBackendAddressPoolReferenceInfo IModelSerializable<LoadBalancerBackendAddressPoolReferenceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LoadBalancerBackendAddressPoolReferenceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadBalancerBackendAddressPoolReferenceInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LoadBalancerBackendAddressPoolReferenceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LoadBalancerBackendAddressPoolReferenceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadBalancerBackendAddressPoolReferenceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
