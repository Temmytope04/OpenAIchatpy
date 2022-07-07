// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class EnabledProtocols : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("download");
            writer.WriteBooleanValue(Download);
            writer.WritePropertyName("dash");
            writer.WriteBooleanValue(Dash);
            writer.WritePropertyName("hls");
            writer.WriteBooleanValue(Hls);
            writer.WritePropertyName("smoothStreaming");
            writer.WriteBooleanValue(SmoothStreaming);
            writer.WriteEndObject();
        }

        internal static EnabledProtocols DeserializeEnabledProtocols(JsonElement element)
        {
            bool download = default;
            bool dash = default;
            bool hls = default;
            bool smoothStreaming = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("download"))
                {
                    download = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dash"))
                {
                    dash = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hls"))
                {
                    hls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("smoothStreaming"))
                {
                    smoothStreaming = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EnabledProtocols(download, dash, hls, smoothStreaming);
        }
    }
}
