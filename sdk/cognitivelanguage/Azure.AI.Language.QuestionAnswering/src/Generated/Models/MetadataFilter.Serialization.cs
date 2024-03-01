// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class MetadataFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (!(Metadata is ChangeTrackingList<MetadataRecord> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LogicalOperation.HasValue)
            {
                writer.WritePropertyName("logicalOperation"u8);
                writer.WriteStringValue(LogicalOperation.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
