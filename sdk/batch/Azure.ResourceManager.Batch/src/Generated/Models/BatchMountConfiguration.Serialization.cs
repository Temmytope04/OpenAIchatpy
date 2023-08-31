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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchMountConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<BatchMountConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchMountConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchMountConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BlobFileSystemConfiguration))
            {
                writer.WritePropertyName("azureBlobFileSystemConfiguration"u8);
                if (BlobFileSystemConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchBlobFileSystemConfiguration>)BlobFileSystemConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(NfsMountConfiguration))
            {
                writer.WritePropertyName("nfsMountConfiguration"u8);
                if (NfsMountConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchNfsMountConfiguration>)NfsMountConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CifsMountConfiguration))
            {
                writer.WritePropertyName("cifsMountConfiguration"u8);
                if (CifsMountConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchCifsMountConfiguration>)CifsMountConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(FileShareConfiguration))
            {
                writer.WritePropertyName("azureFileShareConfiguration"u8);
                if (FileShareConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchFileShareConfiguration>)FileShareConfiguration).Serialize(writer, options);
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

        internal static BatchMountConfiguration DeserializeBatchMountConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchBlobFileSystemConfiguration> azureBlobFileSystemConfiguration = default;
            Optional<BatchNfsMountConfiguration> nfsMountConfiguration = default;
            Optional<BatchCifsMountConfiguration> cifsMountConfiguration = default;
            Optional<BatchFileShareConfiguration> azureFileShareConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureBlobFileSystemConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileSystemConfiguration = BatchBlobFileSystemConfiguration.DeserializeBatchBlobFileSystemConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nfsMountConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfsMountConfiguration = BatchNfsMountConfiguration.DeserializeBatchNfsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("cifsMountConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cifsMountConfiguration = BatchCifsMountConfiguration.DeserializeBatchCifsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("azureFileShareConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileShareConfiguration = BatchFileShareConfiguration.DeserializeBatchFileShareConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchMountConfiguration(azureBlobFileSystemConfiguration.Value, nfsMountConfiguration.Value, cifsMountConfiguration.Value, azureFileShareConfiguration.Value, rawData);
        }

        BatchMountConfiguration IModelJsonSerializable<BatchMountConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchMountConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchMountConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchMountConfiguration IModelSerializable<BatchMountConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchMountConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchMountConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchMountConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(BatchMountConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchMountConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchMountConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchMountConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
