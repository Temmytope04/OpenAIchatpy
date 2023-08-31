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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class DiskEncryptionSetResourceSettings : IUtf8JsonSerializable, IModelJsonSerializable<DiskEncryptionSetResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiskEncryptionSetResourceSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiskEncryptionSetResourceSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DiskEncryptionSetResourceSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("targetResourceName"u8);
            writer.WriteStringValue(TargetResourceName);
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

        internal static DiskEncryptionSetResourceSettings DeserializeDiskEncryptionSetResourceSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceType = default;
            string targetResourceName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiskEncryptionSetResourceSettings(resourceType, targetResourceName, rawData);
        }

        DiskEncryptionSetResourceSettings IModelJsonSerializable<DiskEncryptionSetResourceSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DiskEncryptionSetResourceSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskEncryptionSetResourceSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiskEncryptionSetResourceSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DiskEncryptionSetResourceSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiskEncryptionSetResourceSettings IModelSerializable<DiskEncryptionSetResourceSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DiskEncryptionSetResourceSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiskEncryptionSetResourceSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DiskEncryptionSetResourceSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DiskEncryptionSetResourceSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiskEncryptionSetResourceSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
