// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSyncCompleteCommandProperties : IUtf8JsonSerializable, IJsonModel<MigrateSyncCompleteCommandProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSyncCompleteCommandProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSyncCompleteCommandProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSyncCompleteCommandProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (options.Format != "W" && Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteObjectValue(Output);
            }
            if (Optional.IsDefined(CommandId))
            {
                writer.WritePropertyName("commandId"u8);
                writer.WriteStringValue(CommandId);
            }
            writer.WritePropertyName("commandType"u8);
            writer.WriteStringValue(CommandType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        MigrateSyncCompleteCommandProperties IJsonModel<MigrateSyncCompleteCommandProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSyncCompleteCommandProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSyncCompleteCommandProperties(document.RootElement, options);
        }

        internal static MigrateSyncCompleteCommandProperties DeserializeMigrateSyncCompleteCommandProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MigrateSyncCompleteCommandInput input = default;
            MigrateSyncCompleteCommandOutput output = default;
            string commandId = default;
            CommandType commandType = default;
            IReadOnlyList<ODataError> errors = default;
            CommandState? state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = MigrateSyncCompleteCommandInput.DeserializeMigrateSyncCompleteCommandInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = MigrateSyncCompleteCommandOutput.DeserializeMigrateSyncCompleteCommandOutput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("commandId"u8))
                {
                    commandId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commandType"u8))
                {
                    commandType = new CommandType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new CommandState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSyncCompleteCommandProperties(
                commandType,
                errors ?? new ChangeTrackingList<ODataError>(),
                state,
                serializedAdditionalRawData,
                input,
                output,
                commandId);
        }

        BinaryData IPersistableModel<MigrateSyncCompleteCommandProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSyncCompleteCommandProperties)} does not support '{options.Format}' format.");
            }
        }

        MigrateSyncCompleteCommandProperties IPersistableModel<MigrateSyncCompleteCommandProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSyncCompleteCommandProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSyncCompleteCommandProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSyncCompleteCommandProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
