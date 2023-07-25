// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal partial class UpdateEncryptionConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultMetaInfo))
            {
                writer.WritePropertyName("keyVaultMetaInfo"u8);
                writer.WriteObjectValue(KeyVaultMetaInfo);
            }
            writer.WriteEndObject();
        }
    }
}
