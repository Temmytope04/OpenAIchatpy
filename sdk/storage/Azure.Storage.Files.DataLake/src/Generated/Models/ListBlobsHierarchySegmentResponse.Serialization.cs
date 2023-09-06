// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class ListBlobsHierarchySegmentResponse : IXmlSerializable, IModelSerializable<ListBlobsHierarchySegmentResponse>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "EnumerationResults");
            writer.WriteStartAttribute("ServiceEndpoint");
            writer.WriteValue(ServiceEndpoint);
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("ContainerName");
            writer.WriteValue(ContainerName);
            writer.WriteEndAttribute();
            if (Optional.IsDefined(Prefix))
            {
                writer.WriteStartElement("Prefix");
                writer.WriteValue(Prefix);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Marker))
            {
                writer.WriteStartElement("Marker");
                writer.WriteValue(Marker);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(MaxResults))
            {
                writer.WriteStartElement("MaxResults");
                writer.WriteValue(MaxResults.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Delimiter))
            {
                writer.WriteStartElement("Delimiter");
                writer.WriteValue(Delimiter);
                writer.WriteEndElement();
            }
            writer.WriteObjectValue(Segment, "Blobs");
            if (Optional.IsDefined(NextMarker))
            {
                writer.WriteStartElement("NextMarker");
                writer.WriteValue(NextMarker);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static ListBlobsHierarchySegmentResponse DeserializeListBlobsHierarchySegmentResponse(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
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
            return new ListBlobsHierarchySegmentResponse(serviceEndpoint, containerName, prefix, marker, maxResults, delimiter, segment, nextMarker, default);
        }

        BinaryData IModelSerializable<ListBlobsHierarchySegmentResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListBlobsHierarchySegmentResponse>(this, options.Format);

            options ??= ModelSerializerOptions.DefaultWireOptions;
            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            Serialize(writer, null, options);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        ListBlobsHierarchySegmentResponse IModelSerializable<ListBlobsHierarchySegmentResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListBlobsHierarchySegmentResponse>(this, options.Format);

            return DeserializeListBlobsHierarchySegmentResponse(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="ListBlobsHierarchySegmentResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListBlobsHierarchySegmentResponse"/> to convert. </param>
        public static implicit operator RequestContent(ListBlobsHierarchySegmentResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListBlobsHierarchySegmentResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListBlobsHierarchySegmentResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeListBlobsHierarchySegmentResponse(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
