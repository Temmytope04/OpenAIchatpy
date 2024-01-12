// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchSecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecurityType))
            {
                writer.WritePropertyName("securityType"u8);
                writer.WriteStringValue(SecurityType.Value.ToString());
            }
            if (Optional.IsDefined(EncryptionAtHost))
            {
                writer.WritePropertyName("encryptionAtHost"u8);
                writer.WriteBooleanValue(EncryptionAtHost.Value);
            }
            if (Optional.IsDefined(UefiSettings))
            {
                writer.WritePropertyName("uefiSettings"u8);
                writer.WriteObjectValue(UefiSettings);
            }
            writer.WriteEndObject();
        }

        internal static BatchSecurityProfile DeserializeBatchSecurityProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchSecurityType> securityType = default;
            Optional<bool> encryptionAtHost = default;
            Optional<BatchUefiSettings> uefiSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityType = new BatchSecurityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryptionAtHost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("uefiSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uefiSettings = BatchUefiSettings.DeserializeBatchUefiSettings(property.Value);
                    continue;
                }
            }
            return new BatchSecurityProfile(Optional.ToNullable(securityType), Optional.ToNullable(encryptionAtHost), uefiSettings.Value);
        }
    }
}
