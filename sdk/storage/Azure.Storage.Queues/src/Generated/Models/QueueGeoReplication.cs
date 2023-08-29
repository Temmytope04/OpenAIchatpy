// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Queues.Models
{
    /// <summary> The GeoReplication. </summary>
    public partial class QueueGeoReplication
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueueGeoReplication"/>. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncedOn"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        internal QueueGeoReplication(QueueGeoReplicationStatus status, DateTimeOffset? lastSyncedOn)
        {
            Status = status;
            LastSyncedOn = lastSyncedOn;
        }

        /// <summary> Initializes a new instance of <see cref="QueueGeoReplication"/>. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncedOn"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueGeoReplication(QueueGeoReplicationStatus status, DateTimeOffset? lastSyncedOn, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            LastSyncedOn = lastSyncedOn;
            _rawData = rawData;
        }
    }
}
