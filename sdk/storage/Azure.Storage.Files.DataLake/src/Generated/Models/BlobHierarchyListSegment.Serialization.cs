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

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class BlobHierarchyListSegment : IXmlSerializable, IModelSerializable<BlobHierarchyListSegment>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Blobs");
            if (Optional.IsCollectionDefined(BlobPrefixes))
            {
                foreach (var item in BlobPrefixes)
                {
                    writer.WriteObjectValue(item, "BlobPrefix");
                }
            }
            foreach (var item in BlobItems)
            {
                writer.WriteObjectValue(item, "Blob");
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobHierarchyListSegment DeserializeBlobHierarchyListSegment(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            IReadOnlyList<BlobPrefix> blobPrefixes = default;
            IReadOnlyList<BlobItemInternal> blobItems = default;
            var array = new List<BlobPrefix>();
            foreach (var e in element.Elements("BlobPrefix"))
            {
                array.Add(BlobPrefix.DeserializeBlobPrefix(e));
            }
            blobPrefixes = array;
            var array0 = new List<BlobItemInternal>();
            foreach (var e in element.Elements("Blob"))
            {
                array0.Add(BlobItemInternal.DeserializeBlobItemInternal(e));
            }
            blobItems = array0;
            return new BlobHierarchyListSegment(blobPrefixes, blobItems, default);
        }

        BinaryData IModelSerializable<BlobHierarchyListSegment>.Serialize(ModelSerializerOptions options)
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

        BlobHierarchyListSegment IModelSerializable<BlobHierarchyListSegment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeBlobHierarchyListSegment(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(BlobHierarchyListSegment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BlobHierarchyListSegment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobHierarchyListSegment(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
