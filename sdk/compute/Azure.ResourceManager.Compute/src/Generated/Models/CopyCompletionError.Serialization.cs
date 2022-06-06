// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CopyCompletionError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("errorCode");
            writer.WriteStringValue(ErrorCode.ToString());
            writer.WritePropertyName("errorMessage");
            writer.WriteStringValue(ErrorMessage);
            writer.WriteEndObject();
        }

        internal static CopyCompletionError DeserializeCopyCompletionError(JsonElement element)
        {
            CopyCompletionErrorReason errorCode = default;
            string errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"))
                {
                    errorCode = new CopyCompletionErrorReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new CopyCompletionError(errorCode, errorMessage);
        }
    }
}
