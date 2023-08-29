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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class InstanceFailoverGroupData : IUtf8JsonSerializable, IModelJsonSerializable<InstanceFailoverGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InstanceFailoverGroupData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InstanceFailoverGroupData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType"u8);
                writer.WriteStringValue(SecondaryType.Value.ToString());
            }
            if (Optional.IsDefined(ReadWriteEndpoint))
            {
                writer.WritePropertyName("readWriteEndpoint"u8);
                writer.WriteObjectValue(ReadWriteEndpoint);
            }
            if (Optional.IsDefined(ReadOnlyEndpoint))
            {
                writer.WritePropertyName("readOnlyEndpoint"u8);
                writer.WriteObjectValue(ReadOnlyEndpoint);
            }
            if (Optional.IsCollectionDefined(PartnerRegions))
            {
                writer.WritePropertyName("partnerRegions"u8);
                writer.WriteStartArray();
                foreach (var item in PartnerRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManagedInstancePairs))
            {
                writer.WritePropertyName("managedInstancePairs"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedInstancePairs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static InstanceFailoverGroupData DeserializeInstanceFailoverGroupData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<GeoSecondaryInstanceType> secondaryType = default;
            Optional<InstanceFailoverGroupReadWriteEndpoint> readWriteEndpoint = default;
            Optional<InstanceFailoverGroupReadOnlyEndpoint> readOnlyEndpoint = default;
            Optional<InstanceFailoverGroupReplicationRole> replicationRole = default;
            Optional<string> replicationState = default;
            Optional<IList<PartnerRegionInfo>> partnerRegions = default;
            Optional<IList<ManagedInstancePairInfo>> managedInstancePairs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("secondaryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryType = new GeoSecondaryInstanceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("readWriteEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readWriteEndpoint = InstanceFailoverGroupReadWriteEndpoint.DeserializeInstanceFailoverGroupReadWriteEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("readOnlyEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readOnlyEndpoint = InstanceFailoverGroupReadOnlyEndpoint.DeserializeInstanceFailoverGroupReadOnlyEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new InstanceFailoverGroupReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            replicationState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerRegions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PartnerRegionInfo> array = new List<PartnerRegionInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PartnerRegionInfo.DeserializePartnerRegionInfo(item));
                            }
                            partnerRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("managedInstancePairs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedInstancePairInfo> array = new List<ManagedInstancePairInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedInstancePairInfo.DeserializeManagedInstancePairInfo(item));
                            }
                            managedInstancePairs = array;
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
            return new InstanceFailoverGroupData(id, name, type, systemData.Value, Optional.ToNullable(secondaryType), readWriteEndpoint.Value, readOnlyEndpoint.Value, Optional.ToNullable(replicationRole), replicationState.Value, Optional.ToList(partnerRegions), Optional.ToList(managedInstancePairs), rawData);
        }

        InstanceFailoverGroupData IModelJsonSerializable<InstanceFailoverGroupData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceFailoverGroupData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstanceFailoverGroupData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InstanceFailoverGroupData IModelSerializable<InstanceFailoverGroupData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInstanceFailoverGroupData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InstanceFailoverGroupData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InstanceFailoverGroupData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInstanceFailoverGroupData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
