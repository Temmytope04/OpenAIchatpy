// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Response body structure for starting data flow debug session. </summary>
    public partial class AddDataFlowToDebugSessionResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AddDataFlowToDebugSessionResponse"/>. </summary>
        internal AddDataFlowToDebugSessionResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AddDataFlowToDebugSessionResponse"/>. </summary>
        /// <param name="jobVersion"> The ID of data flow debug job version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AddDataFlowToDebugSessionResponse(string jobVersion, Dictionary<string, BinaryData> rawData)
        {
            JobVersion = jobVersion;
            _rawData = rawData;
        }

        /// <summary> The ID of data flow debug job version. </summary>
        public string JobVersion { get; }
    }
}
