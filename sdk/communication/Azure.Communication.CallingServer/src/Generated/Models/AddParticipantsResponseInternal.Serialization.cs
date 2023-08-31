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

namespace Azure.Communication.CallingServer
{
    internal partial class AddParticipantsResponseInternal : IUtf8JsonSerializable, IModelJsonSerializable<AddParticipantsResponseInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AddParticipantsResponseInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AddParticipantsResponseInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Participants))
            {
                writer.WritePropertyName("participants"u8);
                writer.WriteStartArray();
                foreach (var item in Participants)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AcsCallParticipantInternal>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
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

        internal static AddParticipantsResponseInternal DeserializeAddParticipantsResponseInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AcsCallParticipantInternal>> participants = default;
            Optional<string> operationContext = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsCallParticipantInternal> array = new List<AcsCallParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsCallParticipantInternal.DeserializeAcsCallParticipantInternal(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AddParticipantsResponseInternal(Optional.ToList(participants), operationContext.Value, rawData);
        }

        AddParticipantsResponseInternal IModelJsonSerializable<AddParticipantsResponseInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAddParticipantsResponseInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AddParticipantsResponseInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AddParticipantsResponseInternal IModelSerializable<AddParticipantsResponseInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAddParticipantsResponseInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AddParticipantsResponseInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AddParticipantsResponseInternal"/> to convert. </param>
        public static implicit operator RequestContent(AddParticipantsResponseInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AddParticipantsResponseInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AddParticipantsResponseInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAddParticipantsResponseInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
