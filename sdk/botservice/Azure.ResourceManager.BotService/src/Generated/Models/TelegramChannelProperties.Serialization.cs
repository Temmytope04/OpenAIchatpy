// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class TelegramChannelProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken");
                writer.WriteStringValue(AccessToken);
            }
            if (Optional.IsDefined(IsValidated))
            {
                writer.WritePropertyName("isValidated");
                writer.WriteBooleanValue(IsValidated.Value);
            }
            writer.WritePropertyName("isEnabled");
            writer.WriteBooleanValue(IsEnabled);
            writer.WriteEndObject();
        }

        internal static TelegramChannelProperties DeserializeTelegramChannelProperties(JsonElement element)
        {
            Optional<string> accessToken = default;
            Optional<bool> isValidated = default;
            bool isEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isValidated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isValidated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEnabled"))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new TelegramChannelProperties(accessToken.Value, Optional.ToNullable(isValidated), isEnabled);
        }
    }
}
