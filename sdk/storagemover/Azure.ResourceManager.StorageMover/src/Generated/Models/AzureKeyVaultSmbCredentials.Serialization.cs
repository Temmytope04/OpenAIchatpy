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

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class AzureKeyVaultSmbCredentials : IUtf8JsonSerializable, IModelJsonSerializable<AzureKeyVaultSmbCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureKeyVaultSmbCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureKeyVaultSmbCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSmbCredentials>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UsernameUriString))
            {
                writer.WritePropertyName("usernameUri"u8);
                writer.WriteStringValue(UsernameUriString);
            }
            if (Optional.IsDefined(PasswordUriString))
            {
                writer.WritePropertyName("passwordUri"u8);
                writer.WriteStringValue(PasswordUriString);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CredentialType.ToString());
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

        internal static AzureKeyVaultSmbCredentials DeserializeAzureKeyVaultSmbCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> usernameUriString = default;
            Optional<string> passwordUriString = default;
            CredentialType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usernameUri"u8))
                {
                    usernameUriString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("passwordUri"u8))
                {
                    passwordUriString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new CredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureKeyVaultSmbCredentials(type, usernameUriString.Value, passwordUriString.Value, rawData);
        }

        AzureKeyVaultSmbCredentials IModelJsonSerializable<AzureKeyVaultSmbCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSmbCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureKeyVaultSmbCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureKeyVaultSmbCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSmbCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureKeyVaultSmbCredentials IModelSerializable<AzureKeyVaultSmbCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSmbCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureKeyVaultSmbCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureKeyVaultSmbCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureKeyVaultSmbCredentials"/> to convert. </param>
        public static implicit operator RequestContent(AzureKeyVaultSmbCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureKeyVaultSmbCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureKeyVaultSmbCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureKeyVaultSmbCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
