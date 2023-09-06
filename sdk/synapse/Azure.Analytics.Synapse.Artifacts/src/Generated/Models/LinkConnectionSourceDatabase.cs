// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionSourceDatabase. </summary>
    public partial class LinkConnectionSourceDatabase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinkConnectionSourceDatabase"/>. </summary>
        public LinkConnectionSourceDatabase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkConnectionSourceDatabase"/>. </summary>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="typeProperties"> Source database type properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkConnectionSourceDatabase(LinkedServiceReference linkedService, LinkConnectionSourceDatabaseTypeProperties typeProperties, Dictionary<string, BinaryData> rawData)
        {
            LinkedService = linkedService;
            TypeProperties = typeProperties;
            _rawData = rawData;
        }

        /// <summary> Linked service reference. </summary>
        public LinkedServiceReference LinkedService { get; set; }
        /// <summary> Source database type properties. </summary>
        public LinkConnectionSourceDatabaseTypeProperties TypeProperties { get; set; }
    }
}
