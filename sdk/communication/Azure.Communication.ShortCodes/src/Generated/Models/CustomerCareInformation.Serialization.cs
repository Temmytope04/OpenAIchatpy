// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class CustomerCareInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TollFreeNumber != null)
            {
                writer.WritePropertyName("tollFreeNumber"u8);
                writer.WriteStringValue(TollFreeNumber);
            }
            if (Email != null)
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            writer.WriteEndObject();
        }

        internal static CustomerCareInformation DeserializeCustomerCareInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tollFreeNumber = default;
            string email = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tollFreeNumber"u8))
                {
                    tollFreeNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
            }
            return new CustomerCareInformation(tollFreeNumber, email);
        }
    }
}
