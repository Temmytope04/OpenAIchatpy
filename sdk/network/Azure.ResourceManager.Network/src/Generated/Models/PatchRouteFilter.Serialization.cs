// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PatchRouteFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PatchRouteFilter DeserializePatchRouteFilter(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> id = default;
            Optional<IList<RouteFilterRuleData>> rules = default;
            Optional<IReadOnlyList<ExpressRouteCircuitPeeringData>> peerings = default;
            Optional<IReadOnlyList<ExpressRouteCircuitPeeringData>> ipv6Peerings = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("rules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RouteFilterRuleData> array = new List<RouteFilterRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RouteFilterRuleData.DeserializeRouteFilterRuleData(item));
                            }
                            rules = array;
                            continue;
                        }
                        if (property0.NameEquals("peerings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ExpressRouteCircuitPeeringData> array = new List<ExpressRouteCircuitPeeringData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitPeeringData.DeserializeExpressRouteCircuitPeeringData(item));
                            }
                            peerings = array;
                            continue;
                        }
                        if (property0.NameEquals("ipv6Peerings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ExpressRouteCircuitPeeringData> array = new List<ExpressRouteCircuitPeeringData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitPeeringData.DeserializeExpressRouteCircuitPeeringData(item));
                            }
                            ipv6Peerings = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PatchRouteFilter(id.Value, name.Value, etag.Value, type.Value, Optional.ToDictionary(tags), Optional.ToList(rules), Optional.ToList(peerings), Optional.ToList(ipv6Peerings), Optional.ToNullable(provisioningState));
        }
    }
}
