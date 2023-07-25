// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventRecommendedActionsItem
    {
        internal static ResourceHealthEventRecommendedActionsItem DeserializeResourceHealthEventRecommendedActionsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> groupId = default;
            Optional<string> actionText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    groupId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actionText"u8))
                {
                    actionText = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceHealthEventRecommendedActionsItem(Optional.ToNullable(groupId), actionText.Value);
        }
    }
}
