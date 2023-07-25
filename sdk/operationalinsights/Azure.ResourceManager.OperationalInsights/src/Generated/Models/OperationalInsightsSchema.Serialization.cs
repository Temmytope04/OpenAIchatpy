// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsSchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OperationalInsightsSchema DeserializeOperationalInsightsSchema(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<IList<OperationalInsightsColumn>> columns = default;
            Optional<IReadOnlyList<OperationalInsightsColumn>> standardColumns = default;
            Optional<IReadOnlyList<string>> categories = default;
            Optional<IReadOnlyList<string>> labels = default;
            Optional<OperationalInsightsTableCreator> source = default;
            Optional<OperationalInsightsTableType> tableType = default;
            Optional<OperationalInsightsTableSubType> tableSubType = default;
            Optional<IReadOnlyList<string>> solutions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsColumn> array = new List<OperationalInsightsColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsColumn.DeserializeOperationalInsightsColumn(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("standardColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsColumn> array = new List<OperationalInsightsColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsColumn.DeserializeOperationalInsightsColumn(item));
                    }
                    standardColumns = array;
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = new OperationalInsightsTableCreator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tableType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableType = new OperationalInsightsTableType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tableSubType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableSubType = new OperationalInsightsTableSubType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("solutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    solutions = array;
                    continue;
                }
            }
            return new OperationalInsightsSchema(name.Value, displayName.Value, description.Value, Optional.ToList(columns), Optional.ToList(standardColumns), Optional.ToList(categories), Optional.ToList(labels), Optional.ToNullable(source), Optional.ToNullable(tableType), Optional.ToNullable(tableSubType), Optional.ToList(solutions));
        }
    }
}
