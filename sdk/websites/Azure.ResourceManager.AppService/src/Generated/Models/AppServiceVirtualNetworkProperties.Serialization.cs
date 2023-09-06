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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceVirtualNetworkProperties : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceVirtualNetworkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceVirtualNetworkProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceVirtualNetworkProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VnetResourceId))
            {
                writer.WritePropertyName("vnetResourceId"u8);
                writer.WriteStringValue(VnetResourceId);
            }
            if (Optional.IsDefined(CertBlob))
            {
                writer.WritePropertyName("certBlob"u8);
                writer.WriteStringValue(CertBlob);
            }
            if (Optional.IsDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStringValue(DnsServers);
            }
            if (Optional.IsDefined(IsSwift))
            {
                writer.WritePropertyName("isSwift"u8);
                writer.WriteBooleanValue(IsSwift.Value);
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

        internal static AppServiceVirtualNetworkProperties DeserializeAppServiceVirtualNetworkProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> vnetResourceId = default;
            Optional<string> certThumbprint = default;
            Optional<string> certBlob = default;
            Optional<IReadOnlyList<AppServiceVirtualNetworkRoute>> routes = default;
            Optional<bool> resyncRequired = default;
            Optional<string> dnsServers = default;
            Optional<bool> isSwift = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certThumbprint"u8))
                {
                    certThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certBlob"u8))
                {
                    certBlob = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceVirtualNetworkRoute> array = new List<AppServiceVirtualNetworkRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceVirtualNetworkRoute.DeserializeAppServiceVirtualNetworkRoute(item));
                    }
                    routes = array;
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    dnsServers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSwift"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSwift = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceVirtualNetworkProperties(vnetResourceId.Value, certThumbprint.Value, certBlob.Value, Optional.ToList(routes), Optional.ToNullable(resyncRequired), dnsServers.Value, Optional.ToNullable(isSwift), rawData);
        }

        AppServiceVirtualNetworkProperties IModelJsonSerializable<AppServiceVirtualNetworkProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceVirtualNetworkProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceVirtualNetworkProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceVirtualNetworkProperties IModelSerializable<AppServiceVirtualNetworkProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceVirtualNetworkProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceVirtualNetworkProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceVirtualNetworkProperties"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceVirtualNetworkProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceVirtualNetworkProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceVirtualNetworkProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceVirtualNetworkProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
