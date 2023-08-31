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

namespace Azure.Communication
{
    internal partial class CommunicationIdentifierModel : IUtf8JsonSerializable, IModelJsonSerializable<CommunicationIdentifierModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommunicationIdentifierModel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommunicationIdentifierModel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(RawId))
            {
                writer.WritePropertyName("rawId"u8);
                writer.WriteStringValue(RawId);
            }
            if (Optional.IsDefined(CommunicationUser))
            {
                writer.WritePropertyName("communicationUser"u8);
                if (CommunicationUser is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationUserIdentifierModel>)CommunicationUser).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                if (PhoneNumber is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PhoneNumberIdentifierModel>)PhoneNumber).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MicrosoftTeamsUser))
            {
                writer.WritePropertyName("microsoftTeamsUser"u8);
                if (MicrosoftTeamsUser is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MicrosoftTeamsUserIdentifierModel>)MicrosoftTeamsUser).Serialize(writer, options);
                }
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

        internal static CommunicationIdentifierModel DeserializeCommunicationIdentifierModel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CommunicationIdentifierModelKind> kind = default;
            Optional<string> rawId = default;
            Optional<CommunicationUserIdentifierModel> communicationUser = default;
            Optional<PhoneNumberIdentifierModel> phoneNumber = default;
            Optional<MicrosoftTeamsUserIdentifierModel> microsoftTeamsUser = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new CommunicationIdentifierModelKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rawId"u8))
                {
                    rawId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communicationUser = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phoneNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftTeamsUser = MicrosoftTeamsUserIdentifierModel.DeserializeMicrosoftTeamsUserIdentifierModel(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommunicationIdentifierModel(Optional.ToNullable(kind), rawId.Value, communicationUser.Value, phoneNumber.Value, microsoftTeamsUser.Value, rawData);
        }

        CommunicationIdentifierModel IModelJsonSerializable<CommunicationIdentifierModel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationIdentifierModel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommunicationIdentifierModel>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommunicationIdentifierModel IModelSerializable<CommunicationIdentifierModel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommunicationIdentifierModel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommunicationIdentifierModel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommunicationIdentifierModel"/> to convert. </param>
        public static implicit operator RequestContent(CommunicationIdentifierModel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommunicationIdentifierModel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommunicationIdentifierModel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommunicationIdentifierModel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
