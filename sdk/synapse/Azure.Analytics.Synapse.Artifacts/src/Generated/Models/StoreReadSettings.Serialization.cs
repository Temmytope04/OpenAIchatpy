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
    [JsonConverter(typeof(StoreReadSettingsConverter))]
    public partial class StoreReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<StoreReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StoreReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StoreReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static StoreReadSettings DeserializeStoreReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3ReadSettings": return AmazonS3ReadSettings.DeserializeAmazonS3ReadSettings(element);
                    case "AzureBlobFSReadSettings": return AzureBlobFSReadSettings.DeserializeAzureBlobFSReadSettings(element);
                    case "AzureBlobStorageReadSettings": return AzureBlobStorageReadSettings.DeserializeAzureBlobStorageReadSettings(element);
                    case "AzureDataLakeStoreReadSettings": return AzureDataLakeStoreReadSettings.DeserializeAzureDataLakeStoreReadSettings(element);
                    case "AzureFileStorageReadSettings": return AzureFileStorageReadSettings.DeserializeAzureFileStorageReadSettings(element);
                    case "FileServerReadSettings": return FileServerReadSettings.DeserializeFileServerReadSettings(element);
                    case "FtpReadSettings": return FtpReadSettings.DeserializeFtpReadSettings(element);
                    case "GoogleCloudStorageReadSettings": return GoogleCloudStorageReadSettings.DeserializeGoogleCloudStorageReadSettings(element);
                    case "HdfsReadSettings": return HdfsReadSettings.DeserializeHdfsReadSettings(element);
                    case "HttpReadSettings": return HttpReadSettings.DeserializeHttpReadSettings(element);
                    case "SftpReadSettings": return SftpReadSettings.DeserializeSftpReadSettings(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
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
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownStoreReadSettings(type, maxConcurrentConnections.Value, additionalProperties);
        }

        StoreReadSettings IModelJsonSerializable<StoreReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStoreReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StoreReadSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StoreReadSettings IModelSerializable<StoreReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStoreReadSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StoreReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StoreReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStoreReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class StoreReadSettingsConverter : JsonConverter<StoreReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, StoreReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StoreReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStoreReadSettings(document.RootElement);
            }
        }
    }
}
