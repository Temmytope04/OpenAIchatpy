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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class OutlookChannel : IUtf8JsonSerializable, IModelJsonSerializable<OutlookChannel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OutlookChannel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OutlookChannel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OutlookChannel>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("channelName"u8);
            writer.WriteStringValue(ChannelName);
            if (Optional.IsDefined(ETag))
            {
                if (ETag != null)
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.ToString());
                }
                else
                {
                    writer.WriteNull("etag");
                }
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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

        internal static OutlookChannel DeserializeOutlookChannel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string channelName = default;
            Optional<ETag?> etag = default;
            Optional<string> provisioningState = default;
            Optional<AzureLocation> location = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channelName"u8))
                {
                    channelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        etag = null;
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OutlookChannel(channelName, Optional.ToNullable(etag), provisioningState.Value, Optional.ToNullable(location), rawData);
        }

        OutlookChannel IModelJsonSerializable<OutlookChannel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OutlookChannel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOutlookChannel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OutlookChannel>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OutlookChannel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OutlookChannel IModelSerializable<OutlookChannel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OutlookChannel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOutlookChannel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OutlookChannel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OutlookChannel"/> to convert. </param>
        public static implicit operator RequestContent(OutlookChannel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OutlookChannel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OutlookChannel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOutlookChannel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
