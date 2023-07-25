// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadCreatedWithUserEventDataConverter))]
    public partial class AcsChatThreadCreatedWithUserEventData
    {
        internal static AcsChatThreadCreatedWithUserEventData DeserializeAcsChatThreadCreatedWithUserEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CommunicationIdentifierModel> createdByCommunicationIdentifier = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            Optional<IReadOnlyList<AcsChatThreadParticipantProperties>> participants = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<CommunicationIdentifierModel> recipientCommunicationIdentifier = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsChatThreadParticipantProperties> array = new List<AcsChatThreadParticipantProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsChatThreadParticipantProperties.DeserializeAcsChatThreadParticipantProperties(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recipientCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadCreatedWithUserEventData(recipientCommunicationIdentifier.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version), createdByCommunicationIdentifier.Value, Optional.ToDictionary(properties), Optional.ToList(participants));
        }

        internal partial class AcsChatThreadCreatedWithUserEventDataConverter : JsonConverter<AcsChatThreadCreatedWithUserEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadCreatedWithUserEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatThreadCreatedWithUserEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadCreatedWithUserEventData(document.RootElement);
            }
        }
    }
}
