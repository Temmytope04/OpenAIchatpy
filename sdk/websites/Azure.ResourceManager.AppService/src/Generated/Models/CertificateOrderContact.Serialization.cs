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
    public partial class CertificateOrderContact : IUtf8JsonSerializable, IModelJsonSerializable<CertificateOrderContact>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CertificateOrderContact>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CertificateOrderContact>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(NameFirst))
            {
                writer.WritePropertyName("nameFirst"u8);
                writer.WriteStringValue(NameFirst);
            }
            if (Optional.IsDefined(NameLast))
            {
                writer.WritePropertyName("nameLast"u8);
                writer.WriteStringValue(NameLast);
            }
            if (Optional.IsDefined(Phone))
            {
                writer.WritePropertyName("phone"u8);
                writer.WriteStringValue(Phone);
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

        internal static CertificateOrderContact DeserializeCertificateOrderContact(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> email = default;
            Optional<string> nameFirst = default;
            Optional<string> nameLast = default;
            Optional<string> phone = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameFirst"u8))
                {
                    nameFirst = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameLast"u8))
                {
                    nameLast = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CertificateOrderContact(email.Value, nameFirst.Value, nameLast.Value, phone.Value, rawData);
        }

        CertificateOrderContact IModelJsonSerializable<CertificateOrderContact>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateOrderContact(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CertificateOrderContact>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CertificateOrderContact IModelSerializable<CertificateOrderContact>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCertificateOrderContact(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CertificateOrderContact model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CertificateOrderContact(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCertificateOrderContact(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
