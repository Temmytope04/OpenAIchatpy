// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadDeletedEventDataConverter))]
    public partial class AcsChatThreadDeletedEventData
    {
        internal static AcsChatThreadDeletedEventData DeserializeAcsChatThreadDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel deletedByCommunicationIdentifier = default;
            DateTimeOffset? deleteTime = default;
            DateTimeOffset? createTime = default;
            long? version = default;
            string transactionId = default;
            string threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deletedByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("deleteTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteTime = property.Value.GetDateTimeOffset("O");
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
            return new AcsChatThreadDeletedEventData(
                transactionId,
                threadId,
                createTime,
                version,
                deletedByCommunicationIdentifier,
                deleteTime);
        }

        internal partial class AcsChatThreadDeletedEventDataConverter : JsonConverter<AcsChatThreadDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatThreadDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadDeletedEventData(document.RootElement);
            }
        }
    }
}
