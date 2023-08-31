// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownStorageAccountCustomDetails. </summary>
    internal partial class UnknownStorageAccountCustomDetails : StorageAccountCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownStorageAccountCustomDetails"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownStorageAccountCustomDetails(string resourceType, Dictionary<string, BinaryData> rawData) : base(resourceType, rawData)
        {
            ResourceType = resourceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownStorageAccountCustomDetails"/> for deserialization. </summary>
        internal UnknownStorageAccountCustomDetails()
        {
        }
    }
}
