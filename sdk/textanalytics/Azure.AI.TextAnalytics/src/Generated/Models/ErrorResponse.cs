// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Error response. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="error"> The error object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorResponse(Error error)
        {
            Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="error"> The error object. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorResponse(Error error, Dictionary<string, BinaryData> rawData)
        {
            Error = error;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/> for deserialization. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> The error object. </summary>
        public Error Error { get; }
    }
}
