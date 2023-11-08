// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    [ModelReaderProxy(typeof(UnknownHookInfo))]
    public partial class NotificationHook : IUtf8JsonSerializable, IJsonModel<NotificationHook>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHook>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NotificationHook>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hookType"u8);
            writer.WriteStringValue(HookKind.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Id))
                {
                    writer.WritePropertyName("hookId"u8);
                    writer.WriteStringValue(Id);
                }
            }
            writer.WritePropertyName("hookName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(InternalExternalLink))
            {
                writer.WritePropertyName("externalLink"u8);
                writer.WriteStringValue(InternalExternalLink);
            }
            if (Optional.IsCollectionDefined(Administrators))
            {
                writer.WritePropertyName("admins"u8);
                writer.WriteStartArray();
                foreach (var item in Administrators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NotificationHook IJsonModel<NotificationHook>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NotificationHook)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHook(document.RootElement, options);
        }

        internal static NotificationHook DeserializeNotificationHook(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("hookType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Email": return EmailNotificationHook.DeserializeEmailNotificationHook(element);
                    case "Webhook": return WebNotificationHook.DeserializeWebNotificationHook(element);
                }
            }
            return UnknownHookInfo.DeserializeUnknownHookInfo(element);
        }

        BinaryData IModel<NotificationHook>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NotificationHook)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NotificationHook IModel<NotificationHook>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NotificationHook)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNotificationHook(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NotificationHook>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
