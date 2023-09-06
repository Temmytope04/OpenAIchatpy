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

namespace Azure.Storage.Queues.Models
{
    public partial class QueueServiceProperties : IXmlSerializable, IModelSerializable<QueueServiceProperties>
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

        internal static QueueServiceProperties DeserializeQueueServiceProperties(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            QueueAnalyticsLogging logging = default;
            QueueMetrics hourMetrics = default;
            QueueMetrics minuteMetrics = default;
            IList<QueueCorsRule> cors = default;
            if (element.Element("Logging") is XElement loggingElement)
            {
                logging = QueueAnalyticsLogging.DeserializeQueueAnalyticsLogging(loggingElement);
            }
            if (element.Element("HourMetrics") is XElement hourMetricsElement)
            {
                hourMetrics = QueueMetrics.DeserializeQueueMetrics(hourMetricsElement);
            }
            if (element.Element("MinuteMetrics") is XElement minuteMetricsElement)
            {
                minuteMetrics = QueueMetrics.DeserializeQueueMetrics(minuteMetricsElement);
            }
            if (element.Element("Cors") is XElement corsElement)
            {
                var array = new List<QueueCorsRule>();
                foreach (var e in corsElement.Elements("CorsRule"))
                {
                    array.Add(QueueCorsRule.DeserializeQueueCorsRule(e));
                }
                cors = array;
            }
            return new QueueServiceProperties(logging, hourMetrics, minuteMetrics, cors, default);
        }

        BinaryData IModelSerializable<QueueServiceProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueueServiceProperties>(this, options.Format);

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

        QueueServiceProperties IModelSerializable<QueueServiceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueueServiceProperties>(this, options.Format);

            return DeserializeQueueServiceProperties(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="QueueServiceProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="QueueServiceProperties"/> to convert. </param>
        public static implicit operator RequestContent(QueueServiceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="QueueServiceProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator QueueServiceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeQueueServiceProperties(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
