// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Update for service health event. </summary>
    public partial class ResourceHealthEventUpdate
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventUpdate"/>. </summary>
        internal ResourceHealthEventUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventUpdate"/>. </summary>
        /// <param name="summary"> Summary text for the given update for the service health event. </param>
        /// <param name="updatedOn"> It provides the Timestamp for the given update for the service health event. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthEventUpdate(string summary, DateTimeOffset? updatedOn, Dictionary<string, BinaryData> rawData)
        {
            Summary = summary;
            UpdatedOn = updatedOn;
            _rawData = rawData;
        }

        /// <summary> Summary text for the given update for the service health event. </summary>
        public string Summary { get; }
        /// <summary> It provides the Timestamp for the given update for the service health event. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
