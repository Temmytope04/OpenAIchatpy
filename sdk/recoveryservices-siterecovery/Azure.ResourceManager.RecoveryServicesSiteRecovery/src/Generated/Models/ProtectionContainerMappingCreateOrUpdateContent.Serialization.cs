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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ProtectionContainerMappingCreateOrUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<ProtectionContainerMappingCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProtectionContainerMappingCreateOrUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProtectionContainerMappingCreateOrUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
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

        internal static ProtectionContainerMappingCreateOrUpdateContent DeserializeProtectionContainerMappingCreateOrUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryCreateProtectionContainerMappingProperties> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SiteRecoveryCreateProtectionContainerMappingProperties.DeserializeSiteRecoveryCreateProtectionContainerMappingProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProtectionContainerMappingCreateOrUpdateContent(properties.Value, rawData);
        }

        ProtectionContainerMappingCreateOrUpdateContent IModelJsonSerializable<ProtectionContainerMappingCreateOrUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectionContainerMappingCreateOrUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProtectionContainerMappingCreateOrUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProtectionContainerMappingCreateOrUpdateContent IModelSerializable<ProtectionContainerMappingCreateOrUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProtectionContainerMappingCreateOrUpdateContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ProtectionContainerMappingCreateOrUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ProtectionContainerMappingCreateOrUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProtectionContainerMappingCreateOrUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
