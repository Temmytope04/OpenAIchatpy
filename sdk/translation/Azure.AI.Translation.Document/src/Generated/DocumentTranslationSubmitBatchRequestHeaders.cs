// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    internal partial class DocumentTranslationSubmitBatchRequestHeaders
    {
        private readonly Response _response;
        public DocumentTranslationSubmitBatchRequestHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location of batch the operation. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
