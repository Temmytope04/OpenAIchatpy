// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    public partial class TrafficManagerEndpointData : IUtf8JsonSerializable, IModelJsonSerializable<TrafficManagerEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrafficManagerEndpointData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrafficManagerEndpointData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficManagerEndpointData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(EndpointStatus))
            {
                writer.WritePropertyName("endpointStatus"u8);
                writer.WriteStringValue(EndpointStatus.Value.ToString());
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(EndpointLocation))
            {
                writer.WritePropertyName("endpointLocation"u8);
                writer.WriteStringValue(EndpointLocation);
            }
            if (Optional.IsDefined(EndpointMonitorStatus))
            {
                writer.WritePropertyName("endpointMonitorStatus"u8);
                writer.WriteStringValue(EndpointMonitorStatus.Value.ToString());
            }
            if (Optional.IsDefined(MinChildEndpoints))
            {
                if (MinChildEndpoints != null)
                {
                    writer.WritePropertyName("minChildEndpoints"u8);
                    writer.WriteNumberValue(MinChildEndpoints.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpoints");
                }
            }
            if (Optional.IsDefined(MinChildEndpointsIPv4))
            {
                if (MinChildEndpointsIPv4 != null)
                {
                    writer.WritePropertyName("minChildEndpointsIPv4"u8);
                    writer.WriteNumberValue(MinChildEndpointsIPv4.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpointsIPv4");
                }
            }
            if (Optional.IsDefined(MinChildEndpointsIPv6))
            {
                if (MinChildEndpointsIPv6 != null)
                {
                    writer.WritePropertyName("minChildEndpointsIPv6"u8);
                    writer.WriteNumberValue(MinChildEndpointsIPv6.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpointsIPv6");
                }
            }
            if (Optional.IsCollectionDefined(GeoMapping))
            {
                writer.WritePropertyName("geoMapping"u8);
                writer.WriteStartArray();
                foreach (var item in GeoMapping)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomHeaders))
            {
                writer.WritePropertyName("customHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in CustomHeaders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlwaysServe))
            {
                writer.WritePropertyName("alwaysServe"u8);
                writer.WriteStringValue(AlwaysServe.Value.ToString());
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static TrafficManagerEndpointData DeserializeTrafficManagerEndpointData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Optional<string> target = default;
            Optional<TrafficManagerEndpointStatus> endpointStatus = default;
            Optional<long> weight = default;
            Optional<long> priority = default;
            Optional<string> endpointLocation = default;
            Optional<TrafficManagerEndpointMonitorStatus> endpointMonitorStatus = default;
            Optional<long?> minChildEndpoints = default;
            Optional<long?> minChildEndpointsIPv4 = default;
            Optional<long?> minChildEndpointsIPv6 = default;
            Optional<IList<string>> geoMapping = default;
            Optional<IList<TrafficManagerEndpointSubnetInfo>> subnets = default;
            Optional<IList<TrafficManagerEndpointCustomHeaderInfo>> customHeaders = default;
            Optional<TrafficManagerEndpointAlwaysServeStatus> alwaysServe = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointStatus = new TrafficManagerEndpointStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weight = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("endpointLocation"u8))
                        {
                            endpointLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointMonitorStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointMonitorStatus = new TrafficManagerEndpointMonitorStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpoints = null;
                                continue;
                            }
                            minChildEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpointsIPv4"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpointsIPv4 = null;
                                continue;
                            }
                            minChildEndpointsIPv4 = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpointsIPv6"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpointsIPv6 = null;
                                continue;
                            }
                            minChildEndpointsIPv6 = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("geoMapping"u8))
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
                            geoMapping = array;
                            continue;
                        }
                        if (property0.NameEquals("subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointSubnetInfo> array = new List<TrafficManagerEndpointSubnetInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointSubnetInfo.DeserializeTrafficManagerEndpointSubnetInfo(item));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("customHeaders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointCustomHeaderInfo> array = new List<TrafficManagerEndpointCustomHeaderInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointCustomHeaderInfo.DeserializeTrafficManagerEndpointCustomHeaderInfo(item));
                            }
                            customHeaders = array;
                            continue;
                        }
                        if (property0.NameEquals("alwaysServe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alwaysServe = new TrafficManagerEndpointAlwaysServeStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrafficManagerEndpointData(id.Value, name.Value, Optional.ToNullable(type), targetResourceId.Value, target.Value, Optional.ToNullable(endpointStatus), Optional.ToNullable(weight), Optional.ToNullable(priority), endpointLocation.Value, Optional.ToNullable(endpointMonitorStatus), Optional.ToNullable(minChildEndpoints), Optional.ToNullable(minChildEndpointsIPv4), Optional.ToNullable(minChildEndpointsIPv6), Optional.ToList(geoMapping), Optional.ToList(subnets), Optional.ToList(customHeaders), Optional.ToNullable(alwaysServe), rawData);
        }

        TrafficManagerEndpointData IModelJsonSerializable<TrafficManagerEndpointData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficManagerEndpointData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerEndpointData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrafficManagerEndpointData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficManagerEndpointData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrafficManagerEndpointData IModelSerializable<TrafficManagerEndpointData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficManagerEndpointData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrafficManagerEndpointData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TrafficManagerEndpointData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TrafficManagerEndpointData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrafficManagerEndpointData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
