// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for muting participants from the call. </summary>
    public partial class MuteParticipantsResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MuteParticipantsResult"/>. </summary>
        internal MuteParticipantsResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MuteParticipantsResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MuteParticipantsResult(string operationContext, Dictionary<string, BinaryData> rawData)
        {
            OperationContext = operationContext;
            _rawData = rawData;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
