// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    internal static partial class InnerErrorCodeValueExtensions
    {
        public static string ToSerialString(this InnerErrorCodeValue value) => value switch
        {
            InnerErrorCodeValue.InvalidParameterValue => "InvalidParameterValue",
            InnerErrorCodeValue.InvalidRequestBodyFormat => "InvalidRequestBodyFormat",
            InnerErrorCodeValue.EmptyRequest => "EmptyRequest",
            InnerErrorCodeValue.MissingInputRecords => "MissingInputRecords",
            InnerErrorCodeValue.InvalidDocument => "InvalidDocument",
            InnerErrorCodeValue.ModelVersionIncorrect => "ModelVersionIncorrect",
            InnerErrorCodeValue.InvalidDocumentBatch => "InvalidDocumentBatch",
            InnerErrorCodeValue.UnsupportedLanguageCode => "UnsupportedLanguageCode",
            InnerErrorCodeValue.InvalidCountryHint => "InvalidCountryHint",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InnerErrorCodeValue value.")
        };

        public static InnerErrorCodeValue ToInnerErrorCodeValue(this string value)
        {
            if (string.Equals(value, "InvalidParameterValue", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.InvalidParameterValue;
            if (string.Equals(value, "InvalidRequestBodyFormat", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.InvalidRequestBodyFormat;
            if (string.Equals(value, "EmptyRequest", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.EmptyRequest;
            if (string.Equals(value, "MissingInputRecords", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.MissingInputRecords;
            if (string.Equals(value, "InvalidDocument", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.InvalidDocument;
            if (string.Equals(value, "ModelVersionIncorrect", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.ModelVersionIncorrect;
            if (string.Equals(value, "InvalidDocumentBatch", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.InvalidDocumentBatch;
            if (string.Equals(value, "UnsupportedLanguageCode", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.UnsupportedLanguageCode;
            if (string.Equals(value, "InvalidCountryHint", StringComparison.InvariantCultureIgnoreCase)) return InnerErrorCodeValue.InvalidCountryHint;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InnerErrorCodeValue value.");
        }
    }
}
