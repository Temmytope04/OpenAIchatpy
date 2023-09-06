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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemArchiveStatus : IUtf8JsonSerializable, IModelJsonSerializable<AmlFileSystemArchiveStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmlFileSystemArchiveStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmlFileSystemArchiveStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemArchiveStatus>(this, options.Format);

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

        internal static AmlFileSystemArchiveStatus DeserializeAmlFileSystemArchiveStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArchiveStatusType> state = default;
            Optional<DateTimeOffset> lastCompletionTime = default;
            Optional<DateTimeOffset> lastStartedTime = default;
            Optional<int> percentComplete = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ArchiveStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastCompletionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastCompletionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStartedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("percentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentComplete = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AmlFileSystemArchiveStatus(Optional.ToNullable(state), Optional.ToNullable(lastCompletionTime), Optional.ToNullable(lastStartedTime), Optional.ToNullable(percentComplete), errorCode.Value, errorMessage.Value, rawData);
        }

        AmlFileSystemArchiveStatus IModelJsonSerializable<AmlFileSystemArchiveStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemArchiveStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemArchiveStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmlFileSystemArchiveStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemArchiveStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmlFileSystemArchiveStatus IModelSerializable<AmlFileSystemArchiveStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemArchiveStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmlFileSystemArchiveStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AmlFileSystemArchiveStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AmlFileSystemArchiveStatus"/> to convert. </param>
        public static implicit operator RequestContent(AmlFileSystemArchiveStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AmlFileSystemArchiveStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AmlFileSystemArchiveStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmlFileSystemArchiveStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
