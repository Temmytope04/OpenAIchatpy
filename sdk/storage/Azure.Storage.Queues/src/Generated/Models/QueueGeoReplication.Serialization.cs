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

namespace Azure.Storage.Queues.Models
{
    public partial class QueueGeoReplication : IXmlSerializable, IModelSerializable<QueueGeoReplication>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "GeoReplication");
            writer.WriteStartElement("Status");
            writer.WriteValue(Status.ToSerialString());
            writer.WriteEndElement();
            if (LastSyncedOn != null)
            {
                writer.WriteStartElement("LastSyncTime");
                writer.WriteValue(LastSyncedOn.Value, "R");
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static QueueGeoReplication DeserializeQueueGeoReplication(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
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
            return new QueueGeoReplication(status, lastSyncedOn, default);
        }

        BinaryData IModelSerializable<QueueGeoReplication>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueueGeoReplication>(this, options.Format);

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

        QueueGeoReplication IModelSerializable<QueueGeoReplication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueueGeoReplication>(this, options.Format);

            return DeserializeQueueGeoReplication(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="QueueGeoReplication"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="QueueGeoReplication"/> to convert. </param>
        public static implicit operator RequestContent(QueueGeoReplication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="QueueGeoReplication"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator QueueGeoReplication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeQueueGeoReplication(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
