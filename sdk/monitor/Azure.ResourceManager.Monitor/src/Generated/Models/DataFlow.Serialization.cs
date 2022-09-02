// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataFlow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams");
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Destinations))
            {
                writer.WritePropertyName("destinations");
                writer.WriteStartArray();
                foreach (var item in Destinations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TransformKql))
            {
                writer.WritePropertyName("transformKql");
                writer.WriteStringValue(TransformKql);
            }
            if (Optional.IsDefined(OutputStream))
            {
                writer.WritePropertyName("outputStream");
                writer.WriteStringValue(OutputStream);
            }
            writer.WriteEndObject();
        }

        internal static DataFlow DeserializeDataFlow(JsonElement element)
        {
            Optional<IList<DataFlowStream>> streams = default;
            Optional<IList<string>> destinations = default;
            Optional<string> transformKql = default;
            Optional<string> outputStream = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataFlowStream> array = new List<DataFlowStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataFlowStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("destinations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinations = array;
                    continue;
                }
                if (property.NameEquals("transformKql"))
                {
                    transformKql = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputStream"))
                {
                    outputStream = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlow(Optional.ToList(streams), Optional.ToList(destinations), transformKql.Value, outputStream.Value);
        }
    }
}
