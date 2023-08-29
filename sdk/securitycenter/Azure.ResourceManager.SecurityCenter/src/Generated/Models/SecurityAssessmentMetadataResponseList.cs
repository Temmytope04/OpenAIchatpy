// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of security assessment metadata. </summary>
    internal partial class SecurityAssessmentMetadataResponseList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentMetadataResponseList"/>. </summary>
        internal SecurityAssessmentMetadataResponseList()
        {
            Value = new ChangeTrackingList<SecurityAssessmentMetadataData>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentMetadataResponseList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAssessmentMetadataResponseList(IReadOnlyList<SecurityAssessmentMetadataData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecurityAssessmentMetadataData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
