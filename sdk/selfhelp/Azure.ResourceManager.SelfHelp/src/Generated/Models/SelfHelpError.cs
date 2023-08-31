// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Error definition. </summary>
    public partial class SelfHelpError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SelfHelpError"/>. </summary>
        internal SelfHelpError()
        {
            Details = new ChangeTrackingList<SelfHelpError>();
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelpError"/>. </summary>
        /// <param name="code"> Service specific error code which serves as the substatus for the HTTP error code. </param>
        /// <param name="errorType"> Service specific error type which serves as additional context for the error herein. </param>
        /// <param name="message"> Description of the error. </param>
        /// <param name="details"> An array of additional nested error response info objects, as described by this contract. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SelfHelpError(string code, string errorType, string message, IReadOnlyList<SelfHelpError> details, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            ErrorType = errorType;
            Message = message;
            Details = details;
            _rawData = rawData;
        }

        /// <summary> Service specific error code which serves as the substatus for the HTTP error code. </summary>
        public string Code { get; }
        /// <summary> Service specific error type which serves as additional context for the error herein. </summary>
        public string ErrorType { get; }
        /// <summary> Description of the error. </summary>
        public string Message { get; }
        /// <summary> An array of additional nested error response info objects, as described by this contract. </summary>
        public IReadOnlyList<SelfHelpError> Details { get; }
    }
}
