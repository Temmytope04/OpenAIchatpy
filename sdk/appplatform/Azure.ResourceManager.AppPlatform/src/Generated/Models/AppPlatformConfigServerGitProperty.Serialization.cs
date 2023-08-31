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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigServerGitProperty : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformConfigServerGitProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformConfigServerGitProperty>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformConfigServerGitProperty>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Repositories))
            {
                writer.WritePropertyName("repositories"u8);
                writer.WriteStartArray();
                foreach (var item in Repositories)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ConfigServerGitPatternRepository>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(SearchPaths))
            {
                writer.WritePropertyName("searchPaths"u8);
                writer.WriteStartArray();
                foreach (var item in SearchPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(HostKey))
            {
                writer.WritePropertyName("hostKey"u8);
                writer.WriteStringValue(HostKey);
            }
            if (Optional.IsDefined(HostKeyAlgorithm))
            {
                writer.WritePropertyName("hostKeyAlgorithm"u8);
                writer.WriteStringValue(HostKeyAlgorithm);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteStringValue(PrivateKey);
            }
            if (Optional.IsDefined(IsHostKeyCheckingStrict))
            {
                writer.WritePropertyName("strictHostKeyChecking"u8);
                writer.WriteBooleanValue(IsHostKeyCheckingStrict.Value);
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

        internal static AppPlatformConfigServerGitProperty DeserializeAppPlatformConfigServerGitProperty(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ConfigServerGitPatternRepository>> repositories = default;
            Uri uri = default;
            Optional<string> label = default;
            Optional<IList<string>> searchPaths = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> hostKey = default;
            Optional<string> hostKeyAlgorithm = default;
            Optional<string> privateKey = default;
            Optional<bool> strictHostKeyChecking = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repositories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConfigServerGitPatternRepository> array = new List<ConfigServerGitPatternRepository>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConfigServerGitPatternRepository.DeserializeConfigServerGitPatternRepository(item));
                    }
                    repositories = array;
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    searchPaths = array;
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKey"u8))
                {
                    hostKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKeyAlgorithm"u8))
                {
                    hostKeyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strictHostKeyChecking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictHostKeyChecking = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformConfigServerGitProperty(Optional.ToList(repositories), uri, label.Value, Optional.ToList(searchPaths), username.Value, password.Value, hostKey.Value, hostKeyAlgorithm.Value, privateKey.Value, Optional.ToNullable(strictHostKeyChecking), rawData);
        }

        AppPlatformConfigServerGitProperty IModelJsonSerializable<AppPlatformConfigServerGitProperty>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformConfigServerGitProperty(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformConfigServerGitProperty>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformConfigServerGitProperty IModelSerializable<AppPlatformConfigServerGitProperty>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformConfigServerGitProperty(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppPlatformConfigServerGitProperty"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppPlatformConfigServerGitProperty"/> to convert. </param>
        public static implicit operator RequestContent(AppPlatformConfigServerGitProperty model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppPlatformConfigServerGitProperty"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppPlatformConfigServerGitProperty(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformConfigServerGitProperty(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
