// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PrivateDnsZoneConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateDnsZoneId))
            {
                writer.WritePropertyName("privateDnsZoneId");
                writer.WriteStringValue(PrivateDnsZoneId);
            }
            if (Optional.IsCollectionDefined(RecordSets))
            {
                writer.WritePropertyName("recordSets");
                writer.WriteStartArray();
                foreach (var item in RecordSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateDnsZoneConfig DeserializePrivateDnsZoneConfig(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> privateDnsZoneId = default;
            Optional<IList<RecordSet>> recordSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateDnsZoneId"))
                        {
                            privateDnsZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recordSets"))
                        {
                            List<RecordSet> array = new List<RecordSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecordSet.DeserializeRecordSet(item));
                            }
                            recordSets = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PrivateDnsZoneConfig(name.Value, privateDnsZoneId.Value, Optional.ToList(recordSets));
        }
    }
}
