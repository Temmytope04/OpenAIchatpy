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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CidrIPAddress : IUtf8JsonSerializable, IModelJsonSerializable<CidrIPAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CidrIPAddress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CidrIPAddress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BaseIPAddress))
            {
                writer.WritePropertyName("baseIpAddress"u8);
                writer.WriteStringValue(BaseIPAddress);
            }
            if (Optional.IsDefined(PrefixLength))
            {
                writer.WritePropertyName("prefixLength"u8);
                writer.WriteNumberValue(PrefixLength.Value);
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

        internal static CidrIPAddress DeserializeCidrIPAddress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> baseIPAddress = default;
            Optional<int> prefixLength = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseIpAddress"u8))
                {
                    baseIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prefixLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prefixLength = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CidrIPAddress(baseIPAddress.Value, Optional.ToNullable(prefixLength), rawData);
        }

        CidrIPAddress IModelJsonSerializable<CidrIPAddress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCidrIPAddress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CidrIPAddress>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CidrIPAddress IModelSerializable<CidrIPAddress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCidrIPAddress(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CidrIPAddress"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CidrIPAddress"/> to convert. </param>
        public static implicit operator RequestContent(CidrIPAddress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CidrIPAddress"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CidrIPAddress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCidrIPAddress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
