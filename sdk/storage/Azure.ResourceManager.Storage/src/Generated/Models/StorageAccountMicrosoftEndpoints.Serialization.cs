// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountMicrosoftEndpoints : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Blob))
            {
                writer.WritePropertyName("blob");
                writer.WriteStringValue(Blob);
            }
            if (Optional.IsDefined(Queue))
            {
                writer.WritePropertyName("queue");
                writer.WriteStringValue(Queue);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table");
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file");
                writer.WriteStringValue(File);
            }
            if (Optional.IsDefined(Web))
            {
                writer.WritePropertyName("web");
                writer.WriteStringValue(Web);
            }
            if (Optional.IsDefined(Dfs))
            {
                writer.WritePropertyName("dfs");
                writer.WriteStringValue(Dfs);
            }
            writer.WriteEndObject();
        }

        internal static StorageAccountMicrosoftEndpoints DeserializeStorageAccountMicrosoftEndpoints(JsonElement element)
        {
            Optional<string> blob = default;
            Optional<string> queue = default;
            Optional<string> table = default;
            Optional<string> file = default;
            Optional<string> web = default;
            Optional<string> dfs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"))
                {
                    blob = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queue"))
                {
                    queue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("table"))
                {
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("web"))
                {
                    web = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dfs"))
                {
                    dfs = property.Value.GetString();
                    continue;
                }
            }
            return new StorageAccountMicrosoftEndpoints(blob.Value, queue.Value, table.Value, file.Value, web.Value, dfs.Value);
        }
    }
}
