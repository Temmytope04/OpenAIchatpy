// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class SasDefinitionAttributes : IUtf8JsonSerializable, IJsonModel<SasDefinitionAttributes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SasDefinitionAttributes>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SasDefinitionAttributes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SasDefinitionAttributes>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SasDefinitionAttributes>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Created))
                {
                    writer.WritePropertyName("created"u8);
                    writer.WriteNumberValue(Created.Value, "U");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Updated))
                {
                    writer.WritePropertyName("updated"u8);
                    writer.WriteNumberValue(Updated.Value, "U");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RecoverableDays))
                {
                    writer.WritePropertyName("recoverableDays"u8);
                    writer.WriteNumberValue(RecoverableDays.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RecoveryLevel))
                {
                    writer.WritePropertyName("recoveryLevel"u8);
                    writer.WriteStringValue(RecoveryLevel.Value.ToString());
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SasDefinitionAttributes IJsonModel<SasDefinitionAttributes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasDefinitionAttributes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSasDefinitionAttributes(document.RootElement, options);
        }

        internal static SasDefinitionAttributes DeserializeSasDefinitionAttributes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<int> recoverableDays = default;
            Optional<DeletionRecoveryLevel> recoveryLevel = default;
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
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("updated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updated = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("recoverableDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoverableDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryLevel = new DeletionRecoveryLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SasDefinitionAttributes(Optional.ToNullable(enabled), Optional.ToNullable(created), Optional.ToNullable(updated), Optional.ToNullable(recoverableDays), Optional.ToNullable(recoveryLevel), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SasDefinitionAttributes>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasDefinitionAttributes)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SasDefinitionAttributes IPersistableModel<SasDefinitionAttributes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SasDefinitionAttributes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSasDefinitionAttributes(document.RootElement, options);
        }

        string IPersistableModel<SasDefinitionAttributes>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
