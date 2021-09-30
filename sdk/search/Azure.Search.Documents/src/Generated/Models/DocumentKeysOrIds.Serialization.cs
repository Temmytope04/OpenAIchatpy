// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class DocumentKeysOrIds : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DocumentKeys))
            {
                writer.WritePropertyName("documentKeys");
                writer.WriteStartArray();
                foreach (var item in DocumentKeys)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DatasourceDocumentIds))
            {
                writer.WritePropertyName("datasourceDocumentIds");
                writer.WriteStartArray();
                foreach (var item in DatasourceDocumentIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
