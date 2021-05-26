﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.ResourceManager.Core
{
    /// <summary> Information about feature. </summary>
    public partial class FeatureProperties
    {
        /// <summary> Initializes a new instance of FeatureProperties. </summary>
        internal FeatureProperties()
        {
        }

        /// <summary> Initializes a new instance of FeatureProperties. </summary>
        /// <param name="state"> The registration state of the feature for the subscription. </param>
        internal FeatureProperties(string state)
        {
            State = state;
        }

        /// <summary> The registration state of the feature for the subscription. </summary>
        public string State { get; }
    }
}
