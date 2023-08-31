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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class IPAddressGroup : IUtf8JsonSerializable, IModelJsonSerializable<IPAddressGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IPAddressGroup>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IPAddressGroup>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DeliveryRegion))
            {
                writer.WritePropertyName("deliveryRegion"u8);
                writer.WriteStringValue(DeliveryRegion);
            }
            if (Optional.IsCollectionDefined(IPv4Addresses))
            {
                writer.WritePropertyName("ipv4Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Addresses)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<CidrIPAddress>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6Addresses))
            {
                writer.WritePropertyName("ipv6Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Addresses)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<CidrIPAddress>)item).Serialize(writer, options);
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

        internal static IPAddressGroup DeserializeIPAddressGroup(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deliveryRegion = default;
            Optional<IList<CidrIPAddress>> ipv4Addresses = default;
            Optional<IList<CidrIPAddress>> ipv6Addresses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deliveryRegion"u8))
                {
                    deliveryRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CidrIPAddress> array = new List<CidrIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CidrIPAddress.DeserializeCidrIPAddress(item));
                    }
                    ipv4Addresses = array;
                    continue;
                }
                if (property.NameEquals("ipv6Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CidrIPAddress> array = new List<CidrIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CidrIPAddress.DeserializeCidrIPAddress(item));
                    }
                    ipv6Addresses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IPAddressGroup(deliveryRegion.Value, Optional.ToList(ipv4Addresses), Optional.ToList(ipv6Addresses), rawData);
        }

        IPAddressGroup IModelJsonSerializable<IPAddressGroup>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIPAddressGroup(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IPAddressGroup>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IPAddressGroup IModelSerializable<IPAddressGroup>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIPAddressGroup(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IPAddressGroup"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IPAddressGroup"/> to convert. </param>
        public static implicit operator RequestContent(IPAddressGroup model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IPAddressGroup"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IPAddressGroup(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIPAddressGroup(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
