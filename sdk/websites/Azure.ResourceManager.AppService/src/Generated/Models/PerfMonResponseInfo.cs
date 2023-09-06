// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Performance monitor API response. </summary>
    public partial class PerfMonResponseInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PerfMonResponseInfo"/>. </summary>
        internal PerfMonResponseInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PerfMonResponseInfo"/>. </summary>
        /// <param name="code"> The response code. </param>
        /// <param name="message"> The message. </param>
        /// <param name="data"> The performance monitor counters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PerfMonResponseInfo(string code, string message, PerfMonSet data, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            Data = data;
            _rawData = rawData;
        }

        /// <summary> The response code. </summary>
        public string Code { get; }
        /// <summary> The message. </summary>
        public string Message { get; }
        /// <summary> The performance monitor counters. </summary>
        public PerfMonSet Data { get; }
    }
}
