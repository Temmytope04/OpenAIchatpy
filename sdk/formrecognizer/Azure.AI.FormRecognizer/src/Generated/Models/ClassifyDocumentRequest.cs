// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Document classification parameters. </summary>
    internal partial class ClassifyDocumentRequest
    {
        /// <summary> Initializes a new instance of ClassifyDocumentRequest. </summary>
        public ClassifyDocumentRequest()
        {
        }

        /// <summary> Document URL to classify. </summary>
        public Uri UrlSource { get; set; }
        /// <summary> Base64 encoding of the document to classify. </summary>
        public byte[] Base64Source { get; set; }
    }
}
