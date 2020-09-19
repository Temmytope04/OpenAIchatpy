// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class OperationDisplay
    {
        internal static OperationDisplay DeserializeOperationDisplay(JsonElement element)
        {
            Optional<string> provider = default;
            Optional<string> resource = default;
            Optional<string> operation = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Provider"))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Resource"))
                {
                    resource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Operation"))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new OperationDisplay(provider.Value, resource.Value, operation.Value, description.Value);
        }
    }
}
