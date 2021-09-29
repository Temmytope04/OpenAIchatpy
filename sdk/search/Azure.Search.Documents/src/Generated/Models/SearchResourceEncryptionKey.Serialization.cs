// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchResourceEncryptionKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultKeyName");
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVaultKeyVersion");
            writer.WriteStringValue(KeyVersion);
            writer.WritePropertyName("keyVaultUri");
            writer.WriteStringValue(_vaultUri);
            if (Optional.IsDefined(AccessCredentialsInternal))
            {
                writer.WritePropertyName("accessCredentials");
                writer.WriteObjectValue(AccessCredentialsInternal);
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity");
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchResourceEncryptionKey DeserializeSearchResourceEncryptionKey(JsonElement element)
        {
            string keyVaultKeyName = default;
            string keyVaultKeyVersion = default;
            string keyVaultUri = default;
            Optional<AzureActiveDirectoryApplicationCredentials> accessCredentials = default;
            Optional<SearchIndexerDataIdentity> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultKeyName"))
                {
                    keyVaultKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultKeyVersion"))
                {
                    keyVaultKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"))
                {
                    keyVaultUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accessCredentials = AzureActiveDirectoryApplicationCredentials.DeserializeAzureActiveDirectoryApplicationCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
            }
            return new SearchResourceEncryptionKey(keyVaultKeyName, keyVaultKeyVersion, keyVaultUri, accessCredentials.Value, identity.Value);
        }
    }
}
