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

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class SoftwareAssuranceChangeRequestProperties : IUtf8JsonSerializable, IModelJsonSerializable<SoftwareAssuranceChangeRequestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SoftwareAssuranceChangeRequestProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SoftwareAssuranceChangeRequestProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SoftwareAssuranceIntent))
            {
                writer.WritePropertyName("softwareAssuranceIntent"u8);
                writer.WriteStringValue(SoftwareAssuranceIntent.Value.ToString());
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

        internal static SoftwareAssuranceChangeRequestProperties DeserializeSoftwareAssuranceChangeRequestProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SoftwareAssuranceIntent> softwareAssuranceIntent = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("softwareAssuranceIntent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softwareAssuranceIntent = new SoftwareAssuranceIntent(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SoftwareAssuranceChangeRequestProperties(Optional.ToNullable(softwareAssuranceIntent), rawData);
        }

        SoftwareAssuranceChangeRequestProperties IModelJsonSerializable<SoftwareAssuranceChangeRequestProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareAssuranceChangeRequestProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SoftwareAssuranceChangeRequestProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SoftwareAssuranceChangeRequestProperties IModelSerializable<SoftwareAssuranceChangeRequestProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSoftwareAssuranceChangeRequestProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SoftwareAssuranceChangeRequestProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SoftwareAssuranceChangeRequestProperties"/> to convert. </param>
        public static implicit operator RequestContent(SoftwareAssuranceChangeRequestProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SoftwareAssuranceChangeRequestProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SoftwareAssuranceChangeRequestProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSoftwareAssuranceChangeRequestProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
