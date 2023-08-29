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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    public partial class SupportTicketCommunicationData : IUtf8JsonSerializable, IModelJsonSerializable<SupportTicketCommunicationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SupportTicketCommunicationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SupportTicketCommunicationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Sender))
            {
                writer.WritePropertyName("sender"u8);
                writer.WriteStringValue(Sender);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            writer.WriteEndObject();
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

        internal static SupportTicketCommunicationData DeserializeSupportTicketCommunicationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SupportTicketCommunicationType> communicationType = default;
            Optional<SupportTicketCommunicationDirection> communicationDirection = default;
            Optional<string> sender = default;
            Optional<string> subject = default;
            Optional<string> body = default;
            Optional<DateTimeOffset> createdDate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("communicationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communicationType = new SupportTicketCommunicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("communicationDirection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communicationDirection = new SupportTicketCommunicationDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sender"u8))
                        {
                            sender = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subject"u8))
                        {
                            subject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("body"u8))
                        {
                            body = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SupportTicketCommunicationData(id, name, type, systemData.Value, Optional.ToNullable(communicationType), Optional.ToNullable(communicationDirection), sender.Value, subject.Value, body.Value, Optional.ToNullable(createdDate), rawData);
        }

        SupportTicketCommunicationData IModelJsonSerializable<SupportTicketCommunicationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportTicketCommunicationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SupportTicketCommunicationData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SupportTicketCommunicationData IModelSerializable<SupportTicketCommunicationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSupportTicketCommunicationData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SupportTicketCommunicationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SupportTicketCommunicationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSupportTicketCommunicationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
