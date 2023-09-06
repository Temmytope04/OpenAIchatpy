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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CsmSlotEntity : IUtf8JsonSerializable, IModelJsonSerializable<CsmSlotEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CsmSlotEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CsmSlotEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmSlotEntity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetSlot"u8);
            writer.WriteStringValue(TargetSlot);
            writer.WritePropertyName("preserveVnet"u8);
            writer.WriteBooleanValue(PreserveVnet);
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

        internal static CsmSlotEntity DeserializeCsmSlotEntity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetSlot = default;
            bool preserveVnet = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetSlot"u8))
                {
                    targetSlot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preserveVnet"u8))
                {
                    preserveVnet = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CsmSlotEntity(targetSlot, preserveVnet, rawData);
        }

        CsmSlotEntity IModelJsonSerializable<CsmSlotEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmSlotEntity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCsmSlotEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CsmSlotEntity>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmSlotEntity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CsmSlotEntity IModelSerializable<CsmSlotEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmSlotEntity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCsmSlotEntity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CsmSlotEntity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CsmSlotEntity"/> to convert. </param>
        public static implicit operator RequestContent(CsmSlotEntity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CsmSlotEntity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CsmSlotEntity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCsmSlotEntity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
