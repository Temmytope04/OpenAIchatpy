// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class PrivateLinkResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId");
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsCollectionDefined(RequiredMembers))
            {
                writer.WritePropertyName("requiredMembers");
                writer.WriteStartArray();
                foreach (var item in RequiredMembers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredZoneNames))
            {
                writer.WritePropertyName("requiredZoneNames");
                writer.WriteStartArray();
                foreach (var item in RequiredZoneNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateLinkResource DeserializePrivateLinkResource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> groupId = default;
            Optional<IList<string>> requiredMembers = default;
            Optional<IList<string>> requiredZoneNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("groupId"))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredMembers"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            requiredMembers = array;
                            continue;
                        }
                        if (property0.NameEquals("requiredZoneNames"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            requiredZoneNames = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PrivateLinkResource(id.Value, name.Value, type.Value, groupId.Value, Optional.ToList(requiredMembers), Optional.ToList(requiredZoneNames));
        }
    }
}
