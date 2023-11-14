// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class InternalNetworkBgpConfiguration : IUtf8JsonSerializable, IJsonModel<InternalNetworkBgpConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalNetworkBgpConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<InternalNetworkBgpConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<InternalNetworkBgpConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<InternalNetworkBgpConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration);
            }
            if (Optional.IsDefined(DefaultRouteOriginate))
            {
                writer.WritePropertyName("defaultRouteOriginate"u8);
                writer.WriteStringValue(DefaultRouteOriginate.Value.ToString());
            }
            if (Optional.IsDefined(AllowAS))
            {
                writer.WritePropertyName("allowAS"u8);
                writer.WriteNumberValue(AllowAS.Value);
            }
            if (Optional.IsDefined(AllowASOverride))
            {
                writer.WritePropertyName("allowASOverride"u8);
                writer.WriteStringValue(AllowASOverride.Value.ToString());
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FabricAsn))
                {
                    writer.WritePropertyName("fabricASN"u8);
                    writer.WriteNumberValue(FabricAsn.Value);
                }
            }
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsCollectionDefined(IPv4ListenRangePrefixes))
            {
                writer.WritePropertyName("ipv4ListenRangePrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4ListenRangePrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6ListenRangePrefixes))
            {
                writer.WritePropertyName("ipv6ListenRangePrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6ListenRangePrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv4NeighborAddress))
            {
                writer.WritePropertyName("ipv4NeighborAddress"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4NeighborAddress)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6NeighborAddress))
            {
                writer.WritePropertyName("ipv6NeighborAddress"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6NeighborAddress)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        InternalNetworkBgpConfiguration IJsonModel<InternalNetworkBgpConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InternalNetworkBgpConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalNetworkBgpConfiguration(document.RootElement, options);
        }

        internal static InternalNetworkBgpConfiguration DeserializeInternalNetworkBgpConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BfdConfiguration> bfdConfiguration = default;
            Optional<NetworkFabricBooleanValue> defaultRouteOriginate = default;
            Optional<int> allowAS = default;
            Optional<AllowASOverride> allowASOverride = default;
            Optional<long> fabricAsn = default;
            Optional<long> peerAsn = default;
            Optional<IList<string>> ipv4ListenRangePrefixes = default;
            Optional<IList<string>> ipv6ListenRangePrefixes = default;
            Optional<IList<NeighborAddress>> ipv4NeighborAddress = default;
            Optional<IList<NeighborAddress>> ipv6NeighborAddress = default;
            Optional<string> annotation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultRouteOriginate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultRouteOriginate = new NetworkFabricBooleanValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowAS = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowASOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowASOverride = new AllowASOverride(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ipv4ListenRangePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv4ListenRangePrefixes = array;
                    continue;
                }
                if (property.NameEquals("ipv6ListenRangePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv6ListenRangePrefixes = array;
                    continue;
                }
                if (property.NameEquals("ipv4NeighborAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NeighborAddress> array = new List<NeighborAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NeighborAddress.DeserializeNeighborAddress(item));
                    }
                    ipv4NeighborAddress = array;
                    continue;
                }
                if (property.NameEquals("ipv6NeighborAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NeighborAddress> array = new List<NeighborAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NeighborAddress.DeserializeNeighborAddress(item));
                    }
                    ipv6NeighborAddress = array;
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    annotation = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InternalNetworkBgpConfiguration(annotation.Value, serializedAdditionalRawData, bfdConfiguration.Value, Optional.ToNullable(defaultRouteOriginate), Optional.ToNullable(allowAS), Optional.ToNullable(allowASOverride), Optional.ToNullable(fabricAsn), Optional.ToNullable(peerAsn), Optional.ToList(ipv4ListenRangePrefixes), Optional.ToList(ipv6ListenRangePrefixes), Optional.ToList(ipv4NeighborAddress), Optional.ToList(ipv6NeighborAddress));
        }

        BinaryData IPersistableModel<InternalNetworkBgpConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InternalNetworkBgpConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InternalNetworkBgpConfiguration IPersistableModel<InternalNetworkBgpConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InternalNetworkBgpConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInternalNetworkBgpConfiguration(document.RootElement, options);
        }

        string IPersistableModel<InternalNetworkBgpConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
