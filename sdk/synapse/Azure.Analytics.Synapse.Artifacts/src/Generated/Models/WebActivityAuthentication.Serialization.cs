// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WebActivityAuthenticationConverter))]
    public partial class WebActivityAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Pfx))
            {
                writer.WritePropertyName("pfx"u8);
                writer.WriteObjectValue(Pfx);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("resource"u8);
                writer.WriteStringValue(Resource);
            }
            writer.WriteEndObject();
        }

        internal static WebActivityAuthentication DeserializeWebActivityAuthentication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<SecretBase> pfx = default;
            Optional<string> username = default;
            Optional<SecretBase> password = default;
            Optional<string> resource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pfx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pfx = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    password = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("resource"u8))
                {
                    resource = property.Value.GetString();
                    continue;
                }
            }
            return new WebActivityAuthentication(type, pfx.Value, username.Value, password.Value, resource.Value);
        }

        internal partial class WebActivityAuthenticationConverter : JsonConverter<WebActivityAuthentication>
        {
            public override void Write(Utf8JsonWriter writer, WebActivityAuthentication model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebActivityAuthentication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebActivityAuthentication(document.RootElement);
            }
        }
    }
}
