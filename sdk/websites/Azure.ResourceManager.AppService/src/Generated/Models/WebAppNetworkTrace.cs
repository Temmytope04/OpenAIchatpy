// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Network trace. </summary>
    public partial class WebAppNetworkTrace
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebAppNetworkTrace"/>. </summary>
        internal WebAppNetworkTrace()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppNetworkTrace"/>. </summary>
        /// <param name="path"> Local file path for the captured network trace file. </param>
        /// <param name="status"> Current status of the network trace operation, same as Operation.Status (InProgress/Succeeded/Failed). </param>
        /// <param name="message"> Detailed message of a network trace operation, e.g. error message in case of failure. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppNetworkTrace(string path, string status, string message, Dictionary<string, BinaryData> rawData)
        {
            Path = path;
            Status = status;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Local file path for the captured network trace file. </summary>
        public string Path { get; }
        /// <summary> Current status of the network trace operation, same as Operation.Status (InProgress/Succeeded/Failed). </summary>
        public string Status { get; }
        /// <summary> Detailed message of a network trace operation, e.g. error message in case of failure. </summary>
        public string Message { get; }
    }
}
