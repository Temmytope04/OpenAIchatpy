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
    internal partial class AppServiceBlobStorageTokenStore : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceBlobStorageTokenStore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceBlobStorageTokenStore>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceBlobStorageTokenStore>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SasUrlSettingName))
            {
                writer.WritePropertyName("sasUrlSettingName"u8);
                writer.WriteStringValue(SasUrlSettingName);
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

        internal static AppServiceBlobStorageTokenStore DeserializeAppServiceBlobStorageTokenStore(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sasUrlSettingName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrlSettingName"u8))
                {
                    sasUrlSettingName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceBlobStorageTokenStore(sasUrlSettingName.Value, rawData);
        }

        AppServiceBlobStorageTokenStore IModelJsonSerializable<AppServiceBlobStorageTokenStore>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceBlobStorageTokenStore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceBlobStorageTokenStore>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceBlobStorageTokenStore IModelSerializable<AppServiceBlobStorageTokenStore>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceBlobStorageTokenStore(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AppServiceBlobStorageTokenStore model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AppServiceBlobStorageTokenStore(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceBlobStorageTokenStore(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
