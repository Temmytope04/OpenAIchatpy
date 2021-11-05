// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    internal partial class DocumentAnalysisDocumentAnalysisBuildDocumentModelHeaders
    {
        private readonly Response _response;
        public DocumentAnalysisDocumentAnalysisBuildDocumentModelHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Operation result URL. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
