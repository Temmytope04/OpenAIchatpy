// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A barcode object. </summary>
    public partial class DocumentBarcode
    {
        /// <summary> Initializes a new instance of <see cref="DocumentBarcode"/>. </summary>
        /// <param name="kind"> Barcode kind. </param>
        /// <param name="value"> Barcode value. </param>
        /// <param name="span"> Location of the barcode in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the barcode. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DocumentBarcode(DocumentBarcodeKind kind, string value, DocumentSpan span, float confidence)
        {
            Argument.AssertNotNull(value, nameof(value));

            Kind = kind;
            Value = value;
            Polygon = new ChangeTrackingList<float>();
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentBarcode"/>. </summary>
        /// <param name="kind"> Barcode kind. </param>
        /// <param name="value"> Barcode value. </param>
        /// <param name="polygon"> Bounding polygon of the barcode. </param>
        /// <param name="span"> Location of the barcode in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the barcode. </param>
        internal DocumentBarcode(DocumentBarcodeKind kind, string value, IReadOnlyList<float> polygon, DocumentSpan span, float confidence)
        {
            Kind = kind;
            Value = value;
            Polygon = polygon;
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Barcode kind. </summary>
        public DocumentBarcodeKind Kind { get; }
        /// <summary> Barcode value. </summary>
        public string Value { get; }
        /// <summary> Location of the barcode in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> Confidence of correctly extracting the barcode. </summary>
        public float Confidence { get; }
    }
}
