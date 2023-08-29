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
    public partial class CloudEndpointChangeEnumerationActivity : IUtf8JsonSerializable, IModelJsonSerializable<CloudEndpointChangeEnumerationActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudEndpointChangeEnumerationActivity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudEndpointChangeEnumerationActivity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static CloudEndpointChangeEnumerationActivity DeserializeCloudEndpointChangeEnumerationActivity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<CloudEndpointChangeEnumerationActivityState> operationState = default;
            Optional<int> statusCode = default;
            Optional<DateTimeOffset> startedTimestamp = default;
            Optional<long> processedFilesCount = default;
            Optional<long> processedDirectoriesCount = default;
            Optional<long> totalFilesCount = default;
            Optional<long> totalDirectoriesCount = default;
            Optional<long> totalSizeBytes = default;
            Optional<int> progressPercent = default;
            Optional<int> minutesRemaining = default;
            Optional<CloudEndpointChangeEnumerationTotalCountsState> totalCountsState = default;
            Optional<int> deletesProgressPercent = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("operationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationState = new CloudEndpointChangeEnumerationActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("processedFilesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedFilesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("processedDirectoriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedDirectoriesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalFilesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFilesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDirectoriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDirectoriesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("progressPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minutesRemaining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minutesRemaining = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalCountsState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCountsState = new CloudEndpointChangeEnumerationTotalCountsState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deletesProgressPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletesProgressPercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudEndpointChangeEnumerationActivity(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(operationState), Optional.ToNullable(statusCode), Optional.ToNullable(startedTimestamp), Optional.ToNullable(processedFilesCount), Optional.ToNullable(processedDirectoriesCount), Optional.ToNullable(totalFilesCount), Optional.ToNullable(totalDirectoriesCount), Optional.ToNullable(totalSizeBytes), Optional.ToNullable(progressPercent), Optional.ToNullable(minutesRemaining), Optional.ToNullable(totalCountsState), Optional.ToNullable(deletesProgressPercent), rawData);
        }

        CloudEndpointChangeEnumerationActivity IModelJsonSerializable<CloudEndpointChangeEnumerationActivity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointChangeEnumerationActivity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudEndpointChangeEnumerationActivity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudEndpointChangeEnumerationActivity IModelSerializable<CloudEndpointChangeEnumerationActivity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudEndpointChangeEnumerationActivity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CloudEndpointChangeEnumerationActivity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CloudEndpointChangeEnumerationActivity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudEndpointChangeEnumerationActivity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
