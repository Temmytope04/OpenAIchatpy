// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorAutomationRunbookReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("automationAccountId");
            writer.WriteStringValue(AutomationAccountId);
            writer.WritePropertyName("runbookName");
            writer.WriteStringValue(RunbookName);
            writer.WritePropertyName("webhookResourceId");
            writer.WriteStringValue(WebhookResourceId);
            writer.WritePropertyName("isGlobalRunbook");
            writer.WriteBooleanValue(IsGlobalRunbook);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUri");
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema");
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            writer.WriteEndObject();
        }

        internal static MonitorAutomationRunbookReceiver DeserializeMonitorAutomationRunbookReceiver(JsonElement element)
        {
            ResourceIdentifier automationAccountId = default;
            string runbookName = default;
            ResourceIdentifier webhookResourceId = default;
            bool isGlobalRunbook = default;
            Optional<string> name = default;
            Optional<Uri> serviceUri = default;
            Optional<bool> useCommonAlertSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automationAccountId"))
                {
                    automationAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runbookName"))
                {
                    runbookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webhookResourceId"))
                {
                    webhookResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isGlobalRunbook"))
                {
                    isGlobalRunbook = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        serviceUri = null;
                        continue;
                    }
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MonitorAutomationRunbookReceiver(automationAccountId, runbookName, webhookResourceId, isGlobalRunbook, name.Value, serviceUri.Value, Optional.ToNullable(useCommonAlertSchema));
        }
    }
}
