// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </summary>
    internal partial class TranslationError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TranslationError"/>. </summary>
        /// <param name="code"> Enums containing high level error codes. </param>
        /// <param name="message"> Gets high level error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal TranslationError(TranslationErrorCode code, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationError"/>. </summary>
        /// <param name="code"> Enums containing high level error codes. </param>
        /// <param name="message"> Gets high level error message. </param>
        /// <param name="target">
        /// Gets the source of the error.
        /// For example it would be "documents" or "document id" in case of invalid document.
        /// </param>
        /// <param name="innerError">
        /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
        /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslationError(TranslationErrorCode code, string message, string target, InnerTranslationError innerError, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            Target = target;
            InnerError = innerError;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationError"/> for deserialization. </summary>
        internal TranslationError()
        {
        }

        /// <summary> Enums containing high level error codes. </summary>
        public TranslationErrorCode Code { get; }
        /// <summary> Gets high level error message. </summary>
        public string Message { get; }
        /// <summary>
        /// Gets the source of the error.
        /// For example it would be "documents" or "document id" in case of invalid document.
        /// </summary>
        public string Target { get; }
        /// <summary>
        /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
        /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
        /// </summary>
        public InnerTranslationError InnerError { get; }
    }
}
