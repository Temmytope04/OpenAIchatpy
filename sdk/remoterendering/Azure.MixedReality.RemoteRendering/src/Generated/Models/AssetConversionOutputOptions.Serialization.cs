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

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversionOutputOptions : IUtf8JsonSerializable, IModelJsonSerializable<AssetConversionOutputOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AssetConversionOutputOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AssetConversionOutputOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("storageContainerUri"u8);
            writer.WriteStringValue(StorageContainerUri.AbsoluteUri);
            if (Optional.IsDefined(StorageContainerWriteSas))
            {
                writer.WritePropertyName("storageContainerWriteSas"u8);
                writer.WriteStringValue(StorageContainerWriteSas);
            }
            if (Optional.IsDefined(BlobPrefix))
            {
                writer.WritePropertyName("blobPrefix"u8);
                writer.WriteStringValue(BlobPrefix);
            }
            if (Optional.IsDefined(OutputAssetFilename))
            {
                writer.WritePropertyName("outputAssetFilename"u8);
                writer.WriteStringValue(OutputAssetFilename);
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

        internal static AssetConversionOutputOptions DeserializeAssetConversionOutputOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri storageContainerUri = default;
            Optional<string> storageContainerWriteSas = default;
            Optional<string> blobPrefix = default;
            Optional<string> outputAssetFilename = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageContainerUri"u8))
                {
                    storageContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerWriteSas"u8))
                {
                    storageContainerWriteSas = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobPrefix"u8))
                {
                    blobPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputAssetFilename"u8))
                {
                    outputAssetFilename = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AssetConversionOutputOptions(storageContainerUri, storageContainerWriteSas.Value, blobPrefix.Value, outputAssetFilename.Value, rawData);
        }

        AssetConversionOutputOptions IModelJsonSerializable<AssetConversionOutputOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetConversionOutputOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AssetConversionOutputOptions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AssetConversionOutputOptions IModelSerializable<AssetConversionOutputOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAssetConversionOutputOptions(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AssetConversionOutputOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AssetConversionOutputOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAssetConversionOutputOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
