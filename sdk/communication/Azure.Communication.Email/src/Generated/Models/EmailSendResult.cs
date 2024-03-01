// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Email
{
    /// <summary> Status of the long running operation. </summary>
    public partial class EmailSendResult
    {
        /// <summary> Initializes a new instance of <see cref="EmailSendResult"/>. </summary>
        /// <param name="id"> The unique id of the operation. Use a UUID. </param>
        /// <param name="status"> Status of operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal EmailSendResult(string id, EmailSendStatus status)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="EmailSendResult"/>. </summary>
        /// <param name="id"> The unique id of the operation. Use a UUID. </param>
        /// <param name="status"> Status of operation. </param>
        /// <param name="error"> Error details when status is a non-success terminal state. </param>
        internal EmailSendResult(string id, EmailSendStatus status, ErrorDetail error)
        {
            Id = id;
            Status = status;
            Error = error;
        }
        /// <summary> Status of operation. </summary>
        public EmailSendStatus Status { get; }
    }
}
