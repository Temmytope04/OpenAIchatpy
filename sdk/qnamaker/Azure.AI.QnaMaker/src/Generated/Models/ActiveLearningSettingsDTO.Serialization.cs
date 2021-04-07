// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    internal partial class ActiveLearningSettingsDTO : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enable))
            {
                writer.WritePropertyName("enable");
                writer.WriteStringValue(Enable);
            }
            writer.WriteEndObject();
        }

        internal static ActiveLearningSettingsDTO DeserializeActiveLearningSettingsDTO(JsonElement element)
        {
            Optional<string> enable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"))
                {
                    enable = property.Value.GetString();
                    continue;
                }
            }
            return new ActiveLearningSettingsDTO(enable.Value);
        }
    }
}
