// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class GitHubClientSecret : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ByoaSecretAkvUri))
            {
                writer.WritePropertyName("byoaSecretAkvUrl"u8);
                writer.WriteStringValue(ByoaSecretAkvUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ByoaSecretName))
            {
                writer.WritePropertyName("byoaSecretName"u8);
                writer.WriteStringValue(ByoaSecretName);
            }
            writer.WriteEndObject();
        }

        internal static GitHubClientSecret DeserializeGitHubClientSecret(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> byoaSecretAkvUrl = default;
            Optional<string> byoaSecretName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("byoaSecretAkvUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    byoaSecretAkvUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("byoaSecretName"u8))
                {
                    byoaSecretName = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubClientSecret(byoaSecretAkvUrl.Value, byoaSecretName.Value);
        }
    }
}
