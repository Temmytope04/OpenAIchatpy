// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.Chat
{
    internal partial class ChatThreadPropertiesInternal : IUtf8JsonSerializable, IModelJsonSerializable<ChatThreadPropertiesInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ChatThreadPropertiesInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ChatThreadPropertiesInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("topic"u8);
            writer.WriteStringValue(Topic);
            writer.WritePropertyName("createdOn"u8);
            writer.WriteStringValue(CreatedOn, "O");
            writer.WritePropertyName("createdByCommunicationIdentifier"u8);
            if (CreatedByCommunicationIdentifier is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<CommunicationIdentifierModel>)CreatedByCommunicationIdentifier).Serialize(writer, options);
            }
            if (Optional.IsDefined(DeletedOn))
            {
                writer.WritePropertyName("deletedOn"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
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

        internal static ChatThreadPropertiesInternal DeserializeChatThreadPropertiesInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string topic = default;
            DateTimeOffset createdOn = default;
            CommunicationIdentifierModel createdByCommunicationIdentifier = default;
            Optional<DateTimeOffset> deletedOn = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"u8))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdByCommunicationIdentifier"u8))
                {
                    createdByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("deletedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ChatThreadPropertiesInternal(id, topic, createdOn, createdByCommunicationIdentifier, Optional.ToNullable(deletedOn), rawData);
        }

        ChatThreadPropertiesInternal IModelJsonSerializable<ChatThreadPropertiesInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChatThreadPropertiesInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ChatThreadPropertiesInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ChatThreadPropertiesInternal IModelSerializable<ChatThreadPropertiesInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeChatThreadPropertiesInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ChatThreadPropertiesInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ChatThreadPropertiesInternal"/> to convert. </param>
        public static implicit operator RequestContent(ChatThreadPropertiesInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ChatThreadPropertiesInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ChatThreadPropertiesInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeChatThreadPropertiesInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
