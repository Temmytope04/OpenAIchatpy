// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Log location settings. </summary>
    public partial class LogLocationSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogLocationSettings"/>. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public LogLocationSettings(LinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            LinkedServiceName = linkedServiceName;
        }

        /// <summary> Initializes a new instance of <see cref="LogLocationSettings"/>. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <param name="path"> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogLocationSettings(LinkedServiceReference linkedServiceName, object path, Dictionary<string, BinaryData> rawData)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LogLocationSettings"/> for deserialization. </summary>
        internal LogLocationSettings()
        {
        }

        /// <summary> Log storage linked service reference. </summary>
        public LinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
    }
}
