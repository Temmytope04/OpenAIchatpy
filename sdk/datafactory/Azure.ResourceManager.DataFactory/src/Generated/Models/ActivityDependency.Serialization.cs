// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ActivityDependency : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("activity"u8);
            writer.WriteStringValue(Activity);
            writer.WritePropertyName("dependencyConditions"u8);
            writer.WriteStartArray();
            foreach (var item in DependencyConditions)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ActivityDependency DeserializeActivityDependency(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activity = default;
            IList<DependencyCondition> dependencyConditions = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activity"u8))
                {
                    activity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependencyConditions"u8))
                {
                    List<DependencyCondition> array = new List<DependencyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DependencyCondition(item.GetString()));
                    }
                    dependencyConditions = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ActivityDependency(activity, dependencyConditions, additionalProperties);
        }
    }
}
