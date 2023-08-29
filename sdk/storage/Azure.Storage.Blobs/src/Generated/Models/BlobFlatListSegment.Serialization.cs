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
    internal partial class BlobFlatListSegment : IXmlSerializable, IModelSerializable<BlobFlatListSegment>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Blobs");
            foreach (var item in BlobItems)
            {
                writer.WriteObjectValue(item, "Blob");
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobFlatListSegment DeserializeBlobFlatListSegment(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            IReadOnlyList<BlobItemInternal> blobItems = default;
            var array = new List<BlobItemInternal>();
            foreach (var e in element.Elements("Blob"))
            {
                array.Add(BlobItemInternal.DeserializeBlobItemInternal(e));
            }
            blobItems = array;
            return new BlobFlatListSegment(blobItems, default);
        }

        BinaryData IModelSerializable<BlobFlatListSegment>.Serialize(ModelSerializerOptions options)
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

        BlobFlatListSegment IModelSerializable<BlobFlatListSegment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeBlobFlatListSegment(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(BlobFlatListSegment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BlobFlatListSegment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobFlatListSegment(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
