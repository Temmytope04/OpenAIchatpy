// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceVaultAndSecretReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVault))
            {
                writer.WritePropertyName("sourceVault");
                writer.WriteObjectValue(SourceVault);
            }
            if (Optional.IsDefined(SecretUrl))
            {
                writer.WritePropertyName("secretUrl");
                writer.WriteStringValue(SecretUrl);
            }
            writer.WriteEndObject();
        }

        internal static CloudServiceVaultAndSecretReference DeserializeCloudServiceVaultAndSecretReference(JsonElement element)
        {
            Optional<SubResource> sourceVault = default;
            Optional<string> secretUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceVault = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("secretUrl"))
                {
                    secretUrl = property.Value.GetString();
                    continue;
                }
            }
            return new CloudServiceVaultAndSecretReference(sourceVault.Value, secretUrl.Value);
        }
    }
}
