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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ResourceMetricDefinition : IUtf8JsonSerializable, IModelJsonSerializable<ResourceMetricDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceMetricDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceMetricDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static ResourceMetricDefinition DeserializeResourceMetricDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> unit = default;
            Optional<string> primaryAggregationType = default;
            Optional<IReadOnlyList<ResourceMetricAvailability>> metricAvailabilities = default;
            Optional<Uri> resourceUri = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("unit"u8))
                        {
                            unit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryAggregationType"u8))
                        {
                            primaryAggregationType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricAvailabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceMetricAvailability> array = new List<ResourceMetricAvailability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceMetricAvailability.DeserializeResourceMetricAvailability(item));
                            }
                            metricAvailabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("properties"u8))
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
                            properties = dictionary;
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
            return new ResourceMetricDefinition(id, name, type, systemData.Value, unit.Value, primaryAggregationType.Value, Optional.ToList(metricAvailabilities), resourceUri.Value, Optional.ToDictionary(properties), kind.Value, rawData);
        }

        ResourceMetricDefinition IModelJsonSerializable<ResourceMetricDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceMetricDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceMetricDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceMetricDefinition IModelSerializable<ResourceMetricDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceMetricDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceMetricDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceMetricDefinition"/> to convert. </param>
        public static implicit operator RequestContent(ResourceMetricDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceMetricDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceMetricDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceMetricDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
