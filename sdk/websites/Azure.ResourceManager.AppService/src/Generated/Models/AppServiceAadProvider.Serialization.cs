// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAadProvider : IUtf8JsonSerializable, IJsonModel<AppServiceAadProvider>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceAadProvider>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceAadProvider>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Registration != null)
            {
                writer.WritePropertyName("registration"u8);
                writer.WriteObjectValue(Registration);
            }
            if (Login != null)
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login);
            }
            if (Validation != null)
            {
                writer.WritePropertyName("validation"u8);
                writer.WriteObjectValue(Validation);
            }
            if (IsAutoProvisioned.HasValue)
            {
                writer.WritePropertyName("isAutoProvisioned"u8);
                writer.WriteBooleanValue(IsAutoProvisioned.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        AppServiceAadProvider IJsonModel<AppServiceAadProvider>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceAadProvider(document.RootElement, options);
        }

        internal static AppServiceAadProvider DeserializeAppServiceAadProvider(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            AppServiceAadRegistration registration = default;
            AppServiceAadLoginFlow login = default;
            AppServiceAadValidation validation = default;
            bool? isAutoProvisioned = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registration = AppServiceAadRegistration.DeserializeAppServiceAadRegistration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    login = AppServiceAadLoginFlow.DeserializeAppServiceAadLoginFlow(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validation = AppServiceAadValidation.DeserializeAppServiceAadValidation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isAutoProvisioned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProvisioned = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceAadProvider(
                enabled,
                registration,
                login,
                validation,
                isAutoProvisioned,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceAadProvider>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support '{options.Format}' format.");
            }
        }

        AppServiceAadProvider IPersistableModel<AppServiceAadProvider>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceAadProvider(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceAadProvider>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
