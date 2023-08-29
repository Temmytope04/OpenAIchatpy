// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input to apply recovery point. </summary>
    public partial class SiteRecoveryApplyRecoveryPointContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplyRecoveryPointContent"/>. </summary>
        /// <param name="properties"> The input properties to apply recovery point. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryApplyRecoveryPointContent(SiteRecoveryApplyRecoveryPointProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplyRecoveryPointContent"/>. </summary>
        /// <param name="properties"> The input properties to apply recovery point. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryApplyRecoveryPointContent(SiteRecoveryApplyRecoveryPointProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplyRecoveryPointContent"/> for deserialization. </summary>
        internal SiteRecoveryApplyRecoveryPointContent()
        {
        }

        /// <summary> The input properties to apply recovery point. </summary>
        public SiteRecoveryApplyRecoveryPointProperties Properties { get; }
    }
}
