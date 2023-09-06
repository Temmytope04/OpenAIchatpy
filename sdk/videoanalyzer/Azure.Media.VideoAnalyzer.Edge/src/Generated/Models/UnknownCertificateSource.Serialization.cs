// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    internal partial class UnknownCertificateSource : IUtf8JsonSerializable, IModelJsonSerializable<CertificateSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CertificateSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CertificateSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateSource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
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

        internal static CertificateSource DeserializeUnknownCertificateSource(JsonElement element, ModelSerializerOptions options = default) => DeserializeCertificateSource(element, options);

        CertificateSource IModelJsonSerializable<CertificateSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownCertificateSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CertificateSource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CertificateSource IModelSerializable<CertificateSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCertificateSource(doc.RootElement, options);
        }
    }
}
