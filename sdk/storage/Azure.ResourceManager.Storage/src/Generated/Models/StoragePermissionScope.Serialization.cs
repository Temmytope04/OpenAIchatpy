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
    public partial class StoragePermissionScope : IUtf8JsonSerializable, IModelJsonSerializable<StoragePermissionScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StoragePermissionScope>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StoragePermissionScope>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoragePermissionScope>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("permissions"u8);
            writer.WriteStringValue(Permissions);
            writer.WritePropertyName("service"u8);
            writer.WriteStringValue(Service);
            writer.WritePropertyName("resourceName"u8);
            writer.WriteStringValue(ResourceName);
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

        internal static StoragePermissionScope DeserializeStoragePermissionScope(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string permissions = default;
            string service = default;
            string resourceName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    permissions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("service"u8))
                {
                    service = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StoragePermissionScope(permissions, service, resourceName, rawData);
        }

        StoragePermissionScope IModelJsonSerializable<StoragePermissionScope>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoragePermissionScope>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStoragePermissionScope(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StoragePermissionScope>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoragePermissionScope>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StoragePermissionScope IModelSerializable<StoragePermissionScope>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoragePermissionScope>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStoragePermissionScope(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StoragePermissionScope"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StoragePermissionScope"/> to convert. </param>
        public static implicit operator RequestContent(StoragePermissionScope model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StoragePermissionScope"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StoragePermissionScope(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStoragePermissionScope(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
