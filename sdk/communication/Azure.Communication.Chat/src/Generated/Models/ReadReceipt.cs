// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Chat
{
    /// <summary> A read receipt indicates the time a chat message was read by a recipient. </summary>
    public partial class ReadReceipt
    {
        /// <summary> Initializes a new instance of ReadReceipt. </summary>
        internal ReadReceipt()
        {
        }
        /// <summary> Id for the chat message that has been read. This id is generated by the server. </summary>
        public string ChatMessageId { get; }
        /// <summary> Read receipt timestamp. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? ReadOn { get; }
    }
}
