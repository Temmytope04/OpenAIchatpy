// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary>
    /// Arm async operation class.
    /// Ref: https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/async-operations.
    /// </summary>
    public partial class ArmAsyncOperation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ArmAsyncOperation"/>. </summary>
        internal ArmAsyncOperation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmAsyncOperation"/>. </summary>
        /// <param name="status"> Status of the async operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmAsyncOperation(string status, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Status of the async operation. </summary>
        public string Status { get; }
    }
}
