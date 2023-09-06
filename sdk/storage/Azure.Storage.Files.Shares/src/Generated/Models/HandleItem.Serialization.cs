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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class HandleItem : IXmlSerializable, IModelSerializable<HandleItem>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Handle");
            writer.WriteStartElement("HandleId");
            writer.WriteValue(HandleId);
            writer.WriteEndElement();
            writer.WriteObjectValue(Path, "Path");
            writer.WriteStartElement("FileId");
            writer.WriteValue(FileId);
            writer.WriteEndElement();
            if (Optional.IsDefined(ParentId))
            {
                writer.WriteStartElement("ParentId");
                writer.WriteValue(ParentId);
                writer.WriteEndElement();
            }
            writer.WriteStartElement("SessionId");
            writer.WriteValue(SessionId);
            writer.WriteEndElement();
            writer.WriteStartElement("ClientIp");
            writer.WriteValue(ClientIp);
            writer.WriteEndElement();
            writer.WriteStartElement("OpenTime");
            writer.WriteValue(OpenTime, "R");
            writer.WriteEndElement();
            if (Optional.IsDefined(LastReconnectTime))
            {
                writer.WriteStartElement("LastReconnectTime");
                writer.WriteValue(LastReconnectTime.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsCollectionDefined(AccessRightList))
            {
                writer.WriteStartElement("AccessRightList");
                foreach (var item in AccessRightList)
                {
                    writer.WriteStartElement("AccessRight");
                    writer.WriteValue(item.ToSerialString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static HandleItem DeserializeHandleItem(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string handleId = default;
            StringEncoded path = default;
            string fileId = default;
            string parentId = default;
            string sessionId = default;
            string clientIp = default;
            DateTimeOffset openTime = default;
            DateTimeOffset? lastReconnectTime = default;
            IReadOnlyList<AccessRight> accessRightList = default;
            if (element.Element("HandleId") is XElement handleIdElement)
            {
                handleId = (string)handleIdElement;
            }
            if (element.Element("Path") is XElement pathElement)
            {
                path = StringEncoded.DeserializeStringEncoded(pathElement);
            }
            if (element.Element("FileId") is XElement fileIdElement)
            {
                fileId = (string)fileIdElement;
            }
            if (element.Element("ParentId") is XElement parentIdElement)
            {
                parentId = (string)parentIdElement;
            }
            if (element.Element("SessionId") is XElement sessionIdElement)
            {
                sessionId = (string)sessionIdElement;
            }
            if (element.Element("ClientIp") is XElement clientIpElement)
            {
                clientIp = (string)clientIpElement;
            }
            if (element.Element("OpenTime") is XElement openTimeElement)
            {
                openTime = openTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("LastReconnectTime") is XElement lastReconnectTimeElement)
            {
                lastReconnectTime = lastReconnectTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("AccessRightList") is XElement accessRightListElement)
            {
                var array = new List<AccessRight>();
                foreach (var e in accessRightListElement.Elements("AccessRight"))
                {
                    array.Add(e.Value.ToAccessRight());
                }
                accessRightList = array;
            }
            return new HandleItem(handleId, path, fileId, parentId, sessionId, clientIp, openTime, lastReconnectTime, accessRightList, default);
        }

        BinaryData IModelSerializable<HandleItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HandleItem>(this, options.Format);

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

        HandleItem IModelSerializable<HandleItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HandleItem>(this, options.Format);

            return DeserializeHandleItem(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="HandleItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HandleItem"/> to convert. </param>
        public static implicit operator RequestContent(HandleItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HandleItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HandleItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeHandleItem(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
