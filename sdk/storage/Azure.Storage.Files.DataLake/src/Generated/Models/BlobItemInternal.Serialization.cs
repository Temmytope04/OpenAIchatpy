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
    internal partial class BlobItemInternal : IXmlSerializable, IModelSerializable<BlobItemInternal>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Blob");
            writer.WriteStartElement("Name");
            writer.WriteValue(Name);
            writer.WriteEndElement();
            writer.WriteStartElement("Deleted");
            writer.WriteValue(Deleted);
            writer.WriteEndElement();
            writer.WriteStartElement("Snapshot");
            writer.WriteValue(Snapshot);
            writer.WriteEndElement();
            if (Optional.IsDefined(VersionId))
            {
                writer.WriteStartElement("VersionId");
                writer.WriteValue(VersionId);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(IsCurrentVersion))
            {
                writer.WriteStartElement("IsCurrentVersion");
                writer.WriteValue(IsCurrentVersion.Value);
                writer.WriteEndElement();
            }
            writer.WriteObjectValue(Properties, "Properties");
            if (Optional.IsDefined(DeletionId))
            {
                writer.WriteStartElement("DeletionId");
                writer.WriteValue(DeletionId);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobItemInternal DeserializeBlobItemInternal(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string name = default;
            bool deleted = default;
            string snapshot = default;
            string versionId = default;
            bool? isCurrentVersion = default;
            BlobPropertiesInternal properties = default;
            string deletionId = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("Deleted") is XElement deletedElement)
            {
                deleted = (bool)deletedElement;
            }
            if (element.Element("Snapshot") is XElement snapshotElement)
            {
                snapshot = (string)snapshotElement;
            }
            if (element.Element("VersionId") is XElement versionIdElement)
            {
                versionId = (string)versionIdElement;
            }
            if (element.Element("IsCurrentVersion") is XElement isCurrentVersionElement)
            {
                isCurrentVersion = (bool?)isCurrentVersionElement;
            }
            if (element.Element("Properties") is XElement propertiesElement)
            {
                properties = BlobPropertiesInternal.DeserializeBlobPropertiesInternal(propertiesElement);
            }
            if (element.Element("DeletionId") is XElement deletionIdElement)
            {
                deletionId = (string)deletionIdElement;
            }
            return new BlobItemInternal(name, deleted, snapshot, versionId, isCurrentVersion, properties, deletionId, default);
        }

        BinaryData IModelSerializable<BlobItemInternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobItemInternal>(this, options.Format);

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

        BlobItemInternal IModelSerializable<BlobItemInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobItemInternal>(this, options.Format);

            return DeserializeBlobItemInternal(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="BlobItemInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BlobItemInternal"/> to convert. </param>
        public static implicit operator RequestContent(BlobItemInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BlobItemInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BlobItemInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobItemInternal(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
