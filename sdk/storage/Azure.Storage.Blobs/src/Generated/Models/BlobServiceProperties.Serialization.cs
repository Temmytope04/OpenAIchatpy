// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobServiceProperties : IXmlSerializable, IModelSerializable<BlobServiceProperties>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "StorageServiceProperties");
            if (Optional.IsDefined(Logging))
            {
                writer.WriteObjectValue(Logging, "Logging");
            }
            if (Optional.IsDefined(HourMetrics))
            {
                writer.WriteObjectValue(HourMetrics, "HourMetrics");
            }
            if (Optional.IsDefined(MinuteMetrics))
            {
                writer.WriteObjectValue(MinuteMetrics, "MinuteMetrics");
            }
            if (Optional.IsDefined(DefaultServiceVersion))
            {
                writer.WriteStartElement("DefaultServiceVersion");
                writer.WriteValue(DefaultServiceVersion);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(DeleteRetentionPolicy))
            {
                writer.WriteObjectValue(DeleteRetentionPolicy, "DeleteRetentionPolicy");
            }
            if (Optional.IsDefined(StaticWebsite))
            {
                writer.WriteObjectValue(StaticWebsite, "StaticWebsite");
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WriteStartElement("Cors");
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item, "CorsRule");
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobServiceProperties DeserializeBlobServiceProperties(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            BlobAnalyticsLogging logging = default;
            BlobMetrics hourMetrics = default;
            BlobMetrics minuteMetrics = default;
            string defaultServiceVersion = default;
            BlobRetentionPolicy deleteRetentionPolicy = default;
            BlobStaticWebsite staticWebsite = default;
            IList<BlobCorsRule> cors = default;
            if (element.Element("Logging") is XElement loggingElement)
            {
                logging = BlobAnalyticsLogging.DeserializeBlobAnalyticsLogging(loggingElement);
            }
            if (element.Element("HourMetrics") is XElement hourMetricsElement)
            {
                hourMetrics = BlobMetrics.DeserializeBlobMetrics(hourMetricsElement);
            }
            if (element.Element("MinuteMetrics") is XElement minuteMetricsElement)
            {
                minuteMetrics = BlobMetrics.DeserializeBlobMetrics(minuteMetricsElement);
            }
            if (element.Element("DefaultServiceVersion") is XElement defaultServiceVersionElement)
            {
                defaultServiceVersion = (string)defaultServiceVersionElement;
            }
            if (element.Element("DeleteRetentionPolicy") is XElement deleteRetentionPolicyElement)
            {
                deleteRetentionPolicy = BlobRetentionPolicy.DeserializeBlobRetentionPolicy(deleteRetentionPolicyElement);
            }
            if (element.Element("StaticWebsite") is XElement staticWebsiteElement)
            {
                staticWebsite = BlobStaticWebsite.DeserializeBlobStaticWebsite(staticWebsiteElement);
            }
            if (element.Element("Cors") is XElement corsElement)
            {
                var array = new List<BlobCorsRule>();
                foreach (var e in corsElement.Elements("CorsRule"))
                {
                    array.Add(BlobCorsRule.DeserializeBlobCorsRule(e));
                }
                cors = array;
            }
            return new BlobServiceProperties(logging, hourMetrics, minuteMetrics, cors, defaultServiceVersion, deleteRetentionPolicy, staticWebsite, default);
        }

        BinaryData IModelSerializable<BlobServiceProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        BlobServiceProperties IModelSerializable<BlobServiceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeBlobServiceProperties(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(BlobServiceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BlobServiceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobServiceProperties(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
