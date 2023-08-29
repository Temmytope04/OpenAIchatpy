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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class ContainerIdentityInfo : IUtf8JsonSerializable, IModelJsonSerializable<ContainerIdentityInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerIdentityInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerIdentityInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UniqueName))
            {
                writer.WritePropertyName("uniqueName"u8);
                writer.WriteStringValue(UniqueName);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(ServicePrincipalClientId))
            {
                writer.WritePropertyName("servicePrincipalClientId"u8);
                writer.WriteStringValue(ServicePrincipalClientId);
            }
            if (Optional.IsDefined(Audience))
            {
                writer.WritePropertyName("audience"u8);
                writer.WriteStringValue(Audience);
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

        internal static ContainerIdentityInfo DeserializeContainerIdentityInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> uniqueName = default;
            Optional<Guid> aadTenantId = default;
            Optional<string> servicePrincipalClientId = default;
            Optional<string> audience = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueName"u8))
                {
                    uniqueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("servicePrincipalClientId"u8))
                {
                    servicePrincipalClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audience"u8))
                {
                    audience = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerIdentityInfo(uniqueName.Value, Optional.ToNullable(aadTenantId), servicePrincipalClientId.Value, audience.Value, rawData);
        }

        ContainerIdentityInfo IModelJsonSerializable<ContainerIdentityInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerIdentityInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerIdentityInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerIdentityInfo IModelSerializable<ContainerIdentityInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerIdentityInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerIdentityInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerIdentityInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerIdentityInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
