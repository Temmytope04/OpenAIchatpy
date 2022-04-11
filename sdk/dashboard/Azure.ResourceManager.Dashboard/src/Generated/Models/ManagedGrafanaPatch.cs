// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dashboard.Models
{
    /// <summary> The parameters for a PATCH request to a grafana resource. </summary>
    public partial class ManagedGrafanaPatch
    {
        /// <summary> Initializes a new instance of ManagedGrafanaPatch. </summary>
        public ManagedGrafanaPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The managed identity of the grafana resource. </summary>
        public ManagedIdentity Identity { get; set; }
        /// <summary> The new tags of the grafana resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
