// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class UnknownGranularCopyLogDetails
    {
        internal static UnknownGranularCopyLogDetails DeserializeUnknownGranularCopyLogDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxOrderType copyLogDetailsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyLogDetailsType"u8))
                {
                    copyLogDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
            }
            return new UnknownGranularCopyLogDetails(copyLogDetailsType);
        }
    }
}
