// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Resource log category configuration of a Microsoft.SignalRService resource. </summary>
    public partial class ResourceLogCategory
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceLogCategory"/>. </summary>
        public ResourceLogCategory()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceLogCategory"/>. </summary>
        /// <param name="name">
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceLogCategory(string name, string enabled, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Enabled = enabled;
            _rawData = rawData;
        }

        /// <summary>
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </summary>
        public string Enabled { get; set; }
    }
}
