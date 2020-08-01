// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MachineLearningServicesModelRegisteredEventData
    {
        internal static MachineLearningServicesModelRegisteredEventData DeserializeMachineLearningServicesModelRegisteredEventData(JsonElement element)
        {
            Optional<string> modelName = default;
            Optional<string> modelVersion = default;
            Optional<object> modelTags = default;
            Optional<object> modelProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelName"))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelVersion"))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelTags"))
                {
                    modelTags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modelProperties"))
                {
                    modelProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new MachineLearningServicesModelRegisteredEventData(modelName.Value, modelVersion.Value, modelTags.Value, modelProperties.Value);
        }
    }
}
