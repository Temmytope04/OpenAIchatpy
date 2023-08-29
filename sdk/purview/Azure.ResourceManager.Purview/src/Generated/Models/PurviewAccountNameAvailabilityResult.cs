// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The response payload for CheckNameAvailability API. </summary>
    public partial class PurviewAccountNameAvailabilityResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PurviewAccountNameAvailabilityResult"/>. </summary>
        internal PurviewAccountNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountNameAvailabilityResult"/>. </summary>
        /// <param name="message"> Error message. </param>
        /// <param name="isNameAvailable"> Indicates if name is valid and available. </param>
        /// <param name="reason"> The reason the name is not available. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewAccountNameAvailabilityResult(string message, bool? isNameAvailable, PurviewAccountNameUnavailableReason? reason, Dictionary<string, BinaryData> rawData)
        {
            Message = message;
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            _rawData = rawData;
        }

        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Indicates if name is valid and available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason the name is not available. </summary>
        public PurviewAccountNameUnavailableReason? Reason { get; }
    }
}
