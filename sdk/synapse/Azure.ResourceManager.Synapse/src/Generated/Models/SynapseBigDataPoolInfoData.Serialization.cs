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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseBigDataPoolInfoData : IUtf8JsonSerializable, IModelJsonSerializable<SynapseBigDataPoolInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseBigDataPoolInfoData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseBigDataPoolInfoData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale"u8);
                writer.WriteObjectValue(AutoScale);
            }
            if (Optional.IsDefined(AutoPause))
            {
                writer.WritePropertyName("autoPause"u8);
                writer.WriteObjectValue(AutoPause);
            }
            if (Optional.IsDefined(IsComputeIsolationEnabled))
            {
                writer.WritePropertyName("isComputeIsolationEnabled"u8);
                writer.WriteBooleanValue(IsComputeIsolationEnabled.Value);
            }
            if (Optional.IsDefined(IsAutotuneEnabled))
            {
                writer.WritePropertyName("isAutotuneEnabled"u8);
                writer.WriteBooleanValue(IsAutotuneEnabled.Value);
            }
            if (Optional.IsDefined(IsSessionLevelPackagesEnabled))
            {
                writer.WritePropertyName("sessionLevelPackagesEnabled"u8);
                writer.WriteBooleanValue(IsSessionLevelPackagesEnabled.Value);
            }
            if (Optional.IsDefined(CacheSize))
            {
                writer.WritePropertyName("cacheSize"u8);
                writer.WriteNumberValue(CacheSize.Value);
            }
            if (Optional.IsDefined(DynamicExecutorAllocation))
            {
                writer.WritePropertyName("dynamicExecutorAllocation"u8);
                writer.WriteObjectValue(DynamicExecutorAllocation);
            }
            if (Optional.IsDefined(SparkEventsFolder))
            {
                writer.WritePropertyName("sparkEventsFolder"u8);
                writer.WriteStringValue(SparkEventsFolder);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(LibraryRequirements))
            {
                writer.WritePropertyName("libraryRequirements"u8);
                writer.WriteObjectValue(LibraryRequirements);
            }
            if (Optional.IsCollectionDefined(CustomLibraries))
            {
                writer.WritePropertyName("customLibraries"u8);
                writer.WriteStartArray();
                foreach (var item in CustomLibraries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SparkConfigProperties))
            {
                writer.WritePropertyName("sparkConfigProperties"u8);
                writer.WriteObjectValue(SparkConfigProperties);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteStringValue(SparkVersion);
            }
            if (Optional.IsDefined(DefaultSparkLogFolder))
            {
                writer.WritePropertyName("defaultSparkLogFolder"u8);
                writer.WriteStringValue(DefaultSparkLogFolder);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize.Value.ToString());
            }
            if (Optional.IsDefined(NodeSizeFamily))
            {
                writer.WritePropertyName("nodeSizeFamily"u8);
                writer.WriteStringValue(NodeSizeFamily.Value.ToString());
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

        internal static SynapseBigDataPoolInfoData DeserializeSynapseBigDataPoolInfoData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            Optional<BigDataPoolAutoScaleProperties> autoScale = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<BigDataPoolAutoPauseProperties> autoPause = default;
            Optional<bool> isComputeIsolationEnabled = default;
            Optional<bool> isAutotuneEnabled = default;
            Optional<bool> sessionLevelPackagesEnabled = default;
            Optional<int> cacheSize = default;
            Optional<SynapseDynamicExecutorAllocation> dynamicExecutorAllocation = default;
            Optional<string> sparkEventsFolder = default;
            Optional<int> nodeCount = default;
            Optional<BigDataPoolLibraryRequirements> libraryRequirements = default;
            Optional<IList<BigDataPoolLibraryInfo>> customLibraries = default;
            Optional<BigDataPoolSparkConfigProperties> sparkConfigProperties = default;
            Optional<string> sparkVersion = default;
            Optional<string> defaultSparkLogFolder = default;
            Optional<BigDataPoolNodeSize> nodeSize = default;
            Optional<BigDataPoolNodeSizeFamily> nodeSizeFamily = default;
            Optional<DateTimeOffset> lastSucceededTimestamp = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoScale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScale = BigDataPoolAutoScaleProperties.DeserializeBigDataPoolAutoScaleProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoPause"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoPause = BigDataPoolAutoPauseProperties.DeserializeBigDataPoolAutoPauseProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isComputeIsolationEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isComputeIsolationEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAutotuneEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAutotuneEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sessionLevelPackagesEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionLevelPackagesEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cacheSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cacheSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dynamicExecutorAllocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dynamicExecutorAllocation = SynapseDynamicExecutorAllocation.DeserializeSynapseDynamicExecutorAllocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkEventsFolder"u8))
                        {
                            sparkEventsFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("libraryRequirements"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            libraryRequirements = BigDataPoolLibraryRequirements.DeserializeBigDataPoolLibraryRequirements(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customLibraries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BigDataPoolLibraryInfo> array = new List<BigDataPoolLibraryInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BigDataPoolLibraryInfo.DeserializeBigDataPoolLibraryInfo(item));
                            }
                            customLibraries = array;
                            continue;
                        }
                        if (property0.NameEquals("sparkConfigProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkConfigProperties = BigDataPoolSparkConfigProperties.DeserializeBigDataPoolSparkConfigProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            sparkVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultSparkLogFolder"u8))
                        {
                            defaultSparkLogFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeSize = new BigDataPoolNodeSize(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeSizeFamily"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeSizeFamily = new BigDataPoolNodeSizeFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSucceededTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSucceededTimestamp = property0.Value.GetDateTimeOffset("O");
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
            return new SynapseBigDataPoolInfoData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, provisioningState.Value, autoScale.Value, Optional.ToNullable(creationDate), autoPause.Value, Optional.ToNullable(isComputeIsolationEnabled), Optional.ToNullable(isAutotuneEnabled), Optional.ToNullable(sessionLevelPackagesEnabled), Optional.ToNullable(cacheSize), dynamicExecutorAllocation.Value, sparkEventsFolder.Value, Optional.ToNullable(nodeCount), libraryRequirements.Value, Optional.ToList(customLibraries), sparkConfigProperties.Value, sparkVersion.Value, defaultSparkLogFolder.Value, Optional.ToNullable(nodeSize), Optional.ToNullable(nodeSizeFamily), Optional.ToNullable(lastSucceededTimestamp), rawData);
        }

        SynapseBigDataPoolInfoData IModelJsonSerializable<SynapseBigDataPoolInfoData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseBigDataPoolInfoData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseBigDataPoolInfoData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseBigDataPoolInfoData IModelSerializable<SynapseBigDataPoolInfoData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseBigDataPoolInfoData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SynapseBigDataPoolInfoData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SynapseBigDataPoolInfoData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseBigDataPoolInfoData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
