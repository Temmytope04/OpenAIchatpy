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
    public partial class CdnOriginPatch : IUtf8JsonSerializable, IModelJsonSerializable<CdnOriginPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CdnOriginPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CdnOriginPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                if (HttpPort != null)
                {
                    writer.WritePropertyName("httpPort"u8);
                    writer.WriteNumberValue(HttpPort.Value);
                }
                else
                {
                    writer.WriteNull("httpPort");
                }
            }
            if (Optional.IsDefined(HttpsPort))
            {
                if (HttpsPort != null)
                {
                    writer.WritePropertyName("httpsPort"u8);
                    writer.WriteNumberValue(HttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("httpsPort");
                }
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority"u8);
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight"u8);
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(PrivateLinkAlias))
            {
                writer.WritePropertyName("privateLinkAlias"u8);
                writer.WriteStringValue(PrivateLinkAlias);
            }
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                if (PrivateLinkResourceId != null)
                {
                    writer.WritePropertyName("privateLinkResourceId"u8);
                    writer.WriteStringValue(PrivateLinkResourceId);
                }
                else
                {
                    writer.WriteNull("privateLinkResourceId");
                }
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                writer.WritePropertyName("privateLinkLocation"u8);
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (Optional.IsDefined(PrivateLinkApprovalMessage))
            {
                writer.WritePropertyName("privateLinkApprovalMessage"u8);
                writer.WriteStringValue(PrivateLinkApprovalMessage);
            }
            writer.WriteEndObject();
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

        internal static CdnOriginPatch DeserializeCdnOriginPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hostName = default;
            Optional<int?> httpPort = default;
            Optional<int?> httpsPort = default;
            Optional<string> originHostHeader = default;
            Optional<int?> priority = default;
            Optional<int?> weight = default;
            Optional<bool> enabled = default;
            Optional<string> privateLinkAlias = default;
            Optional<ResourceIdentifier> privateLinkResourceId = default;
            Optional<string> privateLinkLocation = default;
            Optional<string> privateLinkApprovalMessage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpPort = null;
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpsPort = null;
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkAlias"u8))
                        {
                            privateLinkAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateLinkResourceId = null;
                                continue;
                            }
                            privateLinkResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkLocation"u8))
                        {
                            privateLinkLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkApprovalMessage"u8))
                        {
                            privateLinkApprovalMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CdnOriginPatch(hostName.Value, Optional.ToNullable(httpPort), Optional.ToNullable(httpsPort), originHostHeader.Value, Optional.ToNullable(priority), Optional.ToNullable(weight), Optional.ToNullable(enabled), privateLinkAlias.Value, privateLinkResourceId.Value, privateLinkLocation.Value, privateLinkApprovalMessage.Value, rawData);
        }

        CdnOriginPatch IModelJsonSerializable<CdnOriginPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnOriginPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CdnOriginPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CdnOriginPatch IModelSerializable<CdnOriginPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCdnOriginPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CdnOriginPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CdnOriginPatch"/> to convert. </param>
        public static implicit operator RequestContent(CdnOriginPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CdnOriginPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CdnOriginPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCdnOriginPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
