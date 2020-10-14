// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class WebhookHookParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint");
            writer.WriteStringValue(Endpoint);
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers");
                writer.WriteStartObject();
                foreach (var item in Headers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(CertificateKey))
            {
                writer.WritePropertyName("certificateKey");
                writer.WriteStringValue(CertificateKey);
            }
            if (Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword");
                writer.WriteStringValue(CertificatePassword);
            }
            writer.WriteEndObject();
        }

        internal static WebhookHookParameter DeserializeWebhookHookParameter(JsonElement element)
        {
            string endpoint = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<IDictionary<string, string>> headers = default;
            Optional<string> certificateKey = default;
            Optional<string> certificatePassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    headers = dictionary;
                    continue;
                }
                if (property.NameEquals("certificateKey"))
                {
                    certificateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
            }
            return new WebhookHookParameter(endpoint, username.Value, password.Value, Optional.ToDictionary(headers), certificateKey.Value, certificatePassword.Value);
        }
    }
}
