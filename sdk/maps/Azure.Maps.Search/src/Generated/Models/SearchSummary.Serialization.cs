// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class SearchSummary : IUtf8JsonSerializable, IJsonModel<SearchSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchSummary>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SearchSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SearchSummary>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SearchSummary>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Query))
                {
                    writer.WritePropertyName("query"u8);
                    writer.WriteStringValue(Query);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(QueryType))
                {
                    writer.WritePropertyName("queryType"u8);
                    writer.WriteStringValue(QueryType.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(QueryTime))
                {
                    writer.WritePropertyName("queryTime"u8);
                    writer.WriteNumberValue(QueryTime.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResultCount))
                {
                    writer.WritePropertyName("numResults"u8);
                    writer.WriteNumberValue(ResultCount);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Top))
                {
                    writer.WritePropertyName("limit"u8);
                    writer.WriteNumberValue(Top.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Skip))
                {
                    writer.WritePropertyName("offset"u8);
                    writer.WriteNumberValue(Skip.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TotalResults))
                {
                    writer.WritePropertyName("totalResults"u8);
                    writer.WriteNumberValue(TotalResults.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FuzzyLevel))
                {
                    writer.WritePropertyName("fuzzyLevel"u8);
                    writer.WriteNumberValue(FuzzyLevel.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(GeoBiasInternal))
                {
                    writer.WritePropertyName("geoBias"u8);
                    writer.WriteObjectValue(GeoBiasInternal);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SearchSummary IJsonModel<SearchSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchSummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchSummary(document.RootElement, options);
        }

        internal static SearchSummary DeserializeSearchSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> query = default;
            Optional<MapsQueryType> queryType = default;
            Optional<int> queryTime = default;
            Optional<int> numResults = default;
            Optional<int> limit = default;
            Optional<int> offset = default;
            Optional<int> totalResults = default;
            Optional<int> fuzzyLevel = default;
            Optional<LatLongPairAbbreviated> geoBias = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = new MapsQueryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fuzzyLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fuzzyLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoBias"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBias = LatLongPairAbbreviated.DeserializeLatLongPairAbbreviated(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchSummary(query.Value, Optional.ToNullable(queryType), Optional.ToNullable(queryTime), numResults, Optional.ToNullable(limit), Optional.ToNullable(offset), Optional.ToNullable(totalResults), Optional.ToNullable(fuzzyLevel), geoBias.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchSummary>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchSummary)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchSummary IPersistableModel<SearchSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchSummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchSummary(document.RootElement, options);
        }

        string IPersistableModel<SearchSummary>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
