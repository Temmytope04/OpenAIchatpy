// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobError
    {
        internal static MediaJobError DeserializeMediaJobError(JsonElement element)
        {
            Optional<MediaJobErrorCode> code = default;
            Optional<string> message = default;
            Optional<MediaJobErrorCategory> category = default;
            Optional<MediaJobRetry> retry = default;
            Optional<IReadOnlyList<MediaJobErrorDetail>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    code = new MediaJobErrorCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    category = new MediaJobErrorCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retry = new MediaJobRetry(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaJobErrorDetail> array = new List<MediaJobErrorDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobErrorDetail.DeserializeMediaJobErrorDetail(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new MediaJobError(Optional.ToNullable(code), message.Value, Optional.ToNullable(category), Optional.ToNullable(retry), Optional.ToList(details));
        }
    }
}
