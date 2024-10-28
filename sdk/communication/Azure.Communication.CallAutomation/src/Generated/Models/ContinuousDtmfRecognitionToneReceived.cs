// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The ContinuousDtmfRecognitionToneReceived. </summary>
    public partial class ContinuousDtmfRecognitionToneReceived
    {
        /// <summary> Initializes a new instance of <see cref="ContinuousDtmfRecognitionToneReceived"/>. </summary>
        internal ContinuousDtmfRecognitionToneReceived()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContinuousDtmfRecognitionToneReceived"/>. </summary>
        /// <param name="sequenceId"> The sequence id which can be used to determine if the same tone was played multiple times or if any tones were missed. </param>
        /// <param name="tone"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId or skype chain ID. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        internal ContinuousDtmfRecognitionToneReceived(int? sequenceId, DtmfTone? tone, string callConnectionId, string serverCallId, string correlationId, ResultInformation resultInformation, string operationContext)
        {
            SequenceId = sequenceId;
            Tone = tone;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            ResultInformation = resultInformation;
            OperationContext = operationContext;
        }

        /// <summary> The sequence id which can be used to determine if the same tone was played multiple times or if any tones were missed. </summary>
        public int? SequenceId { get; }
        /// <summary> Gets the tone. </summary>
        public DtmfTone? Tone { get; }
    }
}
