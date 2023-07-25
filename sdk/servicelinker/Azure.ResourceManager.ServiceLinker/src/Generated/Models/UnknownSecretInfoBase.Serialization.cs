// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    internal partial class UnknownSecretInfoBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("secretType"u8);
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownSecretInfoBase DeserializeUnknownSecretInfoBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkerSecretType secretType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretType"u8))
                {
                    secretType = new LinkerSecretType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSecretInfoBase(secretType);
        }
    }
}
