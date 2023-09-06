// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> An input for the query compilation. </summary>
    public partial class StreamAnalyticsQueryInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryInput"/>. </summary>
        /// <param name="name"> The name of the input. </param>
        /// <param name="queryInputType"> The type of the input, can be Stream or Reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="queryInputType"/> is null. </exception>
        public StreamAnalyticsQueryInput(string name, string queryInputType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(queryInputType, nameof(queryInputType));

            Name = name;
            QueryInputType = queryInputType;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryInput"/>. </summary>
        /// <param name="name"> The name of the input. </param>
        /// <param name="queryInputType"> The type of the input, can be Stream or Reference. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsQueryInput(string name, string queryInputType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            QueryInputType = queryInputType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryInput"/> for deserialization. </summary>
        internal StreamAnalyticsQueryInput()
        {
        }

        /// <summary> The name of the input. </summary>
        public string Name { get; }
        /// <summary> The type of the input, can be Stream or Reference. </summary>
        public string QueryInputType { get; }
    }
}
