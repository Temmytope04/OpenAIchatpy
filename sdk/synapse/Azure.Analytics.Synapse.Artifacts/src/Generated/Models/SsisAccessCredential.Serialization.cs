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
    [JsonConverter(typeof(SsisAccessCredentialConverter))]
    public partial class SsisAccessCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domain");
            writer.WriteObjectValue(Domain);
            writer.WritePropertyName("userName");
            writer.WriteObjectValue(UserName);
            writer.WritePropertyName("password");
            writer.WriteObjectValue(Password);
            writer.WriteEndObject();
        }

        internal static SsisAccessCredential DeserializeSsisAccessCredential(JsonElement element)
        {
            object domain = default;
            object userName = default;
            SecretBase password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"))
                {
                    domain = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("userName"))
                {
                    userName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
            }
            return new SsisAccessCredential(domain, userName, password);
        }

        internal partial class SsisAccessCredentialConverter : JsonConverter<SsisAccessCredential>
        {
            public override void Write(Utf8JsonWriter writer, SsisAccessCredential model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SsisAccessCredential Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisAccessCredential(document.RootElement);
            }
        }
    }
}
