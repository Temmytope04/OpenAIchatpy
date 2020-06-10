// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class PolicySetDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (PolicyType != null)
            {
                writer.WritePropertyName("policyType");
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            if (Parameters != null)
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
            if (PolicyDefinitions != null)
            {
                writer.WritePropertyName("policyDefinitions");
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PolicyDefinitionGroups != null)
            {
                writer.WritePropertyName("policyDefinitionGroups");
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitionGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PolicySetDefinition DeserializePolicySetDefinition(JsonElement element)
        {
            string id = default;
            string name = default;
            string type = default;
            PolicyType? policyType = default;
            string displayName = default;
            string description = default;
            object metadata = default;
            IDictionary<string, ParameterDefinitionsValue> parameters = default;
            IList<PolicyDefinitionReference> policyDefinitions = default;
            IList<PolicyDefinitionGroup> policyDefinitionGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policyType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyType = new PolicyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ParameterDefinitionsValue> dictionary = new Dictionary<string, ParameterDefinitionsValue>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, ParameterDefinitionsValue.DeserializeParameterDefinitionsValue(property1.Value));
                                }
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PolicyDefinitionReference> array = new List<PolicyDefinitionReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(PolicyDefinitionReference.DeserializePolicyDefinitionReference(item));
                                }
                            }
                            policyDefinitions = array;
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PolicyDefinitionGroup> array = new List<PolicyDefinitionGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(PolicyDefinitionGroup.DeserializePolicyDefinitionGroup(item));
                                }
                            }
                            policyDefinitionGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PolicySetDefinition(id, name, type, policyType, displayName, description, metadata, parameters, policyDefinitions, policyDefinitionGroups);
        }
    }
}
