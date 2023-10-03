// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class FixedInputData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Columns))
            {
                if (Columns != null)
                {
                    writer.WritePropertyName("columns"u8);
                    writer.WriteStartObject();
                    foreach (var item in Columns)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("columns");
                }
            }
            if (Optional.IsDefined(DataContext))
            {
                if (DataContext != null)
                {
                    writer.WritePropertyName("dataContext"u8);
                    writer.WriteStringValue(DataContext);
                }
                else
                {
                    writer.WriteNull("dataContext");
                }
            }
            writer.WritePropertyName("inputDataType"u8);
            writer.WriteStringValue(InputDataType.ToString());
            writer.WritePropertyName("jobInputType"u8);
            writer.WriteStringValue(JobInputType.ToString());
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static FixedInputData DeserializeFixedInputData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> columns = default;
            Optional<string> dataContext = default;
            MonitoringInputDataType inputDataType = default;
            JobInputType jobInputType = default;
            Uri uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        columns = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    columns = dictionary;
                    continue;
                }
                if (property.NameEquals("dataContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataContext = null;
                        continue;
                    }
                    dataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataType"u8))
                {
                    inputDataType = new MonitoringInputDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobInputType"u8))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new FixedInputData(Optional.ToDictionary(columns), dataContext.Value, inputDataType, jobInputType, uri);
        }
    }
}
