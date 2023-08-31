// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for updating a chat thread. </summary>
    internal partial class UpdateChatThreadRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UpdateChatThreadRequest"/>. </summary>
        public UpdateChatThreadRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateChatThreadRequest"/>. </summary>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateChatThreadRequest(string topic, Dictionary<string, BinaryData> rawData)
        {
            Topic = topic;
            _rawData = rawData;
        }

        /// <summary> Chat thread topic. </summary>
        public string Topic { get; set; }
    }
}
