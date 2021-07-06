// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translation.Document;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Documents Status Response. </summary>
    internal partial class DocumentsStatus
    {
        /// <summary> Initializes a new instance of DocumentsStatus. </summary>
        /// <param name="value"> The detail status of individual documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DocumentsStatus(IEnumerable<DocumentStatus> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DocumentsStatus. </summary>
        /// <param name="value"> The detail status of individual documents. </param>
        /// <param name="nextLink"> Url for the next page.  Null if no more pages available. </param>
        internal DocumentsStatus(IReadOnlyList<DocumentStatus> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The detail status of individual documents. </summary>
        public IReadOnlyList<DocumentStatus> Value { get; }
        /// <summary> Url for the next page.  Null if no more pages available. </summary>
        public string NextLink { get; }
    }
}
