// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmenEncryptionKeyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVault))
            {
                writer.WritePropertyName("keyVault"u8);
                writer.WriteObjectValue(KeyVault);
            }
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationServiceEnvironmenEncryptionKeyReference DeserializeIntegrationServiceEnvironmenEncryptionKeyReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LogicResourceReference> keyVault = default;
            Optional<string> keyName = default;
            Optional<string> keyVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVault = LogicResourceReference.DeserializeLogicResourceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationServiceEnvironmenEncryptionKeyReference(keyVault.Value, keyName.Value, keyVersion.Value);
        }
    }
}
