// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Error response of an operation failure. </summary>
    public partial class AutomationResponseError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationResponseError"/>. </summary>
        public AutomationResponseError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationResponseError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message indicating why the operation failed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationResponseError(string code, string message, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Error code. </summary>
        public string Code { get; set; }
        /// <summary> Error message indicating why the operation failed. </summary>
        public string Message { get; set; }
    }
}
