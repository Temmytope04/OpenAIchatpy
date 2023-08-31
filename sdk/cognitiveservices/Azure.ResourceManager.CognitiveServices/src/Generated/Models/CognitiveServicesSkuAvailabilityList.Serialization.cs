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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesSkuAvailabilityList : IUtf8JsonSerializable, IModelJsonSerializable<CognitiveServicesSkuAvailabilityList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CognitiveServicesSkuAvailabilityList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CognitiveServicesSkuAvailabilityList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(SkuAvailabilityType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SkuAvailabilityType);
            }
            if (Optional.IsDefined(SkuName))
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            if (Optional.IsDefined(IsSkuAvailable))
            {
                writer.WritePropertyName("skuAvailable"u8);
                writer.WriteBooleanValue(IsSkuAvailable.Value);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        internal static CognitiveServicesSkuAvailabilityList DeserializeCognitiveServicesSkuAvailabilityList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<string> type = default;
            Optional<string> skuName = default;
            Optional<bool> skuAvailable = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuName"u8))
                {
                    skuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skuAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CognitiveServicesSkuAvailabilityList(kind.Value, type.Value, skuName.Value, Optional.ToNullable(skuAvailable), reason.Value, message.Value, rawData);
        }

        CognitiveServicesSkuAvailabilityList IModelJsonSerializable<CognitiveServicesSkuAvailabilityList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesSkuAvailabilityList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CognitiveServicesSkuAvailabilityList>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CognitiveServicesSkuAvailabilityList IModelSerializable<CognitiveServicesSkuAvailabilityList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCognitiveServicesSkuAvailabilityList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CognitiveServicesSkuAvailabilityList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CognitiveServicesSkuAvailabilityList"/> to convert. </param>
        public static implicit operator RequestContent(CognitiveServicesSkuAvailabilityList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CognitiveServicesSkuAvailabilityList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CognitiveServicesSkuAvailabilityList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCognitiveServicesSkuAvailabilityList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
