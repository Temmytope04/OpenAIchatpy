// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Maintenance;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Response for ApplyUpdate list. </summary>
    internal partial class MaintenanceApplyUpdateListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MaintenanceApplyUpdateListResult"/>. </summary>
        internal MaintenanceApplyUpdateListResult()
        {
            Value = new ChangeTrackingList<MaintenanceApplyUpdateData>();
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceApplyUpdateListResult"/>. </summary>
        /// <param name="value"> The list of apply updates. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceApplyUpdateListResult(IReadOnlyList<MaintenanceApplyUpdateData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of apply updates. </summary>
        public IReadOnlyList<MaintenanceApplyUpdateData> Value { get; }
    }
}
