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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity : IUtf8JsonSerializable, IModelJsonSerializable<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentityResourceId))
            {
                writer.WritePropertyName("userAssignedIdentityResourceId"u8);
                writer.WriteStringValue(UserAssignedIdentityResourceId);
            }
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("identityType"u8);
                writer.WriteStringValue(IdentityType.Value.ToString());
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

        internal static RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> userAssignedIdentityResourceId = default;
            Optional<RedisEnterpriseCustomerManagedKeyIdentityType> identityType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentityResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentityResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityType = new RedisEnterpriseCustomerManagedKeyIdentityType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(userAssignedIdentityResourceId.Value, Optional.ToNullable(identityType), rawData);
        }

        RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity IModelJsonSerializable<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity IModelSerializable<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
