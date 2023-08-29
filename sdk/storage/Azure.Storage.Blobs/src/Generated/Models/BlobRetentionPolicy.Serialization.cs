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

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobRetentionPolicy : IXmlSerializable, IModelSerializable<BlobRetentionPolicy>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "RetentionPolicy");
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Optional.IsDefined(Days))
            {
                writer.WriteStartElement("Days");
                writer.WriteValue(Days.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(AllowPermanentDelete))
            {
                writer.WriteStartElement("AllowPermanentDelete");
                writer.WriteValue(AllowPermanentDelete.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobRetentionPolicy DeserializeBlobRetentionPolicy(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            bool enabled = default;
            int? days = default;
            bool? allowPermanentDelete = default;
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("Days") is XElement daysElement)
            {
                days = (int?)daysElement;
            }
            if (element.Element("AllowPermanentDelete") is XElement allowPermanentDeleteElement)
            {
                allowPermanentDelete = (bool?)allowPermanentDeleteElement;
            }
            return new BlobRetentionPolicy(enabled, days, allowPermanentDelete, default);
        }

        BinaryData IModelSerializable<BlobRetentionPolicy>.Serialize(ModelSerializerOptions options)
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

        BlobRetentionPolicy IModelSerializable<BlobRetentionPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeBlobRetentionPolicy(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(BlobRetentionPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BlobRetentionPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobRetentionPolicy(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
