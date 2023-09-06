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
    public partial class ShareCorsRule : IXmlSerializable, IModelSerializable<ShareCorsRule>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "CorsRule");
            writer.WriteStartElement("AllowedOrigins");
            writer.WriteValue(AllowedOrigins);
            writer.WriteEndElement();
            writer.WriteStartElement("AllowedMethods");
            writer.WriteValue(AllowedMethods);
            writer.WriteEndElement();
            writer.WriteStartElement("AllowedHeaders");
            writer.WriteValue(AllowedHeaders);
            writer.WriteEndElement();
            writer.WriteStartElement("ExposedHeaders");
            writer.WriteValue(ExposedHeaders);
            writer.WriteEndElement();
            writer.WriteStartElement("MaxAgeInSeconds");
            writer.WriteValue(MaxAgeInSeconds);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static ShareCorsRule DeserializeShareCorsRule(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string allowedOrigins = default;
            string allowedMethods = default;
            string allowedHeaders = default;
            string exposedHeaders = default;
            int maxAgeInSeconds = default;
            if (element.Element("AllowedOrigins") is XElement allowedOriginsElement)
            {
                allowedOrigins = (string)allowedOriginsElement;
            }
            if (element.Element("AllowedMethods") is XElement allowedMethodsElement)
            {
                allowedMethods = (string)allowedMethodsElement;
            }
            if (element.Element("AllowedHeaders") is XElement allowedHeadersElement)
            {
                allowedHeaders = (string)allowedHeadersElement;
            }
            if (element.Element("ExposedHeaders") is XElement exposedHeadersElement)
            {
                exposedHeaders = (string)exposedHeadersElement;
            }
            if (element.Element("MaxAgeInSeconds") is XElement maxAgeInSecondsElement)
            {
                maxAgeInSeconds = (int)maxAgeInSecondsElement;
            }
            return new ShareCorsRule(allowedOrigins, allowedMethods, allowedHeaders, exposedHeaders, maxAgeInSeconds, default);
        }

        BinaryData IModelSerializable<ShareCorsRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareCorsRule>(this, options.Format);

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

        ShareCorsRule IModelSerializable<ShareCorsRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareCorsRule>(this, options.Format);

            return DeserializeShareCorsRule(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="ShareCorsRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ShareCorsRule"/> to convert. </param>
        public static implicit operator RequestContent(ShareCorsRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ShareCorsRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ShareCorsRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeShareCorsRule(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
