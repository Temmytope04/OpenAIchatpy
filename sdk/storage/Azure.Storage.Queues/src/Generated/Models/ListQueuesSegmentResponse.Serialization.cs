// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;

namespace Azure.Storage.Queues.Models
{
    internal partial class ListQueuesSegmentResponse
    {
        internal static ListQueuesSegmentResponse DeserializeListQueuesSegmentResponse(XElement element)
        {
            string serviceEndpoint = default;
            string prefix = default;
            string marker = default;
            int maxResults = default;
            string nextMarker = default;
            IReadOnlyList<QueueItem> queueItems = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
            }
            if (element.Element("Prefix") is XElement prefixElement)
            {
                prefix = (string)prefixElement;
            }
            if (element.Element("Marker") is XElement markerElement)
            {
                marker = (string)markerElement;
            }
            if (element.Element("MaxResults") is XElement maxResultsElement)
            {
                maxResults = (int)maxResultsElement;
            }
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            if (element.Element("Queues") is XElement queuesElement)
            {
                var array = new List<QueueItem>();
                foreach (var e in queuesElement.Elements("Queue"))
                {
                    array.Add(QueueItem.DeserializeQueueItem(e));
                }
                queueItems = array;
            }
            return new ListQueuesSegmentResponse(serviceEndpoint, prefix, marker, maxResults, queueItems, nextMarker);
        }
    }
}
