// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("target");
            writer.WriteStringValue(Target);
            if (BytesToCapturePerPacket != null)
            {
                writer.WritePropertyName("bytesToCapturePerPacket");
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (TotalBytesPerSession != null)
            {
                writer.WritePropertyName("totalBytesPerSession");
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (TimeLimitInSeconds != null)
            {
                writer.WritePropertyName("timeLimitInSeconds");
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            writer.WritePropertyName("storageLocation");
            writer.WriteObjectValue(StorageLocation);
            if (Filters != null)
            {
                writer.WritePropertyName("filters");
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PacketCaptureParameters DeserializePacketCaptureParameters(JsonElement element)
        {
            string target = default;
            int? bytesToCapturePerPacket = default;
            int? totalBytesPerSession = default;
            int? timeLimitInSeconds = default;
            PacketCaptureStorageLocation storageLocation = default;
            IList<PacketCaptureFilter> filters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bytesToCapturePerPacket"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bytesToCapturePerPacket = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalBytesPerSession"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesPerSession = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeLimitInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeLimitInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageLocation"))
                {
                    storageLocation = PacketCaptureStorageLocation.DeserializePacketCaptureStorageLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("filters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PacketCaptureFilter> array = new List<PacketCaptureFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(PacketCaptureFilter.DeserializePacketCaptureFilter(item));
                        }
                    }
                    filters = array;
                    continue;
                }
            }
            return new PacketCaptureParameters(target, bytesToCapturePerPacket, totalBytesPerSession, timeLimitInSeconds, storageLocation, filters);
        }
    }
}
