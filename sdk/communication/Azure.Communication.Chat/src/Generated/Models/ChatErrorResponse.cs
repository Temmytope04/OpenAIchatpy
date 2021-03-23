// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Chat
{
    /// <summary> The Communication Services error. </summary>
    internal partial class ChatErrorResponse
    {
        /// <summary> Initializes a new instance of ChatErrorResponse. </summary>
        /// <param name="error"> The Communication Services error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ChatErrorResponse(ChatError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> The Communication Services error. </summary>
        public ChatError Error { get; }
    }
}
