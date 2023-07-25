// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    public partial class CustomFormModelInfo
    {
        internal static CustomFormModelInfo DeserializeCustomFormModelInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            CustomFormModelStatus status = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            Optional<string> modelName = default;
            Optional<CustomFormModelProperties> attributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToCustomFormModelStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = CustomFormModelProperties.DeserializeCustomFormModelProperties(property.Value);
                    continue;
                }
            }
            return new CustomFormModelInfo(modelId, status, createdDateTime, lastUpdatedDateTime, modelName.Value, attributes.Value);
        }
    }
}
