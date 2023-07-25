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
    public partial class MachineLearningModelVersionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Flavors))
            {
                if (Flavors != null)
                {
                    writer.WritePropertyName("flavors"u8);
                    writer.WriteStartObject();
                    foreach (var item in Flavors)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("flavors");
                }
            }
            if (Optional.IsDefined(JobName))
            {
                if (JobName != null)
                {
                    writer.WritePropertyName("jobName"u8);
                    writer.WriteStringValue(JobName);
                }
                else
                {
                    writer.WriteNull("jobName");
                }
            }
            if (Optional.IsDefined(ModelType))
            {
                if (ModelType != null)
                {
                    writer.WritePropertyName("modelType"u8);
                    writer.WriteStringValue(ModelType);
                }
                else
                {
                    writer.WriteNull("modelType");
                }
            }
            if (Optional.IsDefined(ModelUri))
            {
                if (ModelUri != null)
                {
                    writer.WritePropertyName("modelUri"u8);
                    writer.WriteStringValue(ModelUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("modelUri");
                }
            }
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningModelVersionProperties DeserializeMachineLearningModelVersionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, MachineLearningFlavorData>> flavors = default;
            Optional<string> jobName = default;
            Optional<string> modelType = default;
            Optional<Uri> modelUri = default;
            Optional<bool> isAnonymous = default;
            Optional<bool> isArchived = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("flavors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        flavors = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningFlavorData> dictionary = new Dictionary<string, MachineLearningFlavorData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningFlavorData.DeserializeMachineLearningFlavorData(property0.Value));
                    }
                    flavors = dictionary;
                    continue;
                }
                if (property.NameEquals("jobName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobName = null;
                        continue;
                    }
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelType = null;
                        continue;
                    }
                    modelType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelUri = null;
                        continue;
                    }
                    modelUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
            }
            return new MachineLearningModelVersionProperties(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), Optional.ToNullable(isAnonymous), Optional.ToNullable(isArchived), Optional.ToDictionary(flavors), jobName.Value, modelType.Value, modelUri.Value);
        }
    }
}
