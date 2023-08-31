// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> The list of detected changes. </summary>
    internal partial class ChangeList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ChangeList"/>. </summary>
        internal ChangeList()
        {
            Value = new ChangeTrackingList<DetectedChangeData>();
        }

        /// <summary> Initializes a new instance of <see cref="ChangeList"/>. </summary>
        /// <param name="value"> The list of changes. </param>
        /// <param name="nextLink"> The URI that can be used to request the next page of changes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ChangeList(IReadOnlyList<DetectedChangeData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of changes. </summary>
        public IReadOnlyList<DetectedChangeData> Value { get; }
        /// <summary> The URI that can be used to request the next page of changes. </summary>
        public string NextLink { get; }
    }
}
