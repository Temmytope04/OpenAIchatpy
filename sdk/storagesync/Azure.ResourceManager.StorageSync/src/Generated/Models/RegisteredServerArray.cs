// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of RegisteredServer. </summary>
    internal partial class RegisteredServerArray
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RegisteredServerArray"/>. </summary>
        internal RegisteredServerArray()
        {
            Value = new ChangeTrackingList<StorageSyncRegisteredServerData>();
        }

        /// <summary> Initializes a new instance of <see cref="RegisteredServerArray"/>. </summary>
        /// <param name="value"> Collection of Registered Server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RegisteredServerArray(IReadOnlyList<StorageSyncRegisteredServerData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Collection of Registered Server. </summary>
        public IReadOnlyList<StorageSyncRegisteredServerData> Value { get; }
    }
}
