// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchDocumentsResult
    {
        internal static SearchDocumentsResult DeserializeSearchDocumentsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> odataCount = default;
            Optional<double> searchCoverage = default;
            Optional<IReadOnlyDictionary<string, IList<FacetResult>>> searchFacets = default;
            Optional<IReadOnlyList<AnswerResult>> searchAnswers = default;
            Optional<SearchOptions> searchNextPageParameters = default;
            IReadOnlyList<SearchResult> value = default;
            Optional<string> odataNextLink = default;
            Optional<SemanticPartialResponseReason> searchSemanticPartialResponseReason = default;
            Optional<SemanticPartialResponseType> searchSemanticPartialResponseType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.coverage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.facets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<FacetResult>> dictionary = new Dictionary<string, IList<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<FacetResult> array = new List<FacetResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FacetResult.DeserializeFacetResult(item));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    searchFacets = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.answers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchAnswers = null;
                        continue;
                    }
                    List<AnswerResult> array = new List<AnswerResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnswerResult.DeserializeAnswerResult(item));
                    }
                    searchAnswers = array;
                    continue;
                }
                if (property.NameEquals("@search.nextPageParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchNextPageParameters = SearchOptions.DeserializeSearchOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<SearchResult> array = new List<SearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchResult.DeserializeSearchResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@search.semanticPartialResponseReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchSemanticPartialResponseReason = new SemanticPartialResponseReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@search.semanticPartialResponseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchSemanticPartialResponseType = new SemanticPartialResponseType(property.Value.GetString());
                    continue;
                }
            }
            return new SearchDocumentsResult(Optional.ToNullable(odataCount), Optional.ToNullable(searchCoverage), Optional.ToDictionary(searchFacets), Optional.ToList(searchAnswers), searchNextPageParameters.Value, value, odataNextLink.Value, Optional.ToNullable(searchSemanticPartialResponseReason), Optional.ToNullable(searchSemanticPartialResponseType));
        }
    }
}
