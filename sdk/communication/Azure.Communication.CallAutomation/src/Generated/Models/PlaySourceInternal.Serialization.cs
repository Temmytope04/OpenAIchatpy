// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class PlaySourceInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType.ToString());
            if (Optional.IsDefined(PlaySourceId))
            {
                writer.WritePropertyName("playSourceId"u8);
                writer.WriteStringValue(PlaySourceId);
            }
            if (Optional.IsDefined(FileSource))
            {
                writer.WritePropertyName("fileSource"u8);
                writer.WriteObjectValue(FileSource);
            }
            if (Optional.IsDefined(TextSource))
            {
                writer.WritePropertyName("textSource"u8);
                writer.WriteObjectValue(TextSource);
            }
            if (Optional.IsDefined(SsmlSource))
            {
                writer.WritePropertyName("ssmlSource"u8);
                writer.WriteObjectValue(SsmlSource);
            }
            writer.WriteEndObject();
        }
    }
}
