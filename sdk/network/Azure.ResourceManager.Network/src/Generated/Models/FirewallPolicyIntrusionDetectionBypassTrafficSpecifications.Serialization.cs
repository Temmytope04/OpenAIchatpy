// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyIntrusionDetectionBypassTrafficSpecifications : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SourceAddresses))
            {
                writer.WritePropertyName("sourceAddresses");
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationAddresses))
            {
                writer.WritePropertyName("destinationAddresses");
                writer.WriteStartArray();
                foreach (var item in DestinationAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPorts))
            {
                writer.WritePropertyName("destinationPorts");
                writer.WriteStartArray();
                foreach (var item in DestinationPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceIpGroups))
            {
                writer.WritePropertyName("sourceIpGroups");
                writer.WriteStartArray();
                foreach (var item in SourceIpGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationIpGroups))
            {
                writer.WritePropertyName("destinationIpGroups");
                writer.WriteStartArray();
                foreach (var item in DestinationIpGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyIntrusionDetectionBypassTrafficSpecifications DeserializeFirewallPolicyIntrusionDetectionBypassTrafficSpecifications(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<FirewallPolicyIntrusionDetectionProtocol> protocol = default;
            Optional<IList<string>> sourceAddresses = default;
            Optional<IList<string>> destinationAddresses = default;
            Optional<IList<string>> destinationPorts = default;
            Optional<IList<string>> sourceIpGroups = default;
            Optional<IList<string>> destinationIpGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protocol = new FirewallPolicyIntrusionDetectionProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceAddresses"))
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
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationAddresses"))
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
                    destinationAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationPorts"))
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
                    destinationPorts = array;
                    continue;
                }
                if (property.NameEquals("sourceIpGroups"))
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
                    sourceIpGroups = array;
                    continue;
                }
                if (property.NameEquals("destinationIpGroups"))
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
                    destinationIpGroups = array;
                    continue;
                }
            }
            return new FirewallPolicyIntrusionDetectionBypassTrafficSpecifications(name.Value, description.Value, Optional.ToNullable(protocol), Optional.ToList(sourceAddresses), Optional.ToList(destinationAddresses), Optional.ToList(destinationPorts), Optional.ToList(sourceIpGroups), Optional.ToList(destinationIpGroups));
        }
    }
}
