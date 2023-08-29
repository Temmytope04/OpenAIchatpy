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

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(SystemAssignedServiceIdentityConverter))]
    public partial class SystemAssignedServiceIdentity : IUtf8JsonSerializable, IModelJsonSerializable<SystemAssignedServiceIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SystemAssignedServiceIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SystemAssignedServiceIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SystemAssignedServiceIdentityType.ToString());
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

        internal static SystemAssignedServiceIdentity DeserializeSystemAssignedServiceIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> principalId = default;
            Optional<Guid> tenantId = default;
            SystemAssignedServiceIdentityType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SystemAssignedServiceIdentityType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SystemAssignedServiceIdentity(Optional.ToNullable(principalId), Optional.ToNullable(tenantId), type, rawData);
        }

        SystemAssignedServiceIdentity IModelJsonSerializable<SystemAssignedServiceIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemAssignedServiceIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SystemAssignedServiceIdentity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SystemAssignedServiceIdentity IModelSerializable<SystemAssignedServiceIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSystemAssignedServiceIdentity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SystemAssignedServiceIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SystemAssignedServiceIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSystemAssignedServiceIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SystemAssignedServiceIdentityConverter : JsonConverter<SystemAssignedServiceIdentity>
        {
            public override void Write(Utf8JsonWriter writer, SystemAssignedServiceIdentity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SystemAssignedServiceIdentity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSystemAssignedServiceIdentity(document.RootElement);
            }
        }
    }
}
