// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class ConnectionMonitorTestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceAgent))
            {
                writer.WritePropertyName("sourceAgent"u8);
                writer.WriteStringValue(SourceAgent);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteStringValue(Destination);
            }
            if (Optional.IsDefined(DestinationPort))
            {
                writer.WritePropertyName("destinationPort"u8);
                writer.WriteNumberValue(DestinationPort.Value);
            }
            if (Optional.IsDefined(TestFrequencyInSec))
            {
                writer.WritePropertyName("testFrequencyInSec"u8);
                writer.WriteNumberValue(TestFrequencyInSec.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorTestData DeserializeConnectionMonitorTestData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> sourceAgent = default;
            Optional<string> destination = default;
            Optional<int> destinationPort = default;
            Optional<int> testFrequencyInSec = default;
            Optional<bool> isTestSuccessful = default;
            Optional<IReadOnlyList<string>> path = default;
            Optional<PeeringProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceAgent"u8))
                        {
                            sourceAgent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destination"u8))
                        {
                            destination = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destinationPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destinationPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("testFrequencyInSec"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            testFrequencyInSec = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isTestSuccessful"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isTestSuccessful = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            path = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PeeringProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectionMonitorTestData(id, name, type, systemData.Value, sourceAgent.Value, destination.Value, Optional.ToNullable(destinationPort), Optional.ToNullable(testFrequencyInSec), Optional.ToNullable(isTestSuccessful), Optional.ToList(path), Optional.ToNullable(provisioningState));
        }
    }
}
