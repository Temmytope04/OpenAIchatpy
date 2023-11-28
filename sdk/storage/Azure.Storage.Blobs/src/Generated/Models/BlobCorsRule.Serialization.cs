// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobCorsRule : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "CorsRule");
            writer.WriteStartElement("AllowedOrigins");
            writer.WriteValue(AllowedOrigins);
            writer.WriteEndElement();
            writer.WriteStartElement("AllowedMethods");
            writer.WriteValue(AllowedMethods);
            writer.WriteEndElement();
            writer.WriteStartElement("AllowedHeaders");
            writer.WriteValue(AllowedHeaders);
            writer.WriteEndElement();
            writer.WriteStartElement("ExposedHeaders");
            writer.WriteValue(ExposedHeaders);
            writer.WriteEndElement();
            writer.WriteStartElement("MaxAgeInSeconds");
            writer.WriteValue(MaxAgeInSeconds);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal static BlobCorsRule DeserializeBlobCorsRule(XElement element, ModelReaderWriterOptions options = null)
        {
            string allowedOrigins = default;
            string allowedMethods = default;
            string allowedHeaders = default;
            string exposedHeaders = default;
            int maxAgeInSeconds = default;
            if (element.Element("AllowedOrigins") is XElement allowedOriginsElement)
            {
                allowedOrigins = (string)allowedOriginsElement;
            }
            if (element.Element("AllowedMethods") is XElement allowedMethodsElement)
            {
                allowedMethods = (string)allowedMethodsElement;
            }
            if (element.Element("AllowedHeaders") is XElement allowedHeadersElement)
            {
                allowedHeaders = (string)allowedHeadersElement;
            }
            if (element.Element("ExposedHeaders") is XElement exposedHeadersElement)
            {
                exposedHeaders = (string)exposedHeadersElement;
            }
            if (element.Element("MaxAgeInSeconds") is XElement maxAgeInSecondsElement)
            {
                maxAgeInSeconds = (int)maxAgeInSecondsElement;
            }
            return new BlobCorsRule(allowedOrigins, allowedMethods, allowedHeaders, exposedHeaders, maxAgeInSeconds);
        }
    }
}
