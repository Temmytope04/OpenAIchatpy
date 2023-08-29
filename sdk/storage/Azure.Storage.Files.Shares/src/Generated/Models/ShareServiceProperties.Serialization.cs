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
    public partial class ShareServiceProperties : IXmlSerializable, IModelSerializable<ShareServiceProperties>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "StorageServiceProperties");
            if (Optional.IsDefined(HourMetrics))
            {
                writer.WriteObjectValue(HourMetrics, "HourMetrics");
            }
            if (Optional.IsDefined(MinuteMetrics))
            {
                writer.WriteObjectValue(MinuteMetrics, "MinuteMetrics");
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WriteObjectValue(Protocol, "ProtocolSettings");
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WriteStartElement("Cors");
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item, "CorsRule");
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static ShareServiceProperties DeserializeShareServiceProperties(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            ShareMetrics hourMetrics = default;
            ShareMetrics minuteMetrics = default;
            ShareProtocolSettings protocol = default;
            IList<ShareCorsRule> cors = default;
            if (element.Element("HourMetrics") is XElement hourMetricsElement)
            {
                hourMetrics = ShareMetrics.DeserializeShareMetrics(hourMetricsElement);
            }
            if (element.Element("MinuteMetrics") is XElement minuteMetricsElement)
            {
                minuteMetrics = ShareMetrics.DeserializeShareMetrics(minuteMetricsElement);
            }
            if (element.Element("ProtocolSettings") is XElement protocolSettingsElement)
            {
                protocol = ShareProtocolSettings.DeserializeShareProtocolSettings(protocolSettingsElement);
            }
            if (element.Element("Cors") is XElement corsElement)
            {
                var array = new List<ShareCorsRule>();
                foreach (var e in corsElement.Elements("CorsRule"))
                {
                    array.Add(ShareCorsRule.DeserializeShareCorsRule(e));
                }
                cors = array;
            }
            return new ShareServiceProperties(hourMetrics, minuteMetrics, cors, protocol, default);
        }

        BinaryData IModelSerializable<ShareServiceProperties>.Serialize(ModelSerializerOptions options)
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

        ShareServiceProperties IModelSerializable<ShareServiceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return DeserializeShareServiceProperties(XElement.Load(data.ToStream()), options);
        }

        public static implicit operator RequestContent(ShareServiceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ShareServiceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeShareServiceProperties(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
