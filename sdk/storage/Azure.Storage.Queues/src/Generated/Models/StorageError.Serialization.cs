// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.Xml.Linq;

namespace Azure.Storage.Queues.Models
{
    internal partial class StorageError
    {
        internal static StorageError DeserializeStorageError(XElement element, ModelReaderWriterOptions options = null)
        {
            string message = default;
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            return new StorageError(message);
        }
    }
}
