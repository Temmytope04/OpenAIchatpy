﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    /// <summary> List of previewed features. </summary>
    public partial class FeatureOperationsListResult
    {
        /// <summary> Initializes a new instance of FeatureOperationsListResult. </summary>
        internal FeatureOperationsListResult()
        {
            Value = new ChangeTrackingList<FeatureData>();
        }

        /// <summary> Initializes a new instance of FeatureOperationsListResult. </summary>
        /// <param name="value"> The array of features. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal FeatureOperationsListResult(IReadOnlyList<FeatureData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array of features. </summary>
        public IReadOnlyList<FeatureData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
