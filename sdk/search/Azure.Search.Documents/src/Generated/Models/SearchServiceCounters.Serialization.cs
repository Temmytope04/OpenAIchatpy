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
    public partial class SearchServiceCounters : IUtf8JsonSerializable, IModelJsonSerializable<SearchServiceCounters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchServiceCounters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchServiceCounters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("aliasesCount"u8);
            writer.WriteObjectValue(AliasCounter);
            writer.WritePropertyName("documentCount"u8);
            writer.WriteObjectValue(DocumentCounter);
            writer.WritePropertyName("indexesCount"u8);
            writer.WriteObjectValue(IndexCounter);
            writer.WritePropertyName("indexersCount"u8);
            writer.WriteObjectValue(IndexerCounter);
            writer.WritePropertyName("dataSourcesCount"u8);
            writer.WriteObjectValue(DataSourceCounter);
            writer.WritePropertyName("storageSize"u8);
            writer.WriteObjectValue(StorageSizeCounter);
            writer.WritePropertyName("synonymMaps"u8);
            writer.WriteObjectValue(SynonymMapCounter);
            writer.WritePropertyName("skillsetCount"u8);
            writer.WriteObjectValue(SkillsetCounter);
            writer.WritePropertyName("vectorIndexSize"u8);
            writer.WriteObjectValue(VectorIndexSizeCounter);
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

        internal static SearchServiceCounters DeserializeSearchServiceCounters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchResourceCounter aliasesCount = default;
            SearchResourceCounter documentCount = default;
            SearchResourceCounter indexesCount = default;
            SearchResourceCounter indexersCount = default;
            SearchResourceCounter dataSourcesCount = default;
            SearchResourceCounter storageSize = default;
            SearchResourceCounter synonymMaps = default;
            SearchResourceCounter skillsetCount = default;
            SearchResourceCounter vectorIndexSize = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aliasesCount"u8))
                {
                    aliasesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexesCount"u8))
                {
                    indexesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexersCount"u8))
                {
                    indexersCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourcesCount"u8))
                {
                    dataSourcesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("storageSize"u8))
                {
                    storageSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("synonymMaps"u8))
                {
                    synonymMaps = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("skillsetCount"u8))
                {
                    skillsetCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("vectorIndexSize"u8))
                {
                    vectorIndexSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchServiceCounters(aliasesCount, documentCount, indexesCount, indexersCount, dataSourcesCount, storageSize, synonymMaps, skillsetCount, vectorIndexSize, rawData);
        }

        SearchServiceCounters IModelJsonSerializable<SearchServiceCounters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceCounters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchServiceCounters>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchServiceCounters IModelSerializable<SearchServiceCounters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchServiceCounters(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SearchServiceCounters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SearchServiceCounters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchServiceCounters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
