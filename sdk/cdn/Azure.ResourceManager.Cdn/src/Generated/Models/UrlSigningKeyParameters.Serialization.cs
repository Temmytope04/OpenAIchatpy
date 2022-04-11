// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class UrlSigningKeyParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyId");
            writer.WriteStringValue(KeyId);
            writer.WritePropertyName("secretSource");
            JsonSerializer.Serialize(writer, SecretSource); if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion");
                writer.WriteStringValue(SecretVersion);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static UrlSigningKeyParameters DeserializeUrlSigningKeyParameters(JsonElement element)
        {
            string keyId = default;
            WritableSubResource secretSource = default;
            Optional<string> secretVersion = default;
            SecretType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyId"))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretSource"))
                {
                    secretSource = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("secretVersion"))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SecretType(property.Value.GetString());
                    continue;
                }
            }
            return new UrlSigningKeyParameters(type, keyId, secretSource, secretVersion.Value);
        }
    }
}
