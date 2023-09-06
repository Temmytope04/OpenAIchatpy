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
    public partial class RegistrationAddressInfo : IUtf8JsonSerializable, IModelJsonSerializable<RegistrationAddressInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RegistrationAddressInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RegistrationAddressInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RegistrationAddressInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("address1"u8);
            writer.WriteStringValue(Address1);
            if (Optional.IsDefined(Address2))
            {
                writer.WritePropertyName("address2"u8);
                writer.WriteStringValue(Address2);
            }
            writer.WritePropertyName("city"u8);
            writer.WriteStringValue(City);
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("postalCode"u8);
            writer.WriteStringValue(PostalCode);
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State);
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

        internal static RegistrationAddressInfo DeserializeRegistrationAddressInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string address1 = default;
            Optional<string> address2 = default;
            string city = default;
            string country = default;
            string postalCode = default;
            string state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address1"u8))
                {
                    address1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address2"u8))
                {
                    address2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RegistrationAddressInfo(address1, address2.Value, city, country, postalCode, state, rawData);
        }

        RegistrationAddressInfo IModelJsonSerializable<RegistrationAddressInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RegistrationAddressInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRegistrationAddressInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RegistrationAddressInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RegistrationAddressInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RegistrationAddressInfo IModelSerializable<RegistrationAddressInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RegistrationAddressInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRegistrationAddressInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RegistrationAddressInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RegistrationAddressInfo"/> to convert. </param>
        public static implicit operator RequestContent(RegistrationAddressInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RegistrationAddressInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RegistrationAddressInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRegistrationAddressInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
