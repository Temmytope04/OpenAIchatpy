// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The response from the check name availability request. </summary>
    public partial class MediaServicesNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaServicesNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Specifies if the name is available. </param>
        internal MediaServicesNameAvailabilityResult(bool isNameAvailable)
        {
            IsNameAvailable = isNameAvailable;
        }

        /// <summary> Initializes a new instance of <see cref="MediaServicesNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Specifies if the name is available. </param>
        /// <param name="reason"> Specifies the reason if the name is not available. </param>
        /// <param name="message"> Specifies the detailed reason if the name is not available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaServicesNameAvailabilityResult(bool isNameAvailable, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaServicesNameAvailabilityResult"/> for deserialization. </summary>
        internal MediaServicesNameAvailabilityResult()
        {
        }

        /// <summary> Specifies if the name is available. </summary>
        public bool IsNameAvailable { get; }
        /// <summary> Specifies the reason if the name is not available. </summary>
        public string Reason { get; }
        /// <summary> Specifies the detailed reason if the name is not available. </summary>
        public string Message { get; }
    }
}
