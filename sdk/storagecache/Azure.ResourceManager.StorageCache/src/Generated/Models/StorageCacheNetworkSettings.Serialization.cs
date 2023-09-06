// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheNetworkSettings : IUtf8JsonSerializable, IModelJsonSerializable<StorageCacheNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageCacheNetworkSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageCacheNetworkSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheNetworkSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Mtu))
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsSearchDomain))
            {
                writer.WritePropertyName("dnsSearchDomain"u8);
                writer.WriteStringValue(DnsSearchDomain);
            }
            if (Optional.IsDefined(NtpServer))
            {
                writer.WritePropertyName("ntpServer"u8);
                writer.WriteStringValue(NtpServer);
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

        internal static StorageCacheNetworkSettings DeserializeStorageCacheNetworkSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> mtu = default;
            Optional<IReadOnlyList<IPAddress>> utilityAddresses = default;
            Optional<IList<IPAddress>> dnsServers = default;
            Optional<string> dnsSearchDomain = default;
            Optional<string> ntpServer = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mtu = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utilityAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    utilityAddresses = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("dnsSearchDomain"u8))
                {
                    dnsSearchDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ntpServer"u8))
                {
                    ntpServer = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageCacheNetworkSettings(Optional.ToNullable(mtu), Optional.ToList(utilityAddresses), Optional.ToList(dnsServers), dnsSearchDomain.Value, ntpServer.Value, rawData);
        }

        StorageCacheNetworkSettings IModelJsonSerializable<StorageCacheNetworkSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheNetworkSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheNetworkSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageCacheNetworkSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheNetworkSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageCacheNetworkSettings IModelSerializable<StorageCacheNetworkSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheNetworkSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageCacheNetworkSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageCacheNetworkSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageCacheNetworkSettings"/> to convert. </param>
        public static implicit operator RequestContent(StorageCacheNetworkSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageCacheNetworkSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageCacheNetworkSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageCacheNetworkSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
