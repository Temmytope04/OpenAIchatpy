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
    [JsonConverter(typeof(MachineLearningServicesModelRegisteredEventDataConverter))]
    public partial class MachineLearningServicesModelRegisteredEventData
    {
        internal static MachineLearningServicesModelRegisteredEventData DeserializeMachineLearningServicesModelRegisteredEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelName = default;
            string modelVersion = default;
            object modelTags = default;
            object modelProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelName"u8))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modelTags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modelProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modelProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new MachineLearningServicesModelRegisteredEventData(modelName, modelVersion, modelTags, modelProperties);
        }

        internal partial class MachineLearningServicesModelRegisteredEventDataConverter : JsonConverter<MachineLearningServicesModelRegisteredEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesModelRegisteredEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MachineLearningServicesModelRegisteredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesModelRegisteredEventData(document.RootElement);
            }
        }
    }
}
