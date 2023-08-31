// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for sending a read receipt. </summary>
    internal partial class SendReadReceiptRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SendReadReceiptRequest"/>. </summary>
        /// <param name="chatMessageId"> Id of the latest chat message read by the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatMessageId"/> is null. </exception>
        public SendReadReceiptRequest(string chatMessageId)
        {
            Argument.AssertNotNull(chatMessageId, nameof(chatMessageId));

            ChatMessageId = chatMessageId;
        }

        /// <summary> Initializes a new instance of <see cref="SendReadReceiptRequest"/>. </summary>
        /// <param name="chatMessageId"> Id of the latest chat message read by the user. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SendReadReceiptRequest(string chatMessageId, Dictionary<string, BinaryData> rawData)
        {
            ChatMessageId = chatMessageId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SendReadReceiptRequest"/> for deserialization. </summary>
        internal SendReadReceiptRequest()
        {
        }

        /// <summary> Id of the latest chat message read by the user. </summary>
        public string ChatMessageId { get; }
    }
}
