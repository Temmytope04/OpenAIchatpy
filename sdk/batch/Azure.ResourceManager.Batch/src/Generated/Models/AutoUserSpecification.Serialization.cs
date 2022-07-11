// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class AutoUserSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope.Value.ToSerialString());
            }
            if (Optional.IsDefined(ElevationLevel))
            {
                writer.WritePropertyName("elevationLevel");
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static AutoUserSpecification DeserializeAutoUserSpecification(JsonElement element)
        {
            Optional<AutoUserScope> scope = default;
            Optional<ElevationLevel> elevationLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scope = property.Value.GetString().ToAutoUserScope();
                    continue;
                }
                if (property.NameEquals("elevationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToElevationLevel();
                    continue;
                }
            }
            return new AutoUserSpecification(Optional.ToNullable(scope), Optional.ToNullable(elevationLevel));
        }
    }
}
