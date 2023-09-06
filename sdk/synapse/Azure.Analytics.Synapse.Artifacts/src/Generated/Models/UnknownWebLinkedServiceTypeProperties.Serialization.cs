// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    internal partial class UnknownWebLinkedServiceTypeProperties : IUtf8JsonSerializable, IModelJsonSerializable<WebLinkedServiceTypeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebLinkedServiceTypeProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebLinkedServiceTypeProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebLinkedServiceTypeProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteObjectValue(Url);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        internal static WebLinkedServiceTypeProperties DeserializeUnknownWebLinkedServiceTypeProperties(JsonElement element, ModelSerializerOptions options = default) => DeserializeWebLinkedServiceTypeProperties(element, options);

        WebLinkedServiceTypeProperties IModelJsonSerializable<WebLinkedServiceTypeProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebLinkedServiceTypeProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownWebLinkedServiceTypeProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebLinkedServiceTypeProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebLinkedServiceTypeProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebLinkedServiceTypeProperties IModelSerializable<WebLinkedServiceTypeProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebLinkedServiceTypeProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebLinkedServiceTypeProperties(doc.RootElement, options);
        }
    }
}
