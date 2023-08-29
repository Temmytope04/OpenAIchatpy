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

namespace Azure.ResourceManager.Support.Models
{
    public partial class SupportContactProfile : IUtf8JsonSerializable, IModelJsonSerializable<SupportContactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SupportContactProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SupportContactProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("firstName"u8);
            writer.WriteStringValue(FirstName);
            writer.WritePropertyName("lastName"u8);
            writer.WriteStringValue(LastName);
            writer.WritePropertyName("preferredContactMethod"u8);
            writer.WriteStringValue(PreferredContactMethod.ToString());
            writer.WritePropertyName("primaryEmailAddress"u8);
            writer.WriteStringValue(PrimaryEmailAddress);
            if (Optional.IsCollectionDefined(AdditionalEmailAddresses))
            {
                writer.WritePropertyName("additionalEmailAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            writer.WritePropertyName("preferredTimeZone"u8);
            writer.WriteStringValue(PreferredTimeZone);
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("preferredSupportLanguage"u8);
            writer.WriteStringValue(PreferredSupportLanguage);
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

        internal static SupportContactProfile DeserializeSupportContactProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firstName = default;
            string lastName = default;
            PreferredContactMethod preferredContactMethod = default;
            string primaryEmailAddress = default;
            Optional<IList<string>> additionalEmailAddresses = default;
            Optional<string> phoneNumber = default;
            string preferredTimeZone = default;
            string country = default;
            string preferredSupportLanguage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstName"u8))
                {
                    firstName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastName"u8))
                {
                    lastName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredContactMethod"u8))
                {
                    preferredContactMethod = new PreferredContactMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEmailAddress"u8))
                {
                    primaryEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalEmailAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    additionalEmailAddresses = array;
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredTimeZone"u8))
                {
                    preferredTimeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredSupportLanguage"u8))
                {
                    preferredSupportLanguage = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SupportContactProfile(firstName, lastName, preferredContactMethod, primaryEmailAddress, Optional.ToList(additionalEmailAddresses), phoneNumber.Value, preferredTimeZone, country, preferredSupportLanguage, rawData);
        }

        SupportContactProfile IModelJsonSerializable<SupportContactProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportContactProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SupportContactProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SupportContactProfile IModelSerializable<SupportContactProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSupportContactProfile(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SupportContactProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SupportContactProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSupportContactProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
