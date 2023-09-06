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
    public partial class SiteSealContent : IUtf8JsonSerializable, IModelJsonSerializable<SiteSealContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteSealContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteSealContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteSealContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsLightTheme))
            {
                writer.WritePropertyName("lightTheme"u8);
                writer.WriteBooleanValue(IsLightTheme.Value);
            }
            if (Optional.IsDefined(Locale))
            {
                writer.WritePropertyName("locale"u8);
                writer.WriteStringValue(Locale);
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

        internal static SiteSealContent DeserializeSiteSealContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> lightTheme = default;
            Optional<string> locale = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lightTheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lightTheme = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("locale"u8))
                {
                    locale = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteSealContent(Optional.ToNullable(lightTheme), locale.Value, rawData);
        }

        SiteSealContent IModelJsonSerializable<SiteSealContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteSealContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteSealContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteSealContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteSealContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteSealContent IModelSerializable<SiteSealContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteSealContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteSealContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteSealContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteSealContent"/> to convert. </param>
        public static implicit operator RequestContent(SiteSealContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteSealContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteSealContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteSealContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
