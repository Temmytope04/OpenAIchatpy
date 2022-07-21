// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlAlwaysEncryptedProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("alwaysEncryptedAkvAuthType");
            writer.WriteStringValue(AlwaysEncryptedAkvAuthType.ToString());
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServicePrincipalId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ServicePrincipalId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey");
                writer.WriteObjectValue(ServicePrincipalKey);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential");
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
        }

        internal static SqlAlwaysEncryptedProperties DeserializeSqlAlwaysEncryptedProperties(JsonElement element)
        {
            SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType = default;
            Optional<BinaryData> servicePrincipalId = default;
            Optional<SecretBase> servicePrincipalKey = default;
            Optional<CredentialReference> credential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alwaysEncryptedAkvAuthType"))
                {
                    alwaysEncryptedAkvAuthType = new SqlAlwaysEncryptedAkvAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("servicePrincipalId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePrincipalId = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("servicePrincipalKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePrincipalKey = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("credential"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credential = CredentialReference.DeserializeCredentialReference(property.Value);
                    continue;
                }
            }
            return new SqlAlwaysEncryptedProperties(alwaysEncryptedAkvAuthType, servicePrincipalId.Value, servicePrincipalKey.Value, credential.Value);
        }
    }
}
