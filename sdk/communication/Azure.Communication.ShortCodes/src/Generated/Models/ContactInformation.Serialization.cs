// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class ContactInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Phone))
            {
                writer.WritePropertyName("phone");
                writer.WriteStringValue(Phone);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteStringValue(Email);
            }
            writer.WriteEndObject();
        }

        internal static ContactInformation DeserializeContactInformation(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> phone = default;
            Optional<string> email = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
            }
            return new ContactInformation(name.Value, phone.Value, email.Value);
        }
    }
}
