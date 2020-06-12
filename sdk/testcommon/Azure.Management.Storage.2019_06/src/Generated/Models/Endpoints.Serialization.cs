// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class Endpoints : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Blob != null)
            {
                writer.WritePropertyName("blob");
                writer.WriteStringValue(Blob);
            }
            if (Queue != null)
            {
                writer.WritePropertyName("queue");
                writer.WriteStringValue(Queue);
            }
            if (Table != null)
            {
                writer.WritePropertyName("table");
                writer.WriteStringValue(Table);
            }
            if (File != null)
            {
                writer.WritePropertyName("file");
                writer.WriteStringValue(File);
            }
            if (Web != null)
            {
                writer.WritePropertyName("web");
                writer.WriteStringValue(Web);
            }
            if (Dfs != null)
            {
                writer.WritePropertyName("dfs");
                writer.WriteStringValue(Dfs);
            }
            if (MicrosoftEndpoints != null)
            {
                writer.WritePropertyName("microsoftEndpoints");
                writer.WriteObjectValue(MicrosoftEndpoints);
            }
            if (InternetEndpoints != null)
            {
                writer.WritePropertyName("internetEndpoints");
                writer.WriteObjectValue(InternetEndpoints);
            }
            writer.WriteEndObject();
        }

        internal static Endpoints DeserializeEndpoints(JsonElement element)
        {
            string blob = default;
            string queue = default;
            string table = default;
            string file = default;
            string web = default;
            string dfs = default;
            StorageAccountMicrosoftEndpoints microsoftEndpoints = default;
            StorageAccountInternetEndpoints internetEndpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("table"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("web"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    web = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dfs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dfs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("microsoftEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftEndpoints = StorageAccountMicrosoftEndpoints.DeserializeStorageAccountMicrosoftEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("internetEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internetEndpoints = StorageAccountInternetEndpoints.DeserializeStorageAccountInternetEndpoints(property.Value);
                    continue;
                }
            }
            return new Endpoints(blob, queue, table, file, web, dfs, microsoftEndpoints, internetEndpoints);
        }
    }
}
