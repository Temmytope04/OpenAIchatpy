// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The SendDtmfFailed. </summary>
    public partial class SendDtmfFailed
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SendDtmfFailed"/>. </summary>
        internal SendDtmfFailed()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SendDtmfFailed"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SendDtmfFailed(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, Dictionary<string, BinaryData> rawData)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            _rawData = rawData;
        }
    }
}
