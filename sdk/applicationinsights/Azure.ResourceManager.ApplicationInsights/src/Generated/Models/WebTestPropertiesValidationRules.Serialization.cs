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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WebTestPropertiesValidationRules : IUtf8JsonSerializable, IModelJsonSerializable<WebTestPropertiesValidationRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebTestPropertiesValidationRules>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebTestPropertiesValidationRules>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ContentValidation))
            {
                writer.WritePropertyName("ContentValidation"u8);
                if (ContentValidation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<WebTestPropertiesValidationRulesContentValidation>)ContentValidation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CheckSsl))
            {
                writer.WritePropertyName("SSLCheck"u8);
                writer.WriteBooleanValue(CheckSsl.Value);
            }
            if (Optional.IsDefined(SSLCertRemainingLifetimeCheck))
            {
                writer.WritePropertyName("SSLCertRemainingLifetimeCheck"u8);
                writer.WriteNumberValue(SSLCertRemainingLifetimeCheck.Value);
            }
            if (Optional.IsDefined(ExpectedHttpStatusCode))
            {
                writer.WritePropertyName("ExpectedHttpStatusCode"u8);
                writer.WriteNumberValue(ExpectedHttpStatusCode.Value);
            }
            if (Optional.IsDefined(IgnoreHttpStatusCode))
            {
                writer.WritePropertyName("IgnoreHttpStatusCode"u8);
                writer.WriteBooleanValue(IgnoreHttpStatusCode.Value);
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

        internal static WebTestPropertiesValidationRules DeserializeWebTestPropertiesValidationRules(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WebTestPropertiesValidationRulesContentValidation> contentValidation = default;
            Optional<bool> sslCheck = default;
            Optional<int> sslCertRemainingLifetimeCheck = default;
            Optional<int> expectedHttpStatusCode = default;
            Optional<bool> ignoreHttpStatusCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ContentValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentValidation = WebTestPropertiesValidationRulesContentValidation.DeserializeWebTestPropertiesValidationRulesContentValidation(property.Value);
                    continue;
                }
                if (property.NameEquals("SSLCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("SSLCertRemainingLifetimeCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertRemainingLifetimeCheck = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ExpectedHttpStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedHttpStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("IgnoreHttpStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreHttpStatusCode = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebTestPropertiesValidationRules(contentValidation.Value, Optional.ToNullable(sslCheck), Optional.ToNullable(sslCertRemainingLifetimeCheck), Optional.ToNullable(expectedHttpStatusCode), Optional.ToNullable(ignoreHttpStatusCode), rawData);
        }

        WebTestPropertiesValidationRules IModelJsonSerializable<WebTestPropertiesValidationRules>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebTestPropertiesValidationRules(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebTestPropertiesValidationRules>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebTestPropertiesValidationRules IModelSerializable<WebTestPropertiesValidationRules>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebTestPropertiesValidationRules(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebTestPropertiesValidationRules"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebTestPropertiesValidationRules"/> to convert. </param>
        public static implicit operator RequestContent(WebTestPropertiesValidationRules model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebTestPropertiesValidationRules"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebTestPropertiesValidationRules(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebTestPropertiesValidationRules(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
