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
    public partial class UaxUrlEmailTokenizer : IUtf8JsonSerializable, IModelJsonSerializable<UaxUrlEmailTokenizer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UaxUrlEmailTokenizer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UaxUrlEmailTokenizer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<UaxUrlEmailTokenizer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxTokenLength))
            {
                writer.WritePropertyName("maxTokenLength"u8);
                writer.WriteNumberValue(MaxTokenLength.Value);
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

        internal static UaxUrlEmailTokenizer DeserializeUaxUrlEmailTokenizer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxTokenLength = default;
            string odataType = default;
            string name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTokenLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokenLength = property.Value.GetInt32();
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
            return new UaxUrlEmailTokenizer(odataType, name, Optional.ToNullable(maxTokenLength), rawData);
        }

        UaxUrlEmailTokenizer IModelJsonSerializable<UaxUrlEmailTokenizer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<UaxUrlEmailTokenizer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUaxUrlEmailTokenizer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UaxUrlEmailTokenizer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<UaxUrlEmailTokenizer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UaxUrlEmailTokenizer IModelSerializable<UaxUrlEmailTokenizer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<UaxUrlEmailTokenizer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUaxUrlEmailTokenizer(doc.RootElement, options);
        }

        public static implicit operator RequestContent(UaxUrlEmailTokenizer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator UaxUrlEmailTokenizer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUaxUrlEmailTokenizer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
