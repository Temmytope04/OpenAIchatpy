// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StackHCI.Models
{
    public partial class ClusterDesiredProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WindowsServerSubscription))
            {
                writer.WritePropertyName("windowsServerSubscription");
                writer.WriteStringValue(WindowsServerSubscription.Value.ToString());
            }
            if (Optional.IsDefined(DiagnosticLevel))
            {
                writer.WritePropertyName("diagnosticLevel");
                writer.WriteStringValue(DiagnosticLevel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ClusterDesiredProperties DeserializeClusterDesiredProperties(JsonElement element)
        {
            Optional<WindowsServerSubscription> windowsServerSubscription = default;
            Optional<DiagnosticLevel> diagnosticLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("windowsServerSubscription"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsServerSubscription = new WindowsServerSubscription(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diagnosticLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diagnosticLevel = new DiagnosticLevel(property.Value.GetString());
                    continue;
                }
            }
            return new ClusterDesiredProperties(Optional.ToNullable(windowsServerSubscription), Optional.ToNullable(diagnosticLevel));
        }
    }
}
