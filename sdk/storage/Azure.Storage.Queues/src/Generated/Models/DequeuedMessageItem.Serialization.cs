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
    internal partial class DequeuedMessageItem : IXmlSerializable, IModelSerializable<DequeuedMessageItem>
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
            writer.WriteStartElement("DequeueCount");
            writer.WriteValue(DequeueCount);
            writer.WriteEndElement();
            writer.WriteStartElement("MessageText");
            writer.WriteValue(MessageText);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static DequeuedMessageItem DeserializeDequeuedMessageItem(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string messageId = default;
            DateTimeOffset insertionTime = default;
            DateTimeOffset expirationTime = default;
            string popReceipt = default;
            DateTimeOffset timeNextVisible = default;
            long dequeueCount = default;
            string messageText = default;
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
            if (element.Element("DequeueCount") is XElement dequeueCountElement)
            {
                dequeueCount = (long)dequeueCountElement;
            }
            if (element.Element("MessageText") is XElement messageTextElement)
            {
                messageText = (string)messageTextElement;
            }
            return new DequeuedMessageItem(messageId, insertionTime, expirationTime, popReceipt, timeNextVisible, dequeueCount, messageText, default);
        }

        BinaryData IModelSerializable<DequeuedMessageItem>.Serialize(ModelSerializerOptions options)
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

        DequeuedMessageItem IModelSerializable<DequeuedMessageItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeDequeuedMessageItem(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(DequeuedMessageItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DequeuedMessageItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeDequeuedMessageItem(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
