// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The JobErrors. </summary>
    internal partial class JobErrors
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="JobErrors"/>. </summary>
        internal JobErrors()
        {
            Errors = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of <see cref="JobErrors"/>. </summary>
        /// <param name="errors"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal JobErrors(IReadOnlyList<Error> errors, Dictionary<string, BinaryData> rawData)
        {
            Errors = errors;
            _rawData = rawData;
        }

        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<Error> Errors { get; }
    }
}
