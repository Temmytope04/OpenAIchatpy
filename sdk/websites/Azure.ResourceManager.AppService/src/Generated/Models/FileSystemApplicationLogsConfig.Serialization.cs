// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class FileSystemApplicationLogsConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static FileSystemApplicationLogsConfig DeserializeFileSystemApplicationLogsConfig(JsonElement element)
        {
            Optional<WebAppLogLevel> level = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    level = property.Value.GetString().ToWebAppLogLevel();
                    continue;
                }
            }
            return new FileSystemApplicationLogsConfig(Optional.ToNullable(level));
        }
    }
}
