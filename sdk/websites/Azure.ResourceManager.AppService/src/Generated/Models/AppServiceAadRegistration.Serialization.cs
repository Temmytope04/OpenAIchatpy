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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAadRegistration : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceAadRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceAadRegistration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceAadRegistration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceAadRegistration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OpenIdIssuer))
            {
                writer.WritePropertyName("openIdIssuer"u8);
                writer.WriteStringValue(OpenIdIssuer);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
            }
            if (Optional.IsDefined(ClientSecretCertificateThumbprintString))
            {
                writer.WritePropertyName("clientSecretCertificateThumbprint"u8);
                writer.WriteStringValue(ClientSecretCertificateThumbprintString);
            }
            if (Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
            {
                writer.WritePropertyName("clientSecretCertificateSubjectAlternativeName"u8);
                writer.WriteStringValue(ClientSecretCertificateSubjectAlternativeName);
            }
            if (Optional.IsDefined(ClientSecretCertificateIssuer))
            {
                writer.WritePropertyName("clientSecretCertificateIssuer"u8);
                writer.WriteStringValue(ClientSecretCertificateIssuer);
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

        internal static AppServiceAadRegistration DeserializeAppServiceAadRegistration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> openIdIssuer = default;
            Optional<string> clientId = default;
            Optional<string> clientSecretSettingName = default;
            Optional<string> clientSecretCertificateThumbprint = default;
            Optional<string> clientSecretCertificateSubjectAlternativeName = default;
            Optional<string> clientSecretCertificateIssuer = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openIdIssuer"u8))
                {
                    openIdIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateThumbprint"u8))
                {
                    clientSecretCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateSubjectAlternativeName"u8))
                {
                    clientSecretCertificateSubjectAlternativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateIssuer"u8))
                {
                    clientSecretCertificateIssuer = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceAadRegistration(openIdIssuer.Value, clientId.Value, clientSecretSettingName.Value, clientSecretCertificateThumbprint.Value, clientSecretCertificateSubjectAlternativeName.Value, clientSecretCertificateIssuer.Value, rawData);
        }

        AppServiceAadRegistration IModelJsonSerializable<AppServiceAadRegistration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceAadRegistration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceAadRegistration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceAadRegistration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceAadRegistration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceAadRegistration IModelSerializable<AppServiceAadRegistration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceAadRegistration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceAadRegistration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceAadRegistration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceAadRegistration"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceAadRegistration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceAadRegistration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceAadRegistration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceAadRegistration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
