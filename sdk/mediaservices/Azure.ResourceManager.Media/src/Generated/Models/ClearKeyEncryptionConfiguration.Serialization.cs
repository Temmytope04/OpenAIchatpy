// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class ClearKeyEncryptionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomKeysAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customKeysAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomKeysAcquisitionUriTemplate);
            }
            writer.WriteEndObject();
        }

        internal static ClearKeyEncryptionConfiguration DeserializeClearKeyEncryptionConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> customKeysAcquisitionUriTemplate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customKeysAcquisitionUrlTemplate"u8))
                {
                    customKeysAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
            }
            return new ClearKeyEncryptionConfiguration(customKeysAcquisitionUriTemplate.Value);
        }
    }
}
