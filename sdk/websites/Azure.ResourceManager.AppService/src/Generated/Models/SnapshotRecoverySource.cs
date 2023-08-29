// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Specifies the web app that snapshot contents will be retrieved from. </summary>
    public partial class SnapshotRecoverySource
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotRecoverySource"/>. </summary>
        public SnapshotRecoverySource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotRecoverySource"/>. </summary>
        /// <param name="location"> Geographical location of the source web app, e.g. SouthEastAsia, SouthCentralUS. </param>
        /// <param name="id">
        /// ARM resource ID of the source app.
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotRecoverySource(AzureLocation? location, ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Location = location;
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Geographical location of the source web app, e.g. SouthEastAsia, SouthCentralUS. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary>
        /// ARM resource ID of the source app.
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
