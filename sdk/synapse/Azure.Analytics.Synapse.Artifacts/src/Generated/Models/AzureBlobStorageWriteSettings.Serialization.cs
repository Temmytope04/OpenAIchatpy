// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureBlobStorageWriteSettingsConverter))]
    public partial class AzureBlobStorageWriteSettings : IUtf8JsonSerializable, IModelJsonSerializable<AzureBlobStorageWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureBlobStorageWriteSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureBlobStorageWriteSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureBlobStorageWriteSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BlockSizeInMB))
            {
                writer.WritePropertyName("blockSizeInMB"u8);
                writer.WriteObjectValue(BlockSizeInMB);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior"u8);
                writer.WriteObjectValue(CopyBehavior);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureBlobStorageWriteSettings DeserializeAzureBlobStorageWriteSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> blockSizeInMB = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            Optional<object> copyBehavior = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blockSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSizeInMB = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("copyBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyBehavior = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBlobStorageWriteSettings(type, maxConcurrentConnections.Value, copyBehavior.Value, additionalProperties, blockSizeInMB.Value);
        }

        AzureBlobStorageWriteSettings IModelJsonSerializable<AzureBlobStorageWriteSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureBlobStorageWriteSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureBlobStorageWriteSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureBlobStorageWriteSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureBlobStorageWriteSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureBlobStorageWriteSettings IModelSerializable<AzureBlobStorageWriteSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureBlobStorageWriteSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureBlobStorageWriteSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AzureBlobStorageWriteSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AzureBlobStorageWriteSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureBlobStorageWriteSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AzureBlobStorageWriteSettingsConverter : JsonConverter<AzureBlobStorageWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, AzureBlobStorageWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureBlobStorageWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureBlobStorageWriteSettings(document.RootElement);
            }
        }
    }
}
