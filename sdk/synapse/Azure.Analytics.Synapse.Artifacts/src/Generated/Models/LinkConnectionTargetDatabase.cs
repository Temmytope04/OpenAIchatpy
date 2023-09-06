// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionTargetDatabase. </summary>
    public partial class LinkConnectionTargetDatabase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinkConnectionTargetDatabase"/>. </summary>
        public LinkConnectionTargetDatabase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkConnectionTargetDatabase"/>. </summary>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="typeProperties"> Target database type properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkConnectionTargetDatabase(LinkedServiceReference linkedService, LinkConnectionTargetDatabaseTypeProperties typeProperties, Dictionary<string, BinaryData> rawData)
        {
            LinkedService = linkedService;
            TypeProperties = typeProperties;
            _rawData = rawData;
        }

        /// <summary> Linked service reference. </summary>
        public LinkedServiceReference LinkedService { get; set; }
        /// <summary> Target database type properties. </summary>
        public LinkConnectionTargetDatabaseTypeProperties TypeProperties { get; set; }
    }
}
