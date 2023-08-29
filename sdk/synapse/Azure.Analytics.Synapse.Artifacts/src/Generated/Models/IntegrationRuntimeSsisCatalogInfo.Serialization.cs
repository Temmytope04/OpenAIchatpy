// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(IntegrationRuntimeSsisCatalogInfoConverter))]
    public partial class IntegrationRuntimeSsisCatalogInfo : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationRuntimeSsisCatalogInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationRuntimeSsisCatalogInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationRuntimeSsisCatalogInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogServerEndpoint))
            {
                writer.WritePropertyName("catalogServerEndpoint"u8);
                writer.WriteStringValue(CatalogServerEndpoint);
            }
            if (Optional.IsDefined(CatalogAdminUserName))
            {
                writer.WritePropertyName("catalogAdminUserName"u8);
                writer.WriteStringValue(CatalogAdminUserName);
            }
            if (Optional.IsDefined(CatalogAdminPassword))
            {
                writer.WritePropertyName("catalogAdminPassword"u8);
                writer.WriteObjectValue(CatalogAdminPassword);
            }
            if (Optional.IsDefined(CatalogPricingTier))
            {
                writer.WritePropertyName("catalogPricingTier"u8);
                writer.WriteStringValue(CatalogPricingTier.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeSsisCatalogInfo DeserializeIntegrationRuntimeSsisCatalogInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> catalogServerEndpoint = default;
            Optional<string> catalogAdminUserName = default;
            Optional<SecureString> catalogAdminPassword = default;
            Optional<IntegrationRuntimeSsisCatalogPricingTier> catalogPricingTier = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogServerEndpoint"u8))
                {
                    catalogServerEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminUserName"u8))
                {
                    catalogAdminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminPassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogAdminPassword = SecureString.DeserializeSecureString(property.Value);
                    continue;
                }
                if (property.NameEquals("catalogPricingTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogPricingTier = new IntegrationRuntimeSsisCatalogPricingTier(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisCatalogInfo(catalogServerEndpoint.Value, catalogAdminUserName.Value, catalogAdminPassword.Value, Optional.ToNullable(catalogPricingTier), additionalProperties);
        }

        IntegrationRuntimeSsisCatalogInfo IModelJsonSerializable<IntegrationRuntimeSsisCatalogInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeSsisCatalogInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationRuntimeSsisCatalogInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationRuntimeSsisCatalogInfo IModelSerializable<IntegrationRuntimeSsisCatalogInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationRuntimeSsisCatalogInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IntegrationRuntimeSsisCatalogInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IntegrationRuntimeSsisCatalogInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationRuntimeSsisCatalogInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class IntegrationRuntimeSsisCatalogInfoConverter : JsonConverter<IntegrationRuntimeSsisCatalogInfo>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeSsisCatalogInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override IntegrationRuntimeSsisCatalogInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeSsisCatalogInfo(document.RootElement);
            }
        }
    }
}
