// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountKeyVaultProperties : IUtf8JsonSerializable, IModelJsonSerializable<StorageAccountKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageAccountKeyVaultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageAccountKeyVaultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyname"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyversion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyvaulturi"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static StorageAccountKeyVaultProperties DeserializeStorageAccountKeyVaultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyname = default;
            Optional<string> keyversion = default;
            Optional<Uri> keyvaulturi = default;
            Optional<string> currentVersionedKeyIdentifier = default;
            Optional<DateTimeOffset> lastKeyRotationTimestamp = default;
            Optional<DateTimeOffset> currentVersionedKeyExpirationTimestamp = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyname"u8))
                {
                    keyname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyversion"u8))
                {
                    keyversion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaulturi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyvaulturi = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyIdentifier"u8))
                {
                    currentVersionedKeyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastKeyRotationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastKeyRotationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyExpirationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentVersionedKeyExpirationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageAccountKeyVaultProperties(keyname.Value, keyversion.Value, keyvaulturi.Value, currentVersionedKeyIdentifier.Value, Optional.ToNullable(lastKeyRotationTimestamp), Optional.ToNullable(currentVersionedKeyExpirationTimestamp), rawData);
        }

        StorageAccountKeyVaultProperties IModelJsonSerializable<StorageAccountKeyVaultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountKeyVaultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageAccountKeyVaultProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageAccountKeyVaultProperties IModelSerializable<StorageAccountKeyVaultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageAccountKeyVaultProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StorageAccountKeyVaultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StorageAccountKeyVaultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageAccountKeyVaultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
