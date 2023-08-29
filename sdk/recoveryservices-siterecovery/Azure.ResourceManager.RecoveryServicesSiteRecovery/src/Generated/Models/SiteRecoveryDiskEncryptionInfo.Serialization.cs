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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryDiskEncryptionInfo : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryDiskEncryptionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryDiskEncryptionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryDiskEncryptionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskEncryptionKeyInfo))
            {
                writer.WritePropertyName("diskEncryptionKeyInfo"u8);
                writer.WriteObjectValue(DiskEncryptionKeyInfo);
            }
            if (Optional.IsDefined(KeyEncryptionKeyInfo))
            {
                writer.WritePropertyName("keyEncryptionKeyInfo"u8);
                writer.WriteObjectValue(KeyEncryptionKeyInfo);
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

        internal static SiteRecoveryDiskEncryptionInfo DeserializeSiteRecoveryDiskEncryptionInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryDiskEncryptionKeyInfo> diskEncryptionKeyInfo = default;
            Optional<SiteRecoveryKeyEncryptionKeyInfo> keyEncryptionKeyInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionKeyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionKeyInfo = SiteRecoveryDiskEncryptionKeyInfo.DeserializeSiteRecoveryDiskEncryptionKeyInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKeyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyInfo = SiteRecoveryKeyEncryptionKeyInfo.DeserializeSiteRecoveryKeyEncryptionKeyInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryDiskEncryptionInfo(diskEncryptionKeyInfo.Value, keyEncryptionKeyInfo.Value, rawData);
        }

        SiteRecoveryDiskEncryptionInfo IModelJsonSerializable<SiteRecoveryDiskEncryptionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryDiskEncryptionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryDiskEncryptionInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryDiskEncryptionInfo IModelSerializable<SiteRecoveryDiskEncryptionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryDiskEncryptionInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SiteRecoveryDiskEncryptionInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SiteRecoveryDiskEncryptionInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryDiskEncryptionInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
