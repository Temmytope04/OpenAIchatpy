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
    internal partial class FileSystemTokenStore : IUtf8JsonSerializable, IModelJsonSerializable<FileSystemTokenStore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FileSystemTokenStore>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FileSystemTokenStore>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FileSystemTokenStore>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Directory))
            {
                writer.WritePropertyName("directory"u8);
                writer.WriteStringValue(Directory);
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

        internal static FileSystemTokenStore DeserializeFileSystemTokenStore(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> directory = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directory"u8))
                {
                    directory = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FileSystemTokenStore(directory.Value, rawData);
        }

        FileSystemTokenStore IModelJsonSerializable<FileSystemTokenStore>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FileSystemTokenStore>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSystemTokenStore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FileSystemTokenStore>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FileSystemTokenStore>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FileSystemTokenStore IModelSerializable<FileSystemTokenStore>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FileSystemTokenStore>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFileSystemTokenStore(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FileSystemTokenStore"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FileSystemTokenStore"/> to convert. </param>
        public static implicit operator RequestContent(FileSystemTokenStore model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FileSystemTokenStore"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FileSystemTokenStore(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFileSystemTokenStore(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
