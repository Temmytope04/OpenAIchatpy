// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    internal partial class ErrorDetails
    {
        internal static ErrorDetails DeserializeErrorDetails(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<ErrorAdditionalInfo>> additionalInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorAdditionalInfo> array = new List<ErrorAdditionalInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorAdditionalInfo.DeserializeErrorAdditionalInfo(item));
                    }
                    additionalInfo = array;
                    continue;
                }
            }
            return new ErrorDetails(code.Value, message.Value, Optional.ToList(additionalInfo));
        }
    }
}
