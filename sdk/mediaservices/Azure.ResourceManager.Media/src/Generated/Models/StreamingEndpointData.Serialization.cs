// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingEndpointData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ScaleUnits))
            {
                writer.WritePropertyName("scaleUnits"u8);
                writer.WriteNumberValue(ScaleUnits.Value);
            }
            if (Optional.IsDefined(AvailabilitySetName))
            {
                writer.WritePropertyName("availabilitySetName"u8);
                writer.WriteStringValue(AvailabilitySetName);
            }
            if (Optional.IsDefined(AccessControl))
            {
                if (AccessControl != null)
                {
                    writer.WritePropertyName("accessControl"u8);
                    writer.WriteObjectValue(AccessControl);
                }
                else
                {
                    writer.WriteNull("accessControl");
                }
            }
            if (Optional.IsDefined(MaxCacheAge))
            {
                if (MaxCacheAge != null)
                {
                    writer.WritePropertyName("maxCacheAge"u8);
                    writer.WriteNumberValue(MaxCacheAge.Value);
                }
                else
                {
                    writer.WriteNull("maxCacheAge");
                }
            }
            if (Optional.IsCollectionDefined(CustomHostNames))
            {
                writer.WritePropertyName("customHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in CustomHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsCdnEnabled))
            {
                writer.WritePropertyName("cdnEnabled"u8);
                writer.WriteBooleanValue(IsCdnEnabled.Value);
            }
            if (Optional.IsDefined(CdnProvider))
            {
                writer.WritePropertyName("cdnProvider"u8);
                writer.WriteStringValue(CdnProvider);
            }
            if (Optional.IsDefined(CdnProfile))
            {
                writer.WritePropertyName("cdnProfile"u8);
                writer.WriteStringValue(CdnProfile);
            }
            if (Optional.IsDefined(CrossSiteAccessPolicies))
            {
                if (CrossSiteAccessPolicies != null)
                {
                    writer.WritePropertyName("crossSiteAccessPolicies"u8);
                    writer.WriteObjectValue(CrossSiteAccessPolicies);
                }
                else
                {
                    writer.WriteNull("crossSiteAccessPolicies");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StreamingEndpointData DeserializeStreamingEndpointData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamingEndpointCurrentSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<int> scaleUnits = default;
            Optional<string> availabilitySetName = default;
            Optional<StreamingEndpointAccessControl> accessControl = default;
            Optional<long?> maxCacheAge = default;
            Optional<IList<string>> customHostNames = default;
            Optional<string> hostName = default;
            Optional<bool> cdnEnabled = default;
            Optional<string> cdnProvider = default;
            Optional<string> cdnProfile = default;
            Optional<string> provisioningState = default;
            Optional<StreamingEndpointResourceState> resourceState = default;
            Optional<CrossSiteAccessPolicies> crossSiteAccessPolicies = default;
            Optional<DateTimeOffset> freeTrialEndTime = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> lastModified = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StreamingEndpointCurrentSku.DeserializeStreamingEndpointCurrentSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scaleUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleUnits = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("availabilitySetName"u8))
                        {
                            availabilitySetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accessControl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                accessControl = null;
                                continue;
                            }
                            accessControl = StreamingEndpointAccessControl.DeserializeStreamingEndpointAccessControl(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maxCacheAge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                maxCacheAge = null;
                                continue;
                            }
                            maxCacheAge = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("customHostNames"u8))
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
                            customHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cdnEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cdnEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cdnProvider"u8))
                        {
                            cdnProvider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cdnProfile"u8))
                        {
                            cdnProfile = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new StreamingEndpointResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSiteAccessPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                crossSiteAccessPolicies = null;
                                continue;
                            }
                            crossSiteAccessPolicies = CrossSiteAccessPolicies.DeserializeCrossSiteAccessPolicies(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("freeTrialEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            freeTrialEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StreamingEndpointData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, description.Value, Optional.ToNullable(scaleUnits), availabilitySetName.Value, accessControl.Value, Optional.ToNullable(maxCacheAge), Optional.ToList(customHostNames), hostName.Value, Optional.ToNullable(cdnEnabled), cdnProvider.Value, cdnProfile.Value, provisioningState.Value, Optional.ToNullable(resourceState), crossSiteAccessPolicies.Value, Optional.ToNullable(freeTrialEndTime), Optional.ToNullable(created), Optional.ToNullable(lastModified));
        }
    }
}
