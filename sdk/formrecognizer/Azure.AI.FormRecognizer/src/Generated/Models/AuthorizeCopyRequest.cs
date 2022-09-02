// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Request body to authorize document model copy. </summary>
    internal partial class AuthorizeCopyRequest
    {
        /// <summary> Initializes a new instance of AuthorizeCopyRequest. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public AuthorizeCopyRequest(string modelId)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            ModelId = modelId;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
        /// <summary> Document model description. </summary>
        public string Description { get; set; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
