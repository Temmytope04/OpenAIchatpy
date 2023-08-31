// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecuritySolutionsReferenceDataList. </summary>
    internal partial class SecuritySolutionsReferenceDataList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionsReferenceDataList"/>. </summary>
        internal SecuritySolutionsReferenceDataList()
        {
            Value = new ChangeTrackingList<SecuritySolutionsReferenceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionsReferenceDataList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySolutionsReferenceDataList(IReadOnlyList<SecuritySolutionsReferenceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecuritySolutionsReferenceData> Value { get; }
    }
}
