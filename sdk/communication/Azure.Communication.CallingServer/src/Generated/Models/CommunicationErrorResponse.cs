// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> The Communication Services error response. </summary>
    internal partial class CommunicationErrorResponse
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/>. </summary>
        /// <param name="error"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal CommunicationErrorResponse(CommunicationError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> Gets the error. </summary>
        public CommunicationError Error { get; }
    }
}
