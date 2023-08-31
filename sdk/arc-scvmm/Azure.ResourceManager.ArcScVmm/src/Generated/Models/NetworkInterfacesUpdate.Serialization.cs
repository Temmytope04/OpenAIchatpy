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

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class NetworkInterfacesUpdate : IUtf8JsonSerializable, IModelJsonSerializable<NetworkInterfacesUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkInterfacesUpdate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkInterfacesUpdate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(IPv4AddressType))
            {
                writer.WritePropertyName("ipv4AddressType"u8);
                writer.WriteStringValue(IPv4AddressType.Value.ToString());
            }
            if (Optional.IsDefined(IPv6AddressType))
            {
                writer.WritePropertyName("ipv6AddressType"u8);
                writer.WriteStringValue(IPv6AddressType.Value.ToString());
            }
            if (Optional.IsDefined(MacAddressType))
            {
                writer.WritePropertyName("macAddressType"u8);
                writer.WriteStringValue(MacAddressType.Value.ToString());
            }
            if (Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
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

        internal static NetworkInterfacesUpdate DeserializeNetworkInterfacesUpdate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> macAddress = default;
            Optional<string> virtualNetworkId = default;
            Optional<AllocationMethod> ipv4AddressType = default;
            Optional<AllocationMethod> ipv6AddressType = default;
            Optional<AllocationMethod> macAddressType = default;
            Optional<string> nicId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualNetworkId"u8))
                {
                    virtualNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4AddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4AddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv6AddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6AddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("macAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    macAddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkInterfacesUpdate(name.Value, macAddress.Value, virtualNetworkId.Value, Optional.ToNullable(ipv4AddressType), Optional.ToNullable(ipv6AddressType), Optional.ToNullable(macAddressType), nicId.Value, rawData);
        }

        NetworkInterfacesUpdate IModelJsonSerializable<NetworkInterfacesUpdate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfacesUpdate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkInterfacesUpdate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkInterfacesUpdate IModelSerializable<NetworkInterfacesUpdate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkInterfacesUpdate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkInterfacesUpdate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkInterfacesUpdate"/> to convert. </param>
        public static implicit operator RequestContent(NetworkInterfacesUpdate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkInterfacesUpdate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkInterfacesUpdate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkInterfacesUpdate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
