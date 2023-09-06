// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of Library resources. </summary>
    internal partial class LibraryListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LibraryListResponse"/>. </summary>
        /// <param name="value"> List of Library. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LibraryListResponse(IEnumerable<LibraryResource> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LibraryListResponse"/>. </summary>
        /// <param name="value"> List of Library. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LibraryListResponse(IReadOnlyList<LibraryResource> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LibraryListResponse"/> for deserialization. </summary>
        internal LibraryListResponse()
        {
        }

        /// <summary> List of Library. </summary>
        public IReadOnlyList<LibraryResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
