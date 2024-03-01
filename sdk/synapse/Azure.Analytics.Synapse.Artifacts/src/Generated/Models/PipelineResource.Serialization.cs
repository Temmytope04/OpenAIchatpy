// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(PipelineResourceConverter))]
    public partial class PipelineResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Activities is ChangeTrackingList<Activity> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("activities"u8);
                writer.WriteStartArray();
                foreach (var item in Activities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Parameters is ChangeTrackingDictionary<string, ParameterSpecification> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Variables is ChangeTrackingDictionary<string, VariableSpecification> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("variables"u8);
                writer.WriteStartObject();
                foreach (var item in Variables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Concurrency.HasValue)
            {
                writer.WritePropertyName("concurrency"u8);
                writer.WriteNumberValue(Concurrency.Value);
            }
            if (!(Annotations is ChangeTrackingList<object> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RunDimensions is ChangeTrackingDictionary<string, object> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("runDimensions"u8);
                writer.WriteStartObject();
                foreach (var item in RunDimensions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Folder != null)
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static PipelineResource DeserializePipelineResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string description = default;
            IList<Activity> activities = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IDictionary<string, VariableSpecification> variables = default;
            int? concurrency = default;
            IList<object> annotations = default;
            IDictionary<string, object> runDimensions = default;
            PipelineFolder folder = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("activities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Activity> array = new List<Activity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Activity.DeserializeActivity(item));
                            }
                            activities = array;
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterSpecification.DeserializeParameterSpecification(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("variables"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, VariableSpecification> dictionary = new Dictionary<string, VariableSpecification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, VariableSpecification.DeserializeVariableSpecification(property1.Value));
                            }
                            variables = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("concurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            concurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("annotations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            annotations = array;
                            continue;
                        }
                        if (property0.NameEquals("runDimensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            runDimensions = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("folder"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            folder = PipelineFolder.DeserializePipelineFolder(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineResource(
                id,
                name,
                type,
                etag,
                description,
                activities ?? new ChangeTrackingList<Activity>(),
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                variables ?? new ChangeTrackingDictionary<string, VariableSpecification>(),
                concurrency,
                annotations ?? new ChangeTrackingList<object>(),
                runDimensions ?? new ChangeTrackingDictionary<string, object>(),
                folder,
                additionalProperties);
        }

        internal partial class PipelineResourceConverter : JsonConverter<PipelineResource>
        {
            public override void Write(Utf8JsonWriter writer, PipelineResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PipelineResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePipelineResource(document.RootElement);
            }
        }
    }
}
