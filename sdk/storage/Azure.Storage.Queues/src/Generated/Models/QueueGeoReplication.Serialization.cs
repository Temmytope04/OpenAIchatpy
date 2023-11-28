// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueGeoReplication
    {
        internal static QueueGeoReplication DeserializeQueueGeoReplication(XElement element, ModelReaderWriterOptions options = null)
        {
            QueueGeoReplicationStatus status = default;
            DateTimeOffset? lastSyncedOn = default;
            if (element.Element("Status") is XElement statusElement)
            {
                status = statusElement.Value.ToQueueGeoReplicationStatus();
            }
            if (element.Element("LastSyncTime") is XElement lastSyncTimeElement)
            {
                lastSyncedOn = lastSyncTimeElement.GetDateTimeOffsetValue("R");
            }
            return new QueueGeoReplication(status, lastSyncedOn);
        }
    }
}
