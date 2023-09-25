// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;

namespace Azure.Storage.Blobs.Models
{
    internal partial class ListBlobsHierarchySegmentResponse
    {
        internal static ListBlobsHierarchySegmentResponse DeserializeListBlobsHierarchySegmentResponse(XElement element)
        {
            string serviceEndpoint = default;
            string containerName = default;
            string prefix = default;
            string marker = default;
            int? maxResults = default;
            string delimiter = default;
            BlobHierarchyListSegment segment = default;
            string nextMarker = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
            }
            if (element.Attribute("ContainerName") is XAttribute containerNameAttribute)
            {
                containerName = (string)containerNameAttribute;
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
                maxResults = (int?)maxResultsElement;
            }
            if (element.Element("Delimiter") is XElement delimiterElement)
            {
                delimiter = (string)delimiterElement;
            }
            if (element.Element("Blobs") is XElement blobsElement)
            {
                segment = BlobHierarchyListSegment.DeserializeBlobHierarchyListSegment(blobsElement);
            }
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            return new ListBlobsHierarchySegmentResponse(serviceEndpoint, containerName, prefix, marker, maxResults, delimiter, segment, nextMarker);
        }
    }
}
