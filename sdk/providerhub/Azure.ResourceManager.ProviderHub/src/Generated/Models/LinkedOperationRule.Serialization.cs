// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class LinkedOperationRule
    {
        internal static LinkedOperationRule DeserializeLinkedOperationRule(JsonElement element)
        {
            LinkedOperation linkedOperation = default;
            LinkedAction linkedAction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedOperation"))
                {
                    linkedOperation = new LinkedOperation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("linkedAction"))
                {
                    linkedAction = new LinkedAction(property.Value.GetString());
                    continue;
                }
            }
            return new LinkedOperationRule(linkedOperation, linkedAction);
        }
    }
}
