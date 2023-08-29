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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FileProperty : IXmlSerializable, IModelSerializable<FileProperty>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "FileProperty");
            writer.WriteStartElement("Content-Length");
            writer.WriteValue(ContentLength);
            writer.WriteEndElement();
            if (Optional.IsDefined(CreationTime))
            {
                writer.WriteStartElement("CreationTime");
                writer.WriteValue(CreationTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastAccessTime))
            {
                writer.WriteStartElement("LastAccessTime");
                writer.WriteValue(LastAccessTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastWriteTime))
            {
                writer.WriteStartElement("LastWriteTime");
                writer.WriteValue(LastWriteTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ChangeTime))
            {
                writer.WriteStartElement("ChangeTime");
                writer.WriteValue(ChangeTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastModified))
            {
                writer.WriteStartElement("Last-Modified");
                writer.WriteValue(LastModified.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WriteStartElement("Etag");
                writer.WriteValue(Etag);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static FileProperty DeserializeFileProperty(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            long contentLength = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? lastAccessTime = default;
            DateTimeOffset? lastWriteTime = default;
            DateTimeOffset? changeTime = default;
            DateTimeOffset? lastModified = default;
            string etag = default;
            if (element.Element("Content-Length") is XElement contentLengthElement)
            {
                contentLength = (long)contentLengthElement;
            }
            if (element.Element("CreationTime") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("LastAccessTime") is XElement lastAccessTimeElement)
            {
                lastAccessTime = lastAccessTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("LastWriteTime") is XElement lastWriteTimeElement)
            {
                lastWriteTime = lastWriteTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("ChangeTime") is XElement changeTimeElement)
            {
                changeTime = changeTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                etag = (string)etagElement;
            }
            return new FileProperty(contentLength, creationTime, lastAccessTime, lastWriteTime, changeTime, lastModified, etag, default);
        }

        BinaryData IModelSerializable<FileProperty>.Serialize(ModelSerializerOptions options)
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

        FileProperty IModelSerializable<FileProperty>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeFileProperty(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(FileProperty model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator FileProperty(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeFileProperty(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
