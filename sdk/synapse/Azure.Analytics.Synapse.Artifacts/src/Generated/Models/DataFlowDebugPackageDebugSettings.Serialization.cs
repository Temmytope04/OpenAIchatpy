// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DataFlowDebugPackageDebugSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SourceSettings))
            {
                writer.WritePropertyName("sourceSettings"u8);
                writer.WriteStartArray();
                foreach (var item in SourceSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
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
            if (Optional.IsDefined(DatasetParameters))
            {
                writer.WritePropertyName("datasetParameters"u8);
                writer.WriteObjectValue(DatasetParameters);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugPackageDebugSettings DeserializeDataFlowDebugPackageDebugSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataFlowSourceSetting> sourceSettings = default;
            IDictionary<string, object> parameters = default;
            object datasetParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowSourceSetting> array = new List<DataFlowSourceSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowSourceSetting.DeserializeDataFlowSourceSetting(item));
                    }
                    sourceSettings = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("datasetParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasetParameters = property.Value.GetObject();
                    continue;
                }
            }
            return new DataFlowDebugPackageDebugSettings(sourceSettings ?? new ChangeTrackingList<DataFlowSourceSetting>(), parameters ?? new ChangeTrackingDictionary<string, object>(), datasetParameters);
        }
    }
}
