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
    public partial class AppPlatformApiPortalResourceRequirements : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformApiPortalResourceRequirements>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformApiPortalResourceRequirements>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformApiPortalResourceRequirements>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static AppPlatformApiPortalResourceRequirements DeserializeAppPlatformApiPortalResourceRequirements(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cpu = default;
            Optional<string> memory = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformApiPortalResourceRequirements(cpu.Value, memory.Value, rawData);
        }

        AppPlatformApiPortalResourceRequirements IModelJsonSerializable<AppPlatformApiPortalResourceRequirements>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformApiPortalResourceRequirements(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformApiPortalResourceRequirements>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformApiPortalResourceRequirements IModelSerializable<AppPlatformApiPortalResourceRequirements>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformApiPortalResourceRequirements(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppPlatformApiPortalResourceRequirements"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppPlatformApiPortalResourceRequirements"/> to convert. </param>
        public static implicit operator RequestContent(AppPlatformApiPortalResourceRequirements model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppPlatformApiPortalResourceRequirements"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppPlatformApiPortalResourceRequirements(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformApiPortalResourceRequirements(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
