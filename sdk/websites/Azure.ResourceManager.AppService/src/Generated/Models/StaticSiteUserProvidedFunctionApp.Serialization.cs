// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteUserProvidedFunctionApp : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FunctionAppResourceId))
            {
                writer.WritePropertyName("functionAppResourceId");
                writer.WriteStringValue(FunctionAppResourceId);
            }
            if (Optional.IsDefined(FunctionAppRegion))
            {
                writer.WritePropertyName("functionAppRegion");
                writer.WriteStringValue(FunctionAppRegion);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StaticSiteUserProvidedFunctionApp DeserializeStaticSiteUserProvidedFunctionApp(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> functionAppResourceId = default;
            Optional<string> functionAppRegion = default;
            Optional<DateTimeOffset> createdOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("functionAppResourceId"))
                        {
                            functionAppResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionAppRegion"))
                        {
                            functionAppRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StaticSiteUserProvidedFunctionApp(id, name, type, kind.Value, functionAppResourceId.Value, functionAppRegion.Value, Optional.ToNullable(createdOn));
        }
    }
}
