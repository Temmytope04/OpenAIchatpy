// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class BlockLookupList : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "BlockList");
            if (Optional.IsCollectionDefined(Committed))
            {
                foreach (var item in Committed)
                {
                    writer.WriteStartElement("Committed");
                    writer.WriteValue(item);
                    writer.WriteEndElement();
                }
            }
            if (Optional.IsCollectionDefined(Uncommitted))
            {
                foreach (var item in Uncommitted)
                {
                    writer.WriteStartElement("Uncommitted");
                    writer.WriteValue(item);
                    writer.WriteEndElement();
                }
            }
            if (Optional.IsCollectionDefined(Latest))
            {
                foreach (var item in Latest)
                {
                    writer.WriteStartElement("Latest");
                    writer.WriteValue(item);
                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();
        }
    }
}
