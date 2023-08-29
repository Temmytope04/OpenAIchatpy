// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Response from a List Datasources request. If successful, it includes the full definitions of all datasources. </summary>
    internal partial class ListDataSourcesResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListDataSourcesResult"/>. </summary>
        /// <param name="dataSources"> The datasources in the Search service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSources"/> is null. </exception>
        internal ListDataSourcesResult(IEnumerable<SearchIndexerDataSourceConnection> dataSources)
        {
            Argument.AssertNotNull(dataSources, nameof(dataSources));

            DataSources = dataSources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ListDataSourcesResult"/>. </summary>
        /// <param name="dataSources"> The datasources in the Search service. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListDataSourcesResult(IReadOnlyList<SearchIndexerDataSourceConnection> dataSources, Dictionary<string, BinaryData> rawData)
        {
            DataSources = dataSources;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ListDataSourcesResult"/> for deserialization. </summary>
        internal ListDataSourcesResult()
        {
        }

        /// <summary> The datasources in the Search service. </summary>
        public IReadOnlyList<SearchIndexerDataSourceConnection> DataSources { get; }
    }
}
