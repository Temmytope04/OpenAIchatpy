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
    [JsonConverter(typeof(StorageTaskQueuedEventDataConverter))]
    public partial class StorageTaskQueuedEventData
    {
        internal static StorageTaskQueuedEventData DeserializeStorageTaskQueuedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> queuedDateTime = default;
            Optional<string> taskExecutionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queuedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queuedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskExecutionId"u8))
                {
                    taskExecutionId = property.Value.GetString();
                    continue;
                }
            }
            return new StorageTaskQueuedEventData(Optional.ToNullable(queuedDateTime), taskExecutionId.Value);
        }

        internal partial class StorageTaskQueuedEventDataConverter : JsonConverter<StorageTaskQueuedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageTaskQueuedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageTaskQueuedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageTaskQueuedEventData(document.RootElement);
            }
        }
    }
}
