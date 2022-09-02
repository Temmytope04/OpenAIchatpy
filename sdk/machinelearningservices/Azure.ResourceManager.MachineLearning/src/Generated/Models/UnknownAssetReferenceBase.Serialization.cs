// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownAssetReferenceBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("referenceType");
            writer.WriteStringValue(ReferenceType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownAssetReferenceBase DeserializeUnknownAssetReferenceBase(JsonElement element)
        {
            ReferenceType referenceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referenceType"))
                {
                    referenceType = new ReferenceType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAssetReferenceBase(referenceType);
        }
    }
}
