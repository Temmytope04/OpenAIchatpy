// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Application type update request. </summary>
    public partial class ServiceFabricManagedApplicationTypePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedApplicationTypePatch"/>. </summary>
        public ServiceFabricManagedApplicationTypePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedApplicationTypePatch"/>. </summary>
        /// <param name="tags"> Application type update parameters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricManagedApplicationTypePatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Application type update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
