// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.Xml.Linq;

namespace Azure.Storage.Blobs.Models
{
    public partial struct BlobBlock
    {
        internal static BlobBlock DeserializeBlobBlock(XElement element, ModelReaderWriterOptions options = null)
        {
            string name = default;
            long sizeLong = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("Size") is XElement sizeElement)
            {
                sizeLong = (long)sizeElement;
            }
            return new BlobBlock(name, sizeLong);
        }
    }
}
