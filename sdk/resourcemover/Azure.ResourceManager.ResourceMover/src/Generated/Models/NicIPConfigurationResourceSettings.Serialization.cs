// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class NicIPConfigurationResourceSettings : IUtf8JsonSerializable, IJsonModel<NicIPConfigurationResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NicIPConfigurationResourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NicIPConfigurationResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPConfigurationResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NicIPConfigurationResourceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (PrivateIPAddressStringValue != null)
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddressStringValue);
            }
            if (PrivateIPAllocationMethod != null)
            {
                writer.WritePropertyName("privateIpAllocationMethod"u8);
                writer.WriteStringValue(PrivateIPAllocationMethod);
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteObjectValue(Subnet);
            }
            if (IsPrimary.HasValue)
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            if (!(LoadBalancerBackendAddressPools is ChangeTrackingList<LoadBalancerBackendAddressPoolReferenceInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LoadBalancerNatRules is ChangeTrackingList<LoadBalancerNatRuleReferenceInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("loadBalancerNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PublicIP != null)
            {
                writer.WritePropertyName("publicIp"u8);
                writer.WriteObjectValue(PublicIP);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NicIPConfigurationResourceSettings IJsonModel<NicIPConfigurationResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPConfigurationResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NicIPConfigurationResourceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNicIPConfigurationResourceSettings(document.RootElement, options);
        }

        internal static NicIPConfigurationResourceSettings DeserializeNicIPConfigurationResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string privateIPAddress = default;
            string privateIPAllocationMethod = default;
            SubnetReferenceInfo subnet = default;
            bool? primary = default;
            IList<LoadBalancerBackendAddressPoolReferenceInfo> loadBalancerBackendAddressPools = default;
            IList<LoadBalancerNatRuleReferenceInfo> loadBalancerNatRules = default;
            PublicIPReferenceInfo publicIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAllocationMethod"u8))
                {
                    privateIPAllocationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = SubnetReferenceInfo.DeserializeSubnetReferenceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("primary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("loadBalancerBackendAddressPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerBackendAddressPoolReferenceInfo> array = new List<LoadBalancerBackendAddressPoolReferenceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerBackendAddressPoolReferenceInfo.DeserializeLoadBalancerBackendAddressPoolReferenceInfo(item, options));
                    }
                    loadBalancerBackendAddressPools = array;
                    continue;
                }
                if (property.NameEquals("loadBalancerNatRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerNatRuleReferenceInfo> array = new List<LoadBalancerNatRuleReferenceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerNatRuleReferenceInfo.DeserializeLoadBalancerNatRuleReferenceInfo(item, options));
                    }
                    loadBalancerNatRules = array;
                    continue;
                }
                if (property.NameEquals("publicIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIP = PublicIPReferenceInfo.DeserializePublicIPReferenceInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NicIPConfigurationResourceSettings(
                name,
                privateIPAddress,
                privateIPAllocationMethod,
                subnet,
                primary,
                loadBalancerBackendAddressPools ?? new ChangeTrackingList<LoadBalancerBackendAddressPoolReferenceInfo>(),
                loadBalancerNatRules ?? new ChangeTrackingList<LoadBalancerNatRuleReferenceInfo>(),
                publicIP,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NicIPConfigurationResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPConfigurationResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NicIPConfigurationResourceSettings)} does not support '{options.Format}' format.");
            }
        }

        NicIPConfigurationResourceSettings IPersistableModel<NicIPConfigurationResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NicIPConfigurationResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNicIPConfigurationResourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NicIPConfigurationResourceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NicIPConfigurationResourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
