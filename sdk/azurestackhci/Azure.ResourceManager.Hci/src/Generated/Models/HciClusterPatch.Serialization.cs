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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterPatch : IUtf8JsonSerializable, IModelJsonSerializable<HciClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HciClusterPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HciClusterPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CloudManagementEndpoint))
            {
                writer.WritePropertyName("cloudManagementEndpoint"u8);
                writer.WriteStringValue(CloudManagementEndpoint);
            }
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId"u8);
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(DesiredProperties))
            {
                writer.WritePropertyName("desiredProperties"u8);
                if (DesiredProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HciClusterDesiredProperties>)DesiredProperties).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            writer.WritePropertyName("identity"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedServiceIdentityType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ManagedServiceIdentityType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
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

        internal static HciClusterPatch DeserializeHciClusterPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> cloudManagementEndpoint = default;
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<HciClusterDesiredProperties> desiredProperties = default;
            Optional<Guid> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<HciManagedServiceIdentityType> type = default;
            Optional<IDictionary<string, UserAssignedIdentity>> userAssignedIdentities = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cloudManagementEndpoint"u8))
                        {
                            cloudManagementEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("desiredProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            desiredProperties = HciClusterDesiredProperties.DeserializeHciClusterDesiredProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("principalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type = new HciManagedServiceIdentityType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userAssignedIdentities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, UserAssignedIdentity> dictionary = new Dictionary<string, UserAssignedIdentity>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, JsonSerializer.Deserialize<UserAssignedIdentity>(property1.Value.GetRawText()));
                            }
                            userAssignedIdentities = dictionary;
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
            return new HciClusterPatch(Optional.ToDictionary(tags), cloudManagementEndpoint.Value, Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), desiredProperties.Value, Optional.ToNullable(principalId), Optional.ToNullable(tenantId), Optional.ToNullable(type), Optional.ToDictionary(userAssignedIdentities), rawData);
        }

        HciClusterPatch IModelJsonSerializable<HciClusterPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HciClusterPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HciClusterPatch IModelSerializable<HciClusterPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHciClusterPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HciClusterPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HciClusterPatch"/> to convert. </param>
        public static implicit operator RequestContent(HciClusterPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HciClusterPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HciClusterPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHciClusterPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
