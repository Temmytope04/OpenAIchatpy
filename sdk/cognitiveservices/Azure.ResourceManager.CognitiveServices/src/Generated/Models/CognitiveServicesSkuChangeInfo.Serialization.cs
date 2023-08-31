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
    public partial class CognitiveServicesSkuChangeInfo : IUtf8JsonSerializable, IModelJsonSerializable<CognitiveServicesSkuChangeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CognitiveServicesSkuChangeInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CognitiveServicesSkuChangeInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CountOfDowngrades))
            {
                writer.WritePropertyName("countOfDowngrades"u8);
                writer.WriteNumberValue(CountOfDowngrades.Value);
            }
            if (Optional.IsDefined(CountOfUpgradesAfterDowngrades))
            {
                writer.WritePropertyName("countOfUpgradesAfterDowngrades"u8);
                writer.WriteNumberValue(CountOfUpgradesAfterDowngrades.Value);
            }
            if (Optional.IsDefined(LastChangedOn))
            {
                writer.WritePropertyName("lastChangeDate"u8);
                writer.WriteStringValue(LastChangedOn.Value, "O");
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

        internal static CognitiveServicesSkuChangeInfo DeserializeCognitiveServicesSkuChangeInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> countOfDowngrades = default;
            Optional<float> countOfUpgradesAfterDowngrades = default;
            Optional<DateTimeOffset> lastChangeDate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countOfDowngrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    countOfDowngrades = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("countOfUpgradesAfterDowngrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    countOfUpgradesAfterDowngrades = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lastChangeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CognitiveServicesSkuChangeInfo(Optional.ToNullable(countOfDowngrades), Optional.ToNullable(countOfUpgradesAfterDowngrades), Optional.ToNullable(lastChangeDate), rawData);
        }

        CognitiveServicesSkuChangeInfo IModelJsonSerializable<CognitiveServicesSkuChangeInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesSkuChangeInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CognitiveServicesSkuChangeInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CognitiveServicesSkuChangeInfo IModelSerializable<CognitiveServicesSkuChangeInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCognitiveServicesSkuChangeInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CognitiveServicesSkuChangeInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CognitiveServicesSkuChangeInfo"/> to convert. </param>
        public static implicit operator RequestContent(CognitiveServicesSkuChangeInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CognitiveServicesSkuChangeInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CognitiveServicesSkuChangeInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCognitiveServicesSkuChangeInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
