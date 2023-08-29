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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class AsciiFoldingTokenFilter : IUtf8JsonSerializable, IModelJsonSerializable<AsciiFoldingTokenFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AsciiFoldingTokenFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AsciiFoldingTokenFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AsciiFoldingTokenFilter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveOriginal))
            {
                writer.WritePropertyName("preserveOriginal"u8);
                writer.WriteBooleanValue(PreserveOriginal.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static AsciiFoldingTokenFilter DeserializeAsciiFoldingTokenFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> preserveOriginal = default;
            string odataType = default;
            string name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveOriginal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveOriginal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AsciiFoldingTokenFilter(odataType, name, Optional.ToNullable(preserveOriginal), rawData);
        }

        AsciiFoldingTokenFilter IModelJsonSerializable<AsciiFoldingTokenFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AsciiFoldingTokenFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAsciiFoldingTokenFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AsciiFoldingTokenFilter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AsciiFoldingTokenFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AsciiFoldingTokenFilter IModelSerializable<AsciiFoldingTokenFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AsciiFoldingTokenFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAsciiFoldingTokenFilter(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AsciiFoldingTokenFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AsciiFoldingTokenFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAsciiFoldingTokenFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
