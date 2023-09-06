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
    [JsonConverter(typeof(SqlAlwaysEncryptedPropertiesConverter))]
    public partial class SqlAlwaysEncryptedProperties : IUtf8JsonSerializable, IModelJsonSerializable<SqlAlwaysEncryptedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlAlwaysEncryptedProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlAlwaysEncryptedProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlAlwaysEncryptedProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("alwaysEncryptedAkvAuthType"u8);
            writer.WriteStringValue(AlwaysEncryptedAkvAuthType.ToString());
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                if (ServicePrincipalKey is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)ServicePrincipalKey).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                if (Credential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CredentialReference>)Credential).Serialize(writer, options);
                }
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

        internal static SqlAlwaysEncryptedProperties DeserializeSqlAlwaysEncryptedProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType = default;
            Optional<object> servicePrincipalId = default;
            Optional<SecretBase> servicePrincipalKey = default;
            Optional<CredentialReference> credential = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alwaysEncryptedAkvAuthType"u8))
                {
                    alwaysEncryptedAkvAuthType = new SqlAlwaysEncryptedAkvAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("servicePrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalId = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("servicePrincipalKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalKey = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credential = CredentialReference.DeserializeCredentialReference(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlAlwaysEncryptedProperties(alwaysEncryptedAkvAuthType, servicePrincipalId.Value, servicePrincipalKey.Value, credential.Value, rawData);
        }

        SqlAlwaysEncryptedProperties IModelJsonSerializable<SqlAlwaysEncryptedProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlAlwaysEncryptedProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAlwaysEncryptedProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlAlwaysEncryptedProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlAlwaysEncryptedProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlAlwaysEncryptedProperties IModelSerializable<SqlAlwaysEncryptedProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlAlwaysEncryptedProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlAlwaysEncryptedProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlAlwaysEncryptedProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlAlwaysEncryptedProperties"/> to convert. </param>
        public static implicit operator RequestContent(SqlAlwaysEncryptedProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlAlwaysEncryptedProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlAlwaysEncryptedProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlAlwaysEncryptedProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SqlAlwaysEncryptedPropertiesConverter : JsonConverter<SqlAlwaysEncryptedProperties>
        {
            public override void Write(Utf8JsonWriter writer, SqlAlwaysEncryptedProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlAlwaysEncryptedProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlAlwaysEncryptedProperties(document.RootElement);
            }
        }
    }
}
