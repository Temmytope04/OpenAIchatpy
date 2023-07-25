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
    [JsonConverter(typeof(MediaLiveEventEncoderDisconnectedEventDataConverter))]
    public partial class MediaLiveEventEncoderDisconnectedEventData
    {
        internal static MediaLiveEventEncoderDisconnectedEventData DeserializeMediaLiveEventEncoderDisconnectedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ingestUrl = default;
            Optional<string> streamId = default;
            Optional<string> encoderIp = default;
            Optional<string> encoderPort = default;
            Optional<string> resultCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"u8))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamId"u8))
                {
                    streamId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderIp"u8))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"u8))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultCode"u8))
                {
                    resultCode = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventEncoderDisconnectedEventData(ingestUrl.Value, streamId.Value, encoderIp.Value, encoderPort.Value, resultCode.Value);
        }

        internal partial class MediaLiveEventEncoderDisconnectedEventDataConverter : JsonConverter<MediaLiveEventEncoderDisconnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventEncoderDisconnectedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaLiveEventEncoderDisconnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventEncoderDisconnectedEventData(document.RootElement);
            }
        }
    }
}
