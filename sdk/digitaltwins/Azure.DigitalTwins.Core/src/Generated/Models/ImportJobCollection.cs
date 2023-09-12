// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A collection of import job objects. </summary>
    internal partial class ImportJobCollection
    {
        /// <summary> Initializes a new instance of ImportJobCollection. </summary>
        /// <param name="value"> The list of import job objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ImportJobCollection(IEnumerable<ImportJob> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ImportJobCollection. </summary>
        /// <param name="value"> The list of import job objects. </param>
        /// <param name="nextLink"> A URI to retrieve the next page of results. </param>
        internal ImportJobCollection(IReadOnlyList<ImportJob> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of import job objects. </summary>
        public IReadOnlyList<ImportJob> Value { get; }
        /// <summary> A URI to retrieve the next page of results. </summary>
        public string NextLink { get; }
    }
}
