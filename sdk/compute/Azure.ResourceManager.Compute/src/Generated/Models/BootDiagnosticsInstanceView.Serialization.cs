// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class BootDiagnosticsInstanceView : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ConsoleScreenshotBlobUri != null)
            {
                writer.WritePropertyName("consoleScreenshotBlobUri");
                writer.WriteStringValue(ConsoleScreenshotBlobUri);
            }
            if (SerialConsoleLogBlobUri != null)
            {
                writer.WritePropertyName("serialConsoleLogBlobUri");
                writer.WriteStringValue(SerialConsoleLogBlobUri);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteObjectValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static BootDiagnosticsInstanceView DeserializeBootDiagnosticsInstanceView(JsonElement element)
        {
            string consoleScreenshotBlobUri = default;
            string serialConsoleLogBlobUri = default;
            InstanceViewStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consoleScreenshotBlobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    consoleScreenshotBlobUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialConsoleLogBlobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialConsoleLogBlobUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value);
                    continue;
                }
            }
            return new BootDiagnosticsInstanceView(consoleScreenshotBlobUri, serialConsoleLogBlobUri, status);
        }
    }
}
