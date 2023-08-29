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

namespace Azure.ResourceManager.Qumulo.Models
{
    public partial class FileSystemResourceUpdateProperties : IUtf8JsonSerializable, IModelJsonSerializable<FileSystemResourceUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FileSystemResourceUpdateProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FileSystemResourceUpdateProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MarketplaceDetails))
            {
                writer.WritePropertyName("marketplaceDetails"u8);
                writer.WriteObjectValue(MarketplaceDetails);
            }
            if (Optional.IsDefined(UserDetails))
            {
                writer.WritePropertyName("userDetails"u8);
                writer.WriteObjectValue(UserDetails);
            }
            if (Optional.IsDefined(DelegatedSubnetId))
            {
                writer.WritePropertyName("delegatedSubnetId"u8);
                writer.WriteStringValue(DelegatedSubnetId);
            }
            if (Optional.IsDefined(ClusterLoginUri))
            {
                writer.WritePropertyName("clusterLoginUrl"u8);
                writer.WriteStringValue(ClusterLoginUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(PrivateIPs))
            {
                writer.WritePropertyName("privateIPs"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPs)
                {
                    writer.WriteStringValue(item);
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

        internal static FileSystemResourceUpdateProperties DeserializeFileSystemResourceUpdateProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MarketplaceDetails> marketplaceDetails = default;
            Optional<QumuloUserDetails> userDetails = default;
            Optional<ResourceIdentifier> delegatedSubnetId = default;
            Optional<Uri> clusterLoginUrl = default;
            Optional<IList<string>> privateIPs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceDetails = MarketplaceDetails.DeserializeMarketplaceDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("userDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userDetails = QumuloUserDetails.DeserializeQumuloUserDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("delegatedSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delegatedSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterLoginUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterLoginUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateIPs"u8))
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
                    privateIPs = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FileSystemResourceUpdateProperties(marketplaceDetails.Value, userDetails.Value, delegatedSubnetId.Value, clusterLoginUrl.Value, Optional.ToList(privateIPs), rawData);
        }

        FileSystemResourceUpdateProperties IModelJsonSerializable<FileSystemResourceUpdateProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSystemResourceUpdateProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FileSystemResourceUpdateProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FileSystemResourceUpdateProperties IModelSerializable<FileSystemResourceUpdateProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFileSystemResourceUpdateProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(FileSystemResourceUpdateProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator FileSystemResourceUpdateProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFileSystemResourceUpdateProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
