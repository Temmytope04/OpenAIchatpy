// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GitHubClientSecretConverter))]
    public partial class GitHubClientSecret : IUtf8JsonSerializable, IModelJsonSerializable<GitHubClientSecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GitHubClientSecret>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GitHubClientSecret>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ByoaSecretAkvUrl))
            {
                writer.WritePropertyName("byoaSecretAkvUrl"u8);
                writer.WriteStringValue(ByoaSecretAkvUrl);
            }
            if (Optional.IsDefined(ByoaSecretName))
            {
                writer.WritePropertyName("byoaSecretName"u8);
                writer.WriteStringValue(ByoaSecretName);
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

        internal static GitHubClientSecret DeserializeGitHubClientSecret(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> byoaSecretAkvUrl = default;
            Optional<string> byoaSecretName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("byoaSecretAkvUrl"u8))
                {
                    byoaSecretAkvUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("byoaSecretName"u8))
                {
                    byoaSecretName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GitHubClientSecret(byoaSecretAkvUrl.Value, byoaSecretName.Value, rawData);
        }

        GitHubClientSecret IModelJsonSerializable<GitHubClientSecret>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubClientSecret(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GitHubClientSecret>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GitHubClientSecret IModelSerializable<GitHubClientSecret>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGitHubClientSecret(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GitHubClientSecret model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GitHubClientSecret(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGitHubClientSecret(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class GitHubClientSecretConverter : JsonConverter<GitHubClientSecret>
        {
            public override void Write(Utf8JsonWriter writer, GitHubClientSecret model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GitHubClientSecret Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGitHubClientSecret(document.RootElement);
            }
        }
    }
}
