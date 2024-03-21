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
    public partial class MigrateSchemaSqlServerSqlDBTaskOutputError : IUtf8JsonSerializable, IJsonModel<MigrateSchemaSqlServerSqlDBTaskOutputError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSchemaSqlServerSqlDBTaskOutputError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSchemaSqlServerSqlDBTaskOutputError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskOutputError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CommandText))
            {
                writer.WritePropertyName("commandText"u8);
                writer.WriteStringValue(CommandText);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorText))
            {
                writer.WritePropertyName("errorText"u8);
                writer.WriteStringValue(ErrorText);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSchemaSqlServerSqlDBTaskOutputError IJsonModel<MigrateSchemaSqlServerSqlDBTaskOutputError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskOutputError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSchemaSqlServerSqlDBTaskOutputError(document.RootElement, options);
        }

        internal static MigrateSchemaSqlServerSqlDBTaskOutputError DeserializeMigrateSchemaSqlServerSqlDBTaskOutputError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string commandText = default;
            string errorText = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commandText"u8))
                {
                    commandText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorText"u8))
                {
                    errorText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSchemaSqlServerSqlDBTaskOutputError(id, resultType, serializedAdditionalRawData, commandText, errorText);
        }

        BinaryData IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskOutputError)} does not support '{options.Format}' format.");
            }
        }

        MigrateSchemaSqlServerSqlDBTaskOutputError IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSchemaSqlServerSqlDBTaskOutputError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskOutputError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSchemaSqlServerSqlDBTaskOutputError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
