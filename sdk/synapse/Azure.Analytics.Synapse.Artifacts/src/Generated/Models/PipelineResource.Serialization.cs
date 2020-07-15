// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class PipelineResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Activities))
            {
                writer.WritePropertyName("activities");
                writer.WriteStartArray();
                foreach (var item in Activities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Variables))
            {
                writer.WritePropertyName("variables");
                writer.WriteStartObject();
                foreach (var item in Variables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Concurrency))
            {
                writer.WritePropertyName("concurrency");
                writer.WriteNumberValue(Concurrency.Value);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RunDimensions))
            {
                writer.WritePropertyName("runDimensions");
                writer.WriteStartObject();
                foreach (var item in RunDimensions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
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
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> etag = default;
            Optional<string> description = default;
            Optional<IList<Activity>> activities = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IDictionary<string, VariableSpecification>> variables = default;
            Optional<int> concurrency = default;
            Optional<IList<object>> annotations = default;
            Optional<IDictionary<string, object>> runDimensions = default;
            Optional<PipelineFolder> folder = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("activities"))
                        {
                            List<Activity> array = new List<Activity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Activity.DeserializeActivity(item));
                            }
                            activities = array;
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterSpecification.DeserializeParameterSpecification(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("variables"))
                        {
                            Dictionary<string, VariableSpecification> dictionary = new Dictionary<string, VariableSpecification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, VariableSpecification.DeserializeVariableSpecification(property1.Value));
                            }
                            variables = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("concurrency"))
                        {
                            concurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("annotations"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            annotations = array;
                            continue;
                        }
                        if (property0.NameEquals("runDimensions"))
                        {
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetObject());
                            }
                            runDimensions = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("folder"))
                        {
                            folder = PipelineFolder.DeserializePipelineFolder(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineResource(id.Value, name.Value, type.Value, etag.Value, description.Value, Optional.ToList(activities), Optional.ToDictionary(parameters), Optional.ToDictionary(variables), Optional.ToNullable(concurrency), Optional.ToList(annotations), Optional.ToDictionary(runDimensions), folder.Value, additionalProperties);
        }
    }
}
