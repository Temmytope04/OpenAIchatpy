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
using Azure.ResourceManager.VoiceServices;

namespace Azure.ResourceManager.VoiceServices.Models
{
    internal partial class VoiceServicesTestLineListResult : IUtf8JsonSerializable, IModelJsonSerializable<VoiceServicesTestLineListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VoiceServicesTestLineListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VoiceServicesTestLineListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesTestLineListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VoiceServicesTestLineData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink.AbsoluteUri);
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

        internal static VoiceServicesTestLineListResult DeserializeVoiceServicesTestLineListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VoiceServicesTestLineData> value = default;
            Optional<Uri> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<VoiceServicesTestLineData> array = new List<VoiceServicesTestLineData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VoiceServicesTestLineData.DeserializeVoiceServicesTestLineData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VoiceServicesTestLineListResult(value, nextLink.Value, rawData);
        }

        VoiceServicesTestLineListResult IModelJsonSerializable<VoiceServicesTestLineListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesTestLineListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVoiceServicesTestLineListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VoiceServicesTestLineListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesTestLineListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VoiceServicesTestLineListResult IModelSerializable<VoiceServicesTestLineListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesTestLineListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVoiceServicesTestLineListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VoiceServicesTestLineListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VoiceServicesTestLineListResult"/> to convert. </param>
        public static implicit operator RequestContent(VoiceServicesTestLineListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VoiceServicesTestLineListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VoiceServicesTestLineListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVoiceServicesTestLineListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
