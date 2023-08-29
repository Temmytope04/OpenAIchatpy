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

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class PostRestoreContent : IUtf8JsonSerializable, IModelJsonSerializable<PostRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostRestoreContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostRestoreContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Partition))
            {
                writer.WritePropertyName("partition"u8);
                writer.WriteStringValue(Partition);
            }
            if (Optional.IsDefined(ReplicaGroup))
            {
                writer.WritePropertyName("replicaGroup"u8);
                writer.WriteStringValue(ReplicaGroup);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(AzureFileShareUri))
            {
                writer.WritePropertyName("azureFileShareUri"u8);
                writer.WriteStringValue(AzureFileShareUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SourceAzureFileShareUri))
            {
                writer.WritePropertyName("sourceAzureFileShareUri"u8);
                writer.WriteStringValue(SourceAzureFileShareUri.AbsoluteUri);
            }
            if (Optional.IsDefined(FailedFileList))
            {
                writer.WritePropertyName("failedFileList"u8);
                writer.WriteStringValue(FailedFileList);
            }
            if (Optional.IsCollectionDefined(RestoreFileSpec))
            {
                writer.WritePropertyName("restoreFileSpec"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreFileSpec)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static PostRestoreContent DeserializePostRestoreContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> partition = default;
            Optional<string> replicaGroup = default;
            Optional<string> requestId = default;
            Optional<Uri> azureFileShareUri = default;
            Optional<string> status = default;
            Optional<Uri> sourceAzureFileShareUri = default;
            Optional<string> failedFileList = default;
            Optional<IList<RestoreFileSpec>> restoreFileSpec = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partition"u8))
                {
                    partition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaGroup"u8))
                {
                    replicaGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileShareUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileShareUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAzureFileShareUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceAzureFileShareUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failedFileList"u8))
                {
                    failedFileList = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreFileSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestoreFileSpec> array = new List<RestoreFileSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.RestoreFileSpec.DeserializeRestoreFileSpec(item));
                    }
                    restoreFileSpec = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostRestoreContent(partition.Value, replicaGroup.Value, requestId.Value, azureFileShareUri.Value, status.Value, sourceAzureFileShareUri.Value, failedFileList.Value, Optional.ToList(restoreFileSpec), rawData);
        }

        PostRestoreContent IModelJsonSerializable<PostRestoreContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostRestoreContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostRestoreContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostRestoreContent IModelSerializable<PostRestoreContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostRestoreContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostRestoreContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostRestoreContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostRestoreContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
