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

namespace Azure.AI.Translation.Document
{
    public partial class DocumentTranslationInput : IUtf8JsonSerializable, IModelJsonSerializable<DocumentTranslationInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentTranslationInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentTranslationInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(StorageUriKind))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageUriKind.Value.ToSerialString());
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

        internal static DocumentTranslationInput DeserializeDocumentTranslationInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TranslationSource source = default;
            IList<TranslationTarget> targets = default;
            Optional<StorageInputUriKind> storageType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = TranslationSource.DeserializeTranslationSource(property.Value);
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    List<TranslationTarget> array = new List<TranslationTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranslationTarget.DeserializeTranslationTarget(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = property.Value.GetString().ToStorageInputUriKind();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentTranslationInput(source, targets, Optional.ToNullable(storageType), rawData);
        }

        DocumentTranslationInput IModelJsonSerializable<DocumentTranslationInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentTranslationInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentTranslationInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentTranslationInput IModelSerializable<DocumentTranslationInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentTranslationInput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DocumentTranslationInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DocumentTranslationInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentTranslationInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
