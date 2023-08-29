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
    public partial class SendReceipt : IXmlSerializable, IModelSerializable<SendReceipt>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "QueueMessage");
            writer.WriteStartElement("MessageId");
            writer.WriteValue(MessageId);
            writer.WriteEndElement();
            writer.WriteStartElement("InsertionTime");
            writer.WriteValue(InsertionTime, "R");
            writer.WriteEndElement();
            writer.WriteStartElement("ExpirationTime");
            writer.WriteValue(ExpirationTime, "R");
            writer.WriteEndElement();
            writer.WriteStartElement("PopReceipt");
            writer.WriteValue(PopReceipt);
            writer.WriteEndElement();
            writer.WriteStartElement("TimeNextVisible");
            writer.WriteValue(TimeNextVisible, "R");
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static SendReceipt DeserializeSendReceipt(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string messageId = default;
            DateTimeOffset insertionTime = default;
            DateTimeOffset expirationTime = default;
            string popReceipt = default;
            DateTimeOffset timeNextVisible = default;
            if (element.Element("MessageId") is XElement messageIdElement)
            {
                messageId = (string)messageIdElement;
            }
            if (element.Element("InsertionTime") is XElement insertionTimeElement)
            {
                insertionTime = insertionTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("ExpirationTime") is XElement expirationTimeElement)
            {
                expirationTime = expirationTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("PopReceipt") is XElement popReceiptElement)
            {
                popReceipt = (string)popReceiptElement;
            }
            if (element.Element("TimeNextVisible") is XElement timeNextVisibleElement)
            {
                timeNextVisible = timeNextVisibleElement.GetDateTimeOffsetValue("R");
            }
            return new SendReceipt(messageId, insertionTime, expirationTime, popReceipt, timeNextVisible, default);
        }

        BinaryData IModelSerializable<SendReceipt>.Serialize(ModelSerializerOptions options)
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

        SendReceipt IModelSerializable<SendReceipt>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeSendReceipt(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(SendReceipt model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SendReceipt(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeSendReceipt(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
