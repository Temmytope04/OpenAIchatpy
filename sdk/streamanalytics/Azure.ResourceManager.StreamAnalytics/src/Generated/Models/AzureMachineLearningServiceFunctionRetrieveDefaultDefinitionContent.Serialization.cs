// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class AzureMachineLearningServiceFunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("bindingType");
            writer.WriteStringValue(BindingType);
            writer.WritePropertyName("bindingRetrievalProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ExecuteEndpoint))
            {
                writer.WritePropertyName("executeEndpoint");
                writer.WriteStringValue(ExecuteEndpoint);
            }
            if (Optional.IsDefined(UdfType))
            {
                writer.WritePropertyName("udfType");
                writer.WriteStringValue(UdfType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
