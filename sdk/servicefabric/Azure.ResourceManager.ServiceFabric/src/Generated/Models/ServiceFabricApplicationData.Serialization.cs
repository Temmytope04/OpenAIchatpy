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
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricApplicationData : IUtf8JsonSerializable, IModelJsonSerializable<ServiceFabricApplicationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceFabricApplicationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceFabricApplicationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
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
            if (Optional.IsDefined(TypeVersion))
            {
                writer.WritePropertyName("typeVersion"u8);
                writer.WriteStringValue(TypeVersion);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                writer.WriteObjectValue(UpgradePolicy);
            }
            if (Optional.IsDefined(MinimumNodes))
            {
                writer.WritePropertyName("minimumNodes"u8);
                writer.WriteNumberValue(MinimumNodes.Value);
            }
            if (Optional.IsDefined(MaximumNodes))
            {
                writer.WritePropertyName("maximumNodes"u8);
                writer.WriteNumberValue(MaximumNodes.Value);
            }
            if (Optional.IsDefined(RemoveApplicationCapacity))
            {
                writer.WritePropertyName("removeApplicationCapacity"u8);
                writer.WriteBooleanValue(RemoveApplicationCapacity.Value);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManagedIdentities))
            {
                writer.WritePropertyName("managedIdentities"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedIdentities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TypeName))
            {
                writer.WritePropertyName("typeName"u8);
                writer.WriteStringValue(TypeName);
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

        internal static ServiceFabricApplicationData DeserializeServiceFabricApplicationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> typeVersion = default;
            Optional<IDictionary<string, string>> parameters = default;
            Optional<ApplicationUpgradePolicy> upgradePolicy = default;
            Optional<long> minimumNodes = default;
            Optional<long> maximumNodes = default;
            Optional<bool> removeApplicationCapacity = default;
            Optional<IList<ApplicationMetricDescription>> metrics = default;
            Optional<IList<ApplicationUserAssignedIdentity>> managedIdentities = default;
            Optional<string> provisioningState = default;
            Optional<string> typeName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("typeVersion"u8))
                        {
                            typeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("upgradePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePolicy = ApplicationUpgradePolicy.DeserializeApplicationUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("minimumNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumNodes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maximumNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNodes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("removeApplicationCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            removeApplicationCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationMetricDescription> array = new List<ApplicationMetricDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationMetricDescription.DeserializeApplicationMetricDescription(item));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("managedIdentities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationUserAssignedIdentity> array = new List<ApplicationUserAssignedIdentity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationUserAssignedIdentity.DeserializeApplicationUserAssignedIdentity(item));
                            }
                            managedIdentities = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typeName"u8))
                        {
                            typeName = property0.Value.GetString();
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
            return new ServiceFabricApplicationData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, typeVersion.Value, Optional.ToDictionary(parameters), upgradePolicy.Value, Optional.ToNullable(minimumNodes), Optional.ToNullable(maximumNodes), Optional.ToNullable(removeApplicationCapacity), Optional.ToList(metrics), Optional.ToList(managedIdentities), provisioningState.Value, typeName.Value, Optional.ToNullable(etag), rawData);
        }

        ServiceFabricApplicationData IModelJsonSerializable<ServiceFabricApplicationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricApplicationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceFabricApplicationData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceFabricApplicationData IModelSerializable<ServiceFabricApplicationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceFabricApplicationData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ServiceFabricApplicationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ServiceFabricApplicationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceFabricApplicationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
