// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RulesEngineRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("priority");
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("action");
            writer.WriteObjectValue(Action);
            if (Optional.IsCollectionDefined(MatchConditions))
            {
                if (MatchConditions != null)
                {
                    writer.WritePropertyName("matchConditions");
                    writer.WriteStartArray();
                    foreach (var item in MatchConditions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("matchConditions");
                }
            }
            if (Optional.IsDefined(MatchProcessingBehavior))
            {
                if (MatchProcessingBehavior != null)
                {
                    writer.WritePropertyName("matchProcessingBehavior");
                    writer.WriteStringValue(MatchProcessingBehavior.Value.ToString());
                }
                else
                {
                    writer.WriteNull("matchProcessingBehavior");
                }
            }
            writer.WriteEndObject();
        }

        internal static RulesEngineRule DeserializeRulesEngineRule(JsonElement element)
        {
            string name = default;
            int priority = default;
            RulesEngineAction action = default;
            Optional<IList<RulesEngineMatchCondition>> matchConditions = default;
            Optional<MatchProcessingBehavior?> matchProcessingBehavior = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = RulesEngineAction.DeserializeRulesEngineAction(property.Value);
                    continue;
                }
                if (property.NameEquals("matchConditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        matchConditions = null;
                        continue;
                    }
                    List<RulesEngineMatchCondition> array = new List<RulesEngineMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RulesEngineMatchCondition.DeserializeRulesEngineMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("matchProcessingBehavior"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        matchProcessingBehavior = null;
                        continue;
                    }
                    matchProcessingBehavior = new MatchProcessingBehavior(property.Value.GetString());
                    continue;
                }
            }
            return new RulesEngineRule(name, priority, action, Optional.ToList(matchConditions), Optional.ToNullable(matchProcessingBehavior));
        }
    }
}
