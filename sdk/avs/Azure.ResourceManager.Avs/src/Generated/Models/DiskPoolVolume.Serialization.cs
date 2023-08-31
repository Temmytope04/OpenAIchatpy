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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class DiskPoolVolume : IUtf8JsonSerializable, IModelJsonSerializable<DiskPoolVolume>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiskPoolVolume>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiskPoolVolume>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetId"u8);
            writer.WriteStringValue(TargetId);
            writer.WritePropertyName("lunName"u8);
            writer.WriteStringValue(LunName);
            if (Optional.IsDefined(MountOption))
            {
                writer.WritePropertyName("mountOption"u8);
                writer.WriteStringValue(MountOption.Value.ToString());
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

        internal static DiskPoolVolume DeserializeDiskPoolVolume(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier targetId = default;
            string lunName = default;
            Optional<LunMountMode> mountOption = default;
            Optional<string> path = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetId"u8))
                {
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lunName"u8))
                {
                    lunName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountOption = new LunMountMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiskPoolVolume(targetId, lunName, Optional.ToNullable(mountOption), path.Value, rawData);
        }

        DiskPoolVolume IModelJsonSerializable<DiskPoolVolume>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskPoolVolume(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiskPoolVolume>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiskPoolVolume IModelSerializable<DiskPoolVolume>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiskPoolVolume(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiskPoolVolume"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiskPoolVolume"/> to convert. </param>
        public static implicit operator RequestContent(DiskPoolVolume model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiskPoolVolume"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiskPoolVolume(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiskPoolVolume(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
