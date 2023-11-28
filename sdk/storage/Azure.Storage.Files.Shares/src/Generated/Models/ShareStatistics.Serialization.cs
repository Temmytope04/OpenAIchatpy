// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.Xml.Linq;

namespace Azure.Storage.Files.Shares.Models
{
    public partial class ShareStatistics
    {
        internal static ShareStatistics DeserializeShareStatistics(XElement element, ModelReaderWriterOptions options = null)
        {
            int shareUsageBytes = default;
            if (element.Element("ShareUsageBytes") is XElement shareUsageBytesElement)
            {
                shareUsageBytes = (int)shareUsageBytesElement;
            }
            return new ShareStatistics(shareUsageBytes);
        }
    }
}
